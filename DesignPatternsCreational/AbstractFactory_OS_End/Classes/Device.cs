using System.Collections.Generic;
using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.Windows
{
    public class Device
    {
        private readonly IUser _user;
        private readonly IAppStore _appStore;

        public Device(IManufacturerFactory factory, string userId, string username)
        {
            _user = factory.CreateUser(userId, username);
            _appStore = factory.CreateAppStore();
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
