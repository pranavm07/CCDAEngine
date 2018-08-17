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

namespace DummyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
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


        public static  string SchemaGeneration()
        {


            //*************************************************
            //Code for convert model to xsd file

            //var schemas = new XmlSchemas();
            //var exporter = new XmlSchemaExporter(schemas);
            //var mapping = new XmlReflectionImporter().ImportTypeMapping(typeof(ConfidentialityCode));
            //exporter.ExportTypeMapping(mapping);
            //var schemaWriter = new StringWriter();
            //foreach (XmlSchema schema in schemas)
            //{
            //    schema.Write(schemaWriter);
            //}

            //return schemaWriter.ToString();



            //**************************************
            //Read Xsd file and get element name


            var xs = XNamespace.Get("http://www.w3.org/2001/XMLSchema");           
            var doc = XDocument.Load("D:/Confidentialitycode.xsd");
            foreach (var el in doc.Descendants(xs + "element"))
            {                
                Console.WriteLine(el.FirstAttribute.Value);
                Console.WriteLine(el.Attribute("name").Value);                
            }
            Console.ReadLine();
            return null;
        }

    }
}
