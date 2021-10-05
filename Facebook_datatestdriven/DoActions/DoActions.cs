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
                Console.WriteLine("Successfull logg in");
            }
            catch
            {
                Console.WriteLine("Failed");
            }
        }
        public static void navigatehomepg(IWebDriver driver)
        {

            DoActions.LoginToFaceBook(driver);
            //creating instance 
            Pages.HomePage home = new Pages.HomePage(driver);

            //checking the home button
            home.Home.Click();
            System.Threading.Thread.Sleep(8000);

            //Checking the post button 
            home.post.Click();
            System.Threading.Thread.Sleep(8000);

            //validation
            string expected = "Find Friends";
            string actual = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[1]/div/div/div[1]/div/div/div[1]/div[1]/ul/li[1]/div/a/div[1]/div[2]/div")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
            
            try
            {
                Console.WriteLine("Successfull");
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElement, "No such element found"); 
            }
        }
        public static void PostPage(IWebDriver driver)
        {
            DoActions.navigatehomepg(driver);
            //creating instance 
            Pages.Postpage post = new Pages.Postpage(driver);

            //enter the text  
            post.text.SendKeys("hello");
            System.Threading.Thread.Sleep(8000);

            //check the upload buton 
            post.uploadPhoto.Click();
            System.Threading.Thread.Sleep(8000);

            //Check the addphoto button
            post.addPhoto.Click();
            System.Threading.Thread.Sleep(8000);

            //creating autoIt instance
            AutoItX3 autoIt = new AutoItX3();

            //To browse the image           
            autoIt.WinActivate("Open");
            System.Threading.Thread.Sleep(8000);

            //Selecting the image 
            autoIt.Send(@"C:\Users\sivaranjani.b\Pictures\Screenshots\hello.png");
            System.Threading.Thread.Sleep(8000);

            //To open the file in the Application 
            autoIt.Send("{Enter}");
            Takescreenshot();

            /*    post.uploadbt.Click();
                System.Threading.Thread.Sleep(2000);*/


            string expected = "Create post";
            string actual = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div/div/div[1]/div[1]/div/div[1]/h2/span/span")).Text;
            Console.WriteLine(" Meassage: {0}", actual);
            Assert.AreEqual(expected, actual);
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
