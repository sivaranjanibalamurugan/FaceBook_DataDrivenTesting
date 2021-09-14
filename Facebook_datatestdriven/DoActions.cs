/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven
{
   public  class DoActions
   {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
      
        public void LoginToFaceBook(IWebDriver driver)
        {
            Debug.WriteLine("**");
            //Storing the data in the excel and run in it various dataset
            driver.FindElement(By.Name("email")).SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Id("pass")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
