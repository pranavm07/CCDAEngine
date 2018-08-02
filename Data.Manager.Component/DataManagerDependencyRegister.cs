using Unity;

namespace Data.Manager.Component
{
    public class DataManagerDependencyRegister
    {
        public static void RegisterDMComponents(IUnityContainer container)
        {
            container.RegisterType<IDataManager, DataManager>();
        }
    }
}
