using DemoTooltest.BaseClass;
using DemoTooltest.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTooltest.TestScripts
{
    [TestFixture]
   public class EmailVerfier : BaseTest
    {
        [Test]
        public void CheckStatusOK()
        {
            var verifyMail = new EmailVerifierPage(driver);
            verifyMail.SearchMail("narodenfront17@outlook.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            string resultStatus = driver.FindElement(By.XPath("//div[@class='boxVerifyResult col-lg-8 col-lg-push-2 lowRisk']")).Text;
            Assert.True(resultStatus.Contains("Safe"), resultStatus);
        }
        [Test]
        public void CheckStatusUnverifiable()
        {
            var verifyMail = new EmailVerifierPage(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            verifyMail.SearchMail("narod@mail.com");
            string resultStatus = driver.FindElement(By.XPath("//div[@class='boxVerifyResult col-lg-8 col-lg-push-2 highRisk']")).Text;
            Assert.True(resultStatus.Contains("Unverifiable"), resultStatus);
        }
    }
}
