using System.Collections.Generic;
using AbstractFactory_OS_End.Classes.Contracts;

namespace AbstractFactory_OS_End.Classes.Windows
{
    public class Device
    {
        private readonly IUserAccount _user;
        private readonly IAppStore _appStore;

        public Device(IManufacturerFactory factory)
        {
            _user = factory.CreateUser();
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
        internal void ResetUserPassword()
        {
            _user.ResetPassword();
        }
    }
}
