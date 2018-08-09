using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using ICCDA;

namespace DummyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CCDAEngine.Connect("pmswebdatabasedev.database.windows.net", "PMS_EHR_New", "devlogin", "1231!#HOLA!");
         
            string myXMLfile = @"E:\CCDA_787.xml";
            DataSet ds = new DataSet();
            FileStream fsReadXml = new System.IO.FileStream(myXMLfile, System.IO.FileMode.Open);
            try
            {
                ds.ReadXml(fsReadXml);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                fsReadXml.Close();
            }
        }
    }
}
