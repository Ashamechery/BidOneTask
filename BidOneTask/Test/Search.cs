using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BidOneTask.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using BidOneTask.Pages;
using System.IO;
using System.Data;
using System.Diagnostics;


namespace BidOneTask.Test
{
    [TestFixture]
    internal class Search :CommonDriver
    {
    
        [Test, Order(2)]
        public void SearchKeyword()
        {
           
            try
            {
                //HomePage page Initialization and definition
                
                HomePage HomePageObj = new HomePage();
                HomePageObj.SearchCheese(webDriver);
                HomePageObj.SearchKeyword(webDriver);
            }
            catch
            {
                Assert.Fail("Didnt search keyword", ex.Message);
            }

        }
        [Test, Order(2)]
        public void AddtoBasket()
        {

            try
            {
                //HomePage page Initialization and definition

                HomePage HomePageObj = new HomePage();
                HomePageObj.SearchKeyword(webDriver);
            }
            catch
            {
                Assert.Fail("Item not added", ex.Message);
            }

        }

    }
}
