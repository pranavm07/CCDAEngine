using Data.Manager.Component;
using Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Configuration.Component
{
    public class SchemaGenerator
    {
        public static List<DbSchemaDto> GenerateDbSchema(SqlConnection connection)
        {
            var schema = DataManager.GenerateDbSchema(connection);
            GenerateHTML(schema);
            return schema;
        }
        public static void GenerateHTML(List<DbSchemaDto> dbSchemas)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><head>DB Tables");
            sb.Append("<style>table {border-collapse: collapse;}table, td, th {border: 1px solid black;}</style>");
            sb.Append("</head><body><div>");
            sb.Append("<table><tr>");
            sb.Append("<th>S. No</th><th>DB Name</th><th>Table</th><th>TYPE</th><th>Select</th></tr>");
            for (int i = 0; i < dbSchemas.Count; i++)
            {
               
                sb.Append("<tr>");
                sb.Append("<td>" + (i+1).ToString() + "</td>" + "<td>" + dbSchemas[i].DBName + "</td>" + "<td>" 
                            + dbSchemas[i].TableName + "</td>" + "<td>" + dbSchemas[i].TableType + "</td>");
                sb.Append("<td><button onclick='' id="+""+dbSchemas[i].TableName+""+">"+"Select</button></td>"); 
                sb.Append("</tr>");
                
            }

            sb.Append("</div></body></html>");
            Writefile(sb);
        }
      
        static void Writefile(StringBuilder sb)
        {
            string filename = "schema.html";
            FileSecurity fSecurity = new FileSecurity();
           // fSecurity.AddAccessRule(new FileSystemAccessRule(@"DomainName\AccountName", FileSystemRights.ReadData, AccessControlType.Allow));

            using (FileStream fs =  File.Create(filename, 1024, FileOptions.WriteThrough))
            {
                byte[] content = new UTF8Encoding(true).GetBytes(sb.ToString());
                fs.Write(content, 0, content.Length);
                System.Diagnostics.Process.Start(filename);
            }
           // sw.Write(sb.ToString());
            
        }
    }
}
