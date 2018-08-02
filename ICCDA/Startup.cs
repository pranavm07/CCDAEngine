using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
using Connector.Component;
using UnityDependencyResolver.Lib;
namespace ICCDA
{
    public class Startup
    {
        public static void Register()
        {
            IUnityContainer container = new UnityContainer();
            ConnectorDependencyRegister.RegisterConnectionDependency(container);
            container.Resolve<UnityContainer>();
        }
    }
}
