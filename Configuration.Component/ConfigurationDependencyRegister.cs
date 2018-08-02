using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity;
using Data.Manager.Component;
namespace Configuration.Component
{
    public class ConfigurationDependencyRegister
    {
        public static void RegisterConfigurationDependency(IUnityContainer container)
        {
            DataManagerDependencyRegister.RegisterDMComponents(container);
            container.RegisterType<ISchemaGenerator, SchemaGenerator>();
            container.RegisterType<ISchemaMapper, SchemaMapper>();
        }
    }
}
