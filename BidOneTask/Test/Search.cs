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
    internal class Search : CommonDriver
    {

        [Test, Order(1)]
        public void SearchKeyword()
        {
            {
                //HomePage page Initialization and definition

                HomePage HomePageObj = new HomePage();
                HomePageObj.SearchCheese(webDriver);



            }
        }
            [Test, Order(2)]
            public void AddtoBasket()
            {



                //HomePage page Initialization and definition

                HomePage HomePageObj = new HomePage();
                HomePageObj.SearchKeyword(webDriver);


            }

        }
    }
