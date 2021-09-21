using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven.DoActions
{
   public class DoActionHm:BaseClass
    {
        public static void navigatehomepg(IWebDriver driver)
        {
            //creating instance 
            Pages.HomePage home = new Pages.HomePage(driver);

            //Entering the credentials for mail
            home.mail.SendKeys("8667361462");
            System.Threading.Thread.Sleep(2000);

            //Entering credentials for password
            home.pass.SendKeys("siva123");
            System.Threading.Thread.Sleep(2000);

            //checking the login button
            home.loginBt.Click();
            System.Threading.Thread.Sleep(2000);
  
            //checking the home button
            home.Home.Click();
            System.Threading.Thread.Sleep(2000);

            //Checking the post button 
            home.post.Click();
            System.Threading.Thread.Sleep(2000);

            //validation
            Assert.AreEqual(driver.Url, "https://www.facebook.com/");
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
