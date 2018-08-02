using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Connector.Component
{
    public interface IConnector
    {
        SqlConnection Connect(string serverAddress, string dbName, string username, string password);
    }
}
