using System.Collections.Generic;

namespace AbstractFactory_OS_Begin.Classes.Windows
{
    public class WindowsDevice
    {
        private MicrosoftAccount _user;
        private WindowsStore _appStore;

        public WindowsDevice(MicrosoftAccount user, WindowsStore appStore)
        {
            _user = user;
            _appStore = appStore;
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
