using Connector.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICCDA
{
    public sealed class CCDAEngine
    {
       
        static CCDAEngine()
        {
            
            Startup.Register();
        }

        public static  bool Connect(string serverAddress, string dbName, string userName, string password)
        {
            var result = Connector.Component.Connector.Connect(serverAddress, dbName, userName, password);
            return result.State == System.Data.ConnectionState.Open ? true : false;
        }
    }
}
