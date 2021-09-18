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
 
    public class Tests:BaseClass

    {
        ExtentReports reports = ReportClass.report();
        ExtentTest test;
        [Test]
       //Reading the data from the Excel file
        public void ReadingDataFromExcelFile()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");

            DoActions.LoginToFaceBook(driver);
            System.Threading.Thread.Sleep(10000);
            Takescreenshot();
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            Takescreenshot();

        }/*
        [Test]

        public void load_complete()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(20));

            // Wait for the page to load
            if (wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete")))
                
            {
                Console.WriteLine("Login Successful");
                Takescreenshot();

            }
            else
            {
                Console.WriteLine("Login Failed");
            }
            Takescreenshot();
        }*/
    }
}

       
        
   
    

