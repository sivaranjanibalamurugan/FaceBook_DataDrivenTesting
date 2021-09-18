/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;

namespace Facebook_datatestdriven
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
            LoginPage login = new LoginPage(driver);
            Debug.WriteLine("**");
            //Storing the data in the excel and run in it various dataset
            ExcelOperations.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Resources\Facebook_datadriventesting.xlsx");
            login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);

            login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            login.loginBt.Click();
            System.Threading.Thread.Sleep(2000);
           /* login.Home.Click();
            System.Threading.Thread.Sleep(2000);*/
          /*  login.photo.Click();
            System.Threading.Thread.Sleep(2000);*/
        }
    }
}
