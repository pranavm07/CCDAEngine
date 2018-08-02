using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;

namespace Connector.Component
{
    public class ConnectorDependencyRegister
    {
        public static void RegisterConnectionDependency(IUnityContainer container)
        {
            container.RegisterType<IConnector, Connector>();
        }
    }
}
