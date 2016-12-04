using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1.Pages;

namespace UnitTestProject1.Sevices
{
    class WriteMailService
    {
        IWebDriver driver;
        public WriteMailService(IWebDriver driver) {
            
            this.driver = driver;
        }

        public void writeMessage() {
            MailPage mailPage = new MailPage(driver);
            mailPage.createMessage();
        }

        public void prepareMessage() {
            MailPage mailPage = new MailPage(driver);
            mailPage.prepareMessage("test", "test", "test");
        }

      
    }
}
