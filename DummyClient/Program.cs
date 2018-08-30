using System;
using System.Collections.Generic;
using System.IO;
using Schematron;
using MySql.Data.MySqlClient;
using Data.Manager.Component;

namespace DummyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataManager.QueryGenerator();

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

    }
}

 
