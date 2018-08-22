using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ICCDA;
using Schematron;
using MySql.Data.MySqlClient;
using System.Xml.Serialization;
using System.Xml.Schema;
using static DummyClient.Components;
using System.Xml.Linq;
using System.Collections;
using System.Xml.XPath;
using System.Diagnostics;

namespace DummyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SchemaGeneration();
                MySqlConnection mysqlconnection;
                string server;
                string database;
                string uid;
                string password;

                server = "localhost";
                database = "testdb";
                uid = "root";
                password = "123456";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
                List<string> list = new List<string>();
                mysqlconnection = new MySqlConnection(connectionString);

                mysqlconnection.Open();
                string query = "select * from user";
                MySqlCommand cmd = new MySqlCommand(query, mysqlconnection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list.Add(dataReader["id"] + "");
                    list.Add(dataReader["firstname"] + "");
                    list.Add(dataReader["lastname"] + "");
                }
                dataReader.Close();

                mysqlconnection.Close();

                Validator validator = new Validator();
                validator.AddSchema("E:/CDA_SDTCSchema/infrastructure/cda/CDA_SDTC.xsd");
                validator.Validate("E:/CCDASchema/sample/validCCDA.xml");
                ErrorLogging("Success");

                //var schematron = new Validator();
                //Schema schematronSchema = new Schema();
                //schematronSchema.Load(new FileStream("D:/Test.xsd", FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
                //schematron.AddSchema(schematronSchema);
                //schematron.Validate(instance);

            }
            catch (MySqlException myex)
            {
                switch (myex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
            catch (Exception ex)
             {
                //ErrorLogging(ex.Message);
            }
        }


        public static void ErrorLogging(string Message)
        {
            string strPath = @"D:\Log.txt";

            StreamWriter sw = File.CreateText(strPath);
            sw.Flush();
            sw.Close();

            if (!File.Exists(strPath))
            {
                File.Create(strPath).Dispose();
            }
            using (sw = File.AppendText(strPath))
            {
                sw.WriteLine("Message: " + Message);

            }
        }


        public static string SchemaGeneration()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Select ");
                string innerjoin = "Inner Join";
                string leftjoin = "Outer Join";
                string JoinTableName = string.Empty;
                XElement xelement = XElement.Load(@"patient.xml");
                var from = xelement.Attribute("name").Value;
                IEnumerable<XElement> table = xelement.Elements();
                List<string> AttrinuteList = new List<string>();

                var fkEntities = table.Where(x => !string.IsNullOrEmpty(x.Attribute("ForeignKeyTable").Value))
                    .Select(x => new
                    {
                        rightCol = x.Attribute("ForeignKeyColumn").Value,
                        Leftcol = x.Attribute("name").Value
                    }).ToList();
                foreach (var item in table)
                {
                    if (string.IsNullOrEmpty(item.Attribute("ForeignKeyTable").Value))
                    {
                        string st = item.Attribute("name").Value + " AS" + " " + item.Attribute("Displayname").Value + ",";
                        sb.Append(st);
                    }
                    else
                    {
                        sb.Append(item.Attribute("ForeignKeyColumn").Value + " AS" + " " + item.Attribute("Displayname").Value);
                    }
                }
                sb.Append(" from " + from + " ");
                if (fkEntities.Count > 0)
                {
                    foreach (var item in fkEntities)
                    {
                        sb.AppendLine(innerjoin + " " + table.Where(x => x.Attribute("ForeignKeyColumn").Value == item.rightCol)
                            .Select(x => x.Attribute("ForeignKeyTable").Value).FirstOrDefault() + " " + " on "
                            + item.Leftcol + "=" + item.rightCol);
                    }
                }





                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
      
         
    }
           
}

 
