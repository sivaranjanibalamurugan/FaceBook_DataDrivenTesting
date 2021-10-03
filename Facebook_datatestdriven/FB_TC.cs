/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Facebook_datatestdriven.Resources
{

    [TestFixture("chrome")]
    [TestFixture("firefox")]
    //  [Parallelizable(ParallelScope.Fixtures)]
    public class Tests:BaseClass

    {
        public Tests(string browser) : base(browser) { }

        ExtentReports reports = ReportClass.report();
        ExtentTest test;
       [Test,Order(0)]
          //Reading the data from the Excel file
           public void ReadingDataFromExcelFile()
           {
               test = reports.CreateTest("Tests");
               test.Log(Status.Info, "Automation FaceBook");
               DoActions.DoActions.LoginToFaceBook(driver);
               System.Threading.Thread.Sleep(1000);
               Takescreenshot();
               test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Screenshot\text1.png").Build());
               test.Log(Status.Pass, "Test Passes");
             reports.Flush();


           }
           [Test,Order(1)]
              public void HomePage()
              {
                  test = reports.CreateTest("Tests");
                  test.Log(Status.Info, "Automation of FaceBook");
                  DoActions.DoActions.navigatehomepg(driver);
                  System.Threading.Thread.Sleep(2000);
                  Takescreenshot();
                  test.Log(Status.Pass, "Test passes");
                  reports.Flush();
                  Takescreenshot();
              }
        [Test,Order(2)]
              public void uploadpic()
              {
                  test = reports.CreateTest("Tests");
                  test.Log(Status.Info, "Automating of FaceBook ");
                  DoActions.DoActions.PostPage(driver);
                  System.Threading.Thread.Sleep(2000);
                  Takescreenshot();

                  test.Log(Status.Pass, "Test passes");
                  reports.Flush();
              }

           [Test, Order(3)]
              public void Sendmail()
              {
                  driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
                  Pages.MailPage.ReadDataFromExcel(driver);
                  Pages.MailPage.email_send(driver);
               }

    }
}

       
        
   
    

