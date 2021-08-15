using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoTooltest.PageObject
{
    public class EmailVerifierPage
    {
        IWebDriver driver;

        public EmailVerifierPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using ="contactDomain")]
        public IWebElement VerifyMail { get; set; }

        [FindsBy (How = How.Id, Using = "btnFindEmail")]
        public IWebElement VerifyMailButton { get; set; }

        public void SearchMail(string mailToVerify)
        {
            VerifyMail.SendKeys(mailToVerify);
            VerifyMailButton.Click();
        }

    }
}
