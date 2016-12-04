using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Pages
{
    class MailPage
    {
        IWebDriver driver;

        public MailPage(IWebDriver driver) {

            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "//a[@href = '#compose']")]
        private IWebElement writeButton;

        [FindsBy(How = How.XPath, Using = "//div[@name = 'to']")]
        private IWebElement msgTo;

        [FindsBy(How = How.XPath, Using = "//input[@name = 'subj']")]
        private IWebElement msgSubj;

        [FindsBy(How = How.XPath, Using = "//*[@id='cke_1_contents']/textarea")]
        private IWebElement msgText;

        public void createMessage() {
            new Actions(driver).Click(writeButton).Build().Perform(); 
        }

        public void prepareMessage(string to, string subj, string text ) {
            new Actions(driver).SendKeys(to).SendKeys(subj).SendKeys(text).Build().Perform();
        }

        public void saveMessage() { }

        public void deleteMessage() { }
    }
}
