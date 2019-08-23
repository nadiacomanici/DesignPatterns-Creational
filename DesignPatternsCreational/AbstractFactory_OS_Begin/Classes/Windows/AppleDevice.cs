using System.Collections.Generic;
using AbstractFactory_OS_Begin.Classes.MacOS;

namespace AbstractFactory_OS_Begin.Classes.Windows
{
    public class AppleDevice
    {
        private AppleUser _user;
        private AppleStore _appStore;

        public AppleDevice()
        {
            _user = new AppleUser("5667", "ncomanici");
            _appStore = new AppleStore();
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
