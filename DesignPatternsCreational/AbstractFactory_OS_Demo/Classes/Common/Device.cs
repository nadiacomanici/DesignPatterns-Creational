using System.Collections.Generic;
using AbstractFactory_OS_Demo.Classes.Contracts;

namespace AbstractFactory_OS_Demo.Classes.Common
{
    public class Device
    {
        private IUser _user;
        private IAppStore _appStore;

        public Device(IManufacturerFactory manufacturerFactory)
        {
            _user = manufacturerFactory.CreateUser();
            _appStore = manufacturerFactory.CreateAppStore();
        }

        public bool LogIntoAppStore()
        {
            return _appStore.Login(_user);
        }

        public List<string> SearchForApp(string searchKeyword)
        {
            return _appStore.SearchApp(_user, searchKeyword);
        }
    }
}
