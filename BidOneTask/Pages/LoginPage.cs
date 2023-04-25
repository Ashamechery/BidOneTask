using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;
using BidOneTask.Utility;

namespace BidOneTask.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver webDriver)
        {


            // open chrome browser
            webDriver.Manage().Window.Maximize();
            //launch turnup  portal
            webDriver.Navigate().GoToUrl("https://au-shopv5.uat.bdirectcloud.net/");

            //click on signin
            IWebElement usernameTextbox = webDriver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("BID91162");
            try
            {
                
                //identify password and enter valid password
                IWebElement passwordTextbox = webDriver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("AshaTest3");
                //login button
                IWebElement loginButton = webDriver.FindElement(By.Id("submitBtn"));
                loginButton.Click();
                //check if user is logged in successfully
                Wait.WaitToBeClickable(webDriver, "XPath", "//*[@id='toggleUser']/div/div/div/span[1]/span", 2);
              
                //check if user is logged in successfully
                IWebElement helloHari = webDriver.FindElement(By.XPath("//*[@id='toggleUser']/div/div/div/span[1]/span"));
                Thread.Sleep(2000);
                if (helloHari.Text == "ASHA RAPHAEL")
                {
                    Console.WriteLine("loggedin passed");
                }
                else
                {
                    Console.WriteLine("loggedin not passed");
                }
            }
            catch (Exception ex)

            {
                Assert.Fail("Turnup portal login page didnt launch", ex.Message);
                throw;
            }


        }
    }
}
