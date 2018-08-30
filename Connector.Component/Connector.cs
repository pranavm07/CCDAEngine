using Configuration.Component;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Connector.Component
{
    public class Connector 
    {
        public static SqlConnection Connect(string serverAddress, string dbName, string userName, string password)
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder
            {
                ["Data Source"] = serverAddress,
                ["integrated Security"] = false,
                ["Initial Catalog"] = dbName,
                ["user id"] = userName,
                ["password"] = password
            };
            SqlConnection catalogueConnection = new SqlConnection(connectionBuilder.ConnectionString);
            //var result = SchemaGenerator.GenerateDbSchema(catalogueConnection);
            return catalogueConnection;
        }
    }
}
