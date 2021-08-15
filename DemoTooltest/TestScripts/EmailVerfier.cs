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
            verifyMail.SearchMail("narod@mail.com");
            string resultStatus = driver.FindElement(By.CssSelector("#emailVerifyResultWrap > div:nth-child(1) > div.boxVerifyResult.col-lg-8.col-lg-push-2.highRisk > h1")).Text;
            Assert.True(resultStatus.Contains("Unverifiable"), resultStatus);






        }
    }
}
