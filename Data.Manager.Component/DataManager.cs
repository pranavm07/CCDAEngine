using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dto;

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
                    Schema= dt.Rows[i]["SCHEMA"].ToString(),
                    TableName= dt.Rows[i]["Table"].ToString(),
                    TableType= dt.Rows[i]["TYPE"].ToString()
                };
                tables.Add(schema);
            }

            return tables;
        }
    }
}
