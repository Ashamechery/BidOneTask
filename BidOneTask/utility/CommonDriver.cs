using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System;

namespace BidOneTask.Utility
{
    public class CommonDriver
    {
        public IWebDriver webDriver;
        [OneTimeSetUp]
        public void LoginFunction()
        {
            webDriver = new ChromeDriver();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(webDriver);
        }
        public void CloseTestRun()
        {
            webDriver.Close();
        }

    }
}
