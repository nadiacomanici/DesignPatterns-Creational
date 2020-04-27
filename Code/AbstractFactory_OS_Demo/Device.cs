using System;
using System.Collections.Generic;
using AbstractFactory_OS_Demo.Classes.Contract;

namespace AbstractFactory_OS_Demo
{
    public class Device
    {
        private IAccount _userAccount;
        private IStore _appStore;

        public Device(IAccount userAccount, IStore appStore)
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
