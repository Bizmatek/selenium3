using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using UnitTestProject1.BO;
using UnitTestProject1.Page;
using UnitTestProject1.Sevices;
using UnitTestProject1.TestData;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://yandex.ru";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            User user = BOGenerator.createUser("super.bizmartek", "nfhfyhb87KGD");

            new LoginLogoutService(driver).login(user);
            Assert.IsTrue(new LoginPage(driver).isPostDysplayed());

            new LoginLogoutService(driver).logout(user);
            Assert.IsTrue(new LoginPage(driver).isPasswdDisplayed());

            driver.Close();


        }
    }
}
