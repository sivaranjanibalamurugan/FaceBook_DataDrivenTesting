/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Diagnostics;

namespace Facebook_datatestdriven.DoActions
{
    public  class DoActions:BaseClass
   {
        public static void AssertAfterLaunching(IWebDriver driver)
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void LoginToFaceBook(IWebDriver driver)
        {
            Pages.LoginPage login = new Pages.LoginPage(driver);
            Debug.WriteLine("**");

            //Storing the data in the excel and run in it various dataset
            ExcelOperations.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Resources\Facebook_datadriventesting.xlsx");
           
            //enters the mail id from resource
            login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(4000);

            //enters the password from resource
            login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(4000);
            

            //Autoclick on the login button
            login.loginBt.Click();
            System.Threading.Thread.Sleep(4000);

           Assert.AreEqual(driver.Url, "https://www.facebook.com/?sk=welcome");
            try
            {
                Console.WriteLine("Successfull");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
        }
       
    }
}
