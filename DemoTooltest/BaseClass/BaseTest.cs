using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTooltest.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://toolset.sopro.io/email-verifier";
            IWebElement loginBtn = driver.FindElement(By.CssSelector("#toolset-navbar > nav > ul"));
            loginBtn.Click();
            IWebElement username = driver.FindElement(By.Id("Email"));
            username.SendKeys("demo@sopro.io");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Demo123!");
            IWebElement signInBtn = driver.FindElement(By.CssSelector("body > div.img-background-div > div > form.m-t > div.form-group.m-n > button"));
            signInBtn.Click();
           


        }

        [TearDown]
        public void Close()
        {
           // driver.Quit();
        }
    }
}
