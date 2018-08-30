using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dto;
using System.Xml.Linq;

namespace Data.Manager.Component
{
    public class DataManager
    {
        public static List<DbSchemaDto> GenerateDbSchema(SqlConnection connection)
        {
            List<DbSchemaDto> tables = new List<DbSchemaDto>();
            SqlCommand sqlCmd;
            string sql = "SELECT TABLE_CATALOG AS [DB Name],	TABLE_SCHEMA AS [SCHEMA],	TABLE_NAME AS [Table],	TABLE_TYPE AS [TYPE] FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG =" + "'" + connection.Database + "'";

            connection.Open();
            sqlCmd = new SqlCommand(sql, connection);
            //SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            DataTable dt = new DataTable
            {
                TableName = "TanentSchemaInfo"
            };
            dt.Load(sqlCmd.ExecuteReader());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DbSchemaDto schema = new DbSchemaDto()
                {
                    DBName = dt.Rows[i]["DB Name"].ToString(),
                    Schema = dt.Rows[i]["SCHEMA"].ToString(),
                    TableName = dt.Rows[i]["Table"].ToString(),
                    TableType = dt.Rows[i]["TYPE"].ToString()
                };
                tables.Add(schema);
            }

            return tables;
        }

        public static string QueryGenerator()
        {

            try
            {
                StringBuilder sb = new StringBuilder();
                StringBuilder query = new StringBuilder();
                XElement xelement = XElement.Load(@"D:\patient.xml");

                IEnumerable<XElement> tables = xelement.Elements();

                foreach (var entity in tables)
                {
                    sb.Append("Select " +" "+ entity.Attribute("keywords").Value + " " ) ;                   
               
                    var from = entity.Attribute("name").Value + " As " + entity.Attribute("alias").Value;
                    IEnumerable<XElement> table = entity.Elements();

                    var fkEntities = table.Where(x => !string.IsNullOrEmpty(x.Attribute("ForeignKeyTable").Value))
                        .Select(x => new
                        {
                            rightCol = x.Attribute("ForeignKeyColumn").Value,
                            Leftcol = x.Attribute("name").Value,
                            Alias = x.Attribute("alias").Value,
                            Condition = x.Attribute("Condition").Value,
                            Joins= x.Attribute("Joins").Value
                        }).Distinct().ToList();

                    var condition = table.Where(x => !string.IsNullOrEmpty(x.Attribute("Condition").Value))
                        .Select(x => new
                        {
                            columnname= x.Attribute("name").Value,
                            conditions = x.Attribute("Condition").Value                          
                        }).Distinct().ToList();                    

                    foreach (var item in table)
                    {
                        if (string.IsNullOrEmpty(item.Attribute("ForeignKeyTable").Value) && string.IsNullOrEmpty(item.Attribute("Condition").Value))
                        {
                            string st = item.Attribute("name").Value + " AS" + " " + item.Attribute("Displayname").Value + ",";
                            sb.Append(st);
                        }
                        else if (!string.IsNullOrEmpty(item.Attribute("ForeignKeyTable").Value) && string.IsNullOrEmpty(item.Attribute("Condition").Value))
                        {
                            sb.Append(item.Attribute("ForeignTableColumn").Value + " AS" + " " + item.Attribute("Displayname").Value + ",");
                        }
                    }

                    sb.Append("from " + from + " ");
                    sb.Replace(",from", " from");

                    if (fkEntities.Count > 0)
                    {
                        foreach (var item in fkEntities)
                        {
                            sb.AppendLine(item.Joins + " " + table.Where(x => x.Attribute("ForeignKeyColumn").Value == item.rightCol)
                            .Select(x => x.Attribute("ForeignKeyTable").Value + " As " + item.Alias).Distinct().FirstOrDefault() + " " + " on "
                            + item.Leftcol + "=" + item.rightCol);
                        }
                    }

                    foreach (var item in condition)
                    {
                        sb.AppendLine(item.conditions +" " + item.columnname);
                    }

                    query.Append(sb);
                    query.Append(Environment.NewLine);
                    sb.Length = 0;
                }
                InitializeQuery(query.ToString());
                return null;
            }
            catch (Exception ex)
            {            
                throw ex;
            }
        }


        public static string InitializeQuery(string Query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=nhwebservers.database.windows.net;Initial Catalog=NexusPracticeDb;User ID=NemoDbUser;Password=1231!#HOLA!") ;
            SqlCommand cmd = new SqlCommand(Query,conn);
            string patientID = "9140FDB9-27CF-4E1A-9565-613966C33833";
            cmd.Parameters.AddWithValue("@patientId", patientID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
          
            return null;
        }
    }
}

