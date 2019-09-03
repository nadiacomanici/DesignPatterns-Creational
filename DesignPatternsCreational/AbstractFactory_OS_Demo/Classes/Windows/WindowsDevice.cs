using System;
using System.Collections.Generic;

namespace AbstractFactory_OS_Demo.Classes.Windows
{
    public class WindowsDevice
    {
        private MicrosoftAccount _userAccount;
        private WindowsStore _appStore;

        public WindowsDevice(MicrosoftAccount userAccount, WindowsStore appStore)
        {
            _userAccount = userAccount;
            _appStore = appStore;
        }

        public bool LogIntoAppStore()
        {
            return _appStore.Login(_userAccount);
        }

        public List<string> SearchForApp(string searchKeyword)
        {
            return _appStore.SearchApp(_userAccount, searchKeyword);
        }

        internal void ResetUserPassword()
        {
            _userAccount.ResetPassword();
        }
    }
}
