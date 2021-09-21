using AutoItX3Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven.DoActions
{
    public class DoactionPostpage:BaseClass
    {
        public static void PostPage(IWebDriver driver)
        {
            //creating instance 
            Pages.Postpage post = new Pages.Postpage(driver);
            
            //entering the mailid
            post.email.SendKeys("8667361462");
            System.Threading.Thread.Sleep(2000);

            //entering the password 
            post.password.SendKeys("siva123");
            System.Threading.Thread.Sleep(2000);

            //Checking if loginbt is working
            post.loginBt.Click();
            System.Threading.Thread.Sleep(2000);

            //Checking if home button is working
            post.Home.Click();
            System.Threading.Thread.Sleep(2000);

            //checking if post button is working 
            post.post.Click();
            System.Threading.Thread.Sleep(2000);

            //enter the text  
            post.text.SendKeys("hello");
            System.Threading.Thread.Sleep(2000);

            //check the upload buton 
            post.uploadPhoto.Click();
            System.Threading.Thread.Sleep(2000);

            //Check the addphoto button
            post.addPhoto.Click();
            System.Threading.Thread.Sleep(2000);
 
            //creating autoIt instance
            AutoItX3 autoIt = new AutoItX3();

            //To browse the image           
            autoIt.WinActivate("Open");
            System.Threading.Thread.Sleep(4000);

            //Selecting the image 
            autoIt.Send(@"C:\Users\sivaranjani.b\Pictures\Screenshots\hello.png");
            System.Threading.Thread.Sleep(4000);

            //To open the file in the Application 
            autoIt.Send("{Enter}");
            Takescreenshot();
            /*    post.uploadbt.Click();
                System.Threading.Thread.Sleep(2000);*/
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
