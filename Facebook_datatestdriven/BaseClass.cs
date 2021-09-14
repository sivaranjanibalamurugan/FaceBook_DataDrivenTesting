/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using Microsoft.Extensions.Options;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven
{
    class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("headless");

            //local selenium webdriver
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(200);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
    

