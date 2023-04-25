using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using BidOneTask.Utility;

namespace BidOneTask.Pages
{
    public class HomePage
    {
        
        public void SearchCheese(IWebDriver webDriver)
        {
            IWebElement searchBox = webDriver.FindElement(By.Id("search-box"));
            searchBox.SendKeys("CHEESE");
            Thread.Sleep(3000);
            //option 2
            if (searchBox.Text == "CHEESE")

            {
                Console.WriteLine("Search result is successful");
            }
            else
            {
                Console.WriteLine("Search result is not successful");
            }
        }
        public void SearchKeyword(IWebDriver webDriver)
        {
            IWebElement searchBox = webDriver.FindElement(By.Id("search-box"));
            searchBox.SendKeys("160640");
            searchBox.Click();
            Thread.Sleep(3000);
            IWebElement searchKeyword = webDriver.FindElement(By.ClassName("icon basket"));
            searchKeyword.Click();
            Thread.Sleep(3000);
            IWebElement BasketIcon = webDriver.FindElement(By.XPath("//*[@id='checkoutState']/div/svg/use"));
            BasketIcon.Click();
            IWebElement ItemCheck = webDriver.FindElement(By.XPath("//*[@id='trolley']/div[4]/div[1]/div/span[2]/span[2]/span[2]"));

            if (ItemCheck.Text == "160648") 

            {
                Console.WriteLine("Item verified");
            }
            else
            {
                Console.WriteLine("Item Not verified");
            }


        }
    }
}
