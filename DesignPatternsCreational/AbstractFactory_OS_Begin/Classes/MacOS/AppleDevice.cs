using System.Collections.Generic;

namespace AbstractFactory_OS_Begin.Classes.MacOS
{
    public class AppleDevice
    {
        private AppleUser _userAccount;
        private AppleStore _appStore;

        public AppleDevice()
        {
            _userAccount = new AppleUser("5667", "ncomanici");
            _appStore = new AppleStore();
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
