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
        [Test,Order(0)]
       //Reading the data from the Excel file
        public void ReadingDataFromExcelFile()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");

            DoActions.DoActions.LoginToFaceBook(driver);
            System.Threading.Thread.Sleep(10000);
            Takescreenshot();
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            Takescreenshot();

        }
        [Test,Order(1)]
        public void HomePage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation of FaceBook");
            DoActions.DoActionHm.navigatehomepg(driver);
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
            DoActions.DoactionPostpage.PostPage(driver);
            System.Threading.Thread.Sleep(2000);
            Takescreenshot();
            test.Log(Status.Pass, "Test passes");
            reports.Flush();

        }
    }
}

       
        
   
    

