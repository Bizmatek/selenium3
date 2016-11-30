using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.BO;
using UnitTestProject1.Page;

namespace UnitTestProject1.Sevices
{
    class LoginLogoutService
    {
        private IWebDriver driver;

        public LoginLogoutService(IWebDriver driver) {
            this.driver = driver;
        }

        public void login(User user) {
            LoginPage page = new LoginPage(driver);
            page.setLoginAndPasswd(user.getLogin(), user.getPasswd());
            page.login();
        }

        public void logout(User user) {
            LoginPage page = new LoginPage(driver);
            page.logout();
        }

    }
}
