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
            List<Patient> pat = new List<Patient>();

            XmlSchemaSet schemaSet = new XmlSchemaSet();        
            schemaSet.Add("http://www.w3.org/2001/XMLSchema", "D:/Customer.xsd");
            schemaSet.Compile();

            // Retrieve the compiled XmlSchema object from the XmlSchemaSet
            // by iterating over the Schemas property.
            XmlSchema customerSchema = null;
            foreach (XmlSchema schema in schemaSet.Schemas())
            {
                customerSchema = schema;
            }

            // Iterate over each XmlSchemaElement in the Values collection
            // of the Elements property.
            foreach (XmlSchemaElement element in customerSchema.Elements.Values)
            {

                //Console.WriteLine("Element: {0}", element.Name);
                pat.Add(new Patient()
                {
                    TableName = element.Name,
                    ColumnName = element.Name
                });

                // Get the complex type of the Customer element.
                XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;

                // If the complex type has any attributes, get an enumerator 
                // and write each attribute name to the console.
                if (complexType.AttributeUses.Count > 0)
                {
                    IDictionaryEnumerator enumerator =
                        complexType.AttributeUses.GetEnumerator();

                    while (enumerator.MoveNext())
                    {
                        XmlSchemaAttribute attribute =
                            (XmlSchemaAttribute)enumerator.Value;

                        //Console.WriteLine("Attribute: {0}", attribute.Name);
                      
                        pat.Add(new Patient()
                        {
                            TableName = element.Name,
                            ColumnName = attribute.Name
                        });
                    }
                }

                // Get the sequence particle of the complex type.
                XmlSchemaSequence sequence = complexType.ContentTypeParticle as XmlSchemaSequence;

                // Iterate over each XmlSchemaElement in the Items collection.
                foreach (XmlSchemaElement childElement in sequence.Items)
                {
                    //Console.WriteLine("Element: {0}", childElement.Name);                   

                    pat.Add(new Patient()
                    {
                        TableName = element.Name,
                        ColumnName = childElement.Name
                    });

                    // Get the complex type of the Customer element.
                    XmlSchemaComplexType complexTypec = childElement.ElementSchemaType as XmlSchemaComplexType;

                    // If the complex type has any attributes, get an enumerator 
                    // and write each attribute name to the console.
                    if (complexTypec.AttributeUses.Count > 0)
                    {
                        IDictionaryEnumerator enumerator =
                            complexTypec.AttributeUses.GetEnumerator();

                        while (enumerator.MoveNext())
                        {
                            XmlSchemaAttribute attribute =
                                (XmlSchemaAttribute)enumerator.Value;

                            //Console.WriteLine("Attribute: {0}", attribute.Name);                          

                            pat.Add(new Patient()
                            {
                                TableName = childElement.Name,
                                ColumnName = attribute.Name
                            });
                        }
                    }
                }
                AddOrUpdate(pat);
            }
            return null;
        }

        public static void AddOrUpdate(List<Patient> pat)
        {         
            foreach (var kvp in pat)
            {               
                Console.WriteLine("TableName = {0}, Column = {1}", kvp.TableName, kvp.ColumnName);
            }
            Console.ReadLine();
            //var dictval = from x in pat
            //              where x.TableName.Contains("Customer")
            //              select x;
            //Console.WriteLine(dictval.First().TableName);
            //Console.ReadKey();
        }
      
         
    }
           
}

 
