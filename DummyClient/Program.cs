using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ICCDA;
using Schematron;

namespace DummyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Validator validator = new Validator();
                validator.AddSchema("D:/CCDA.xsd");
                validator.Validate(new XmlTextReader("D:/CCDA_787.xml"));
                ErrorLogging("Success");

                //var schematron = new Validator();
                //Schema schematronSchema = new Schema();
                //schematronSchema.Load(new FileStream("D:/Test.xsd", FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
                //schematron.AddSchema(schematronSchema);
                //schematron.Validate(instance);

            }
            catch (Exception ex)
            {
                ErrorLogging(ex.Message);
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
