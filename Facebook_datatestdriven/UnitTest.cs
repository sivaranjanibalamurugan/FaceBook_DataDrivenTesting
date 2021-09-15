/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
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
 
    class Tests:BaseClass
    {
       [Test]
       //Reading the data from the Excel file
        public void ReadingDataFromExcelFile()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Resources\Facebook_datadriventesting.xlsx");
            
        }
        [Test]

        public void load_complete()
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(20));

            // Wait for the page to load
             wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            Console.WriteLine("Login Successful");

        }

    }
}

       
        
   
    

