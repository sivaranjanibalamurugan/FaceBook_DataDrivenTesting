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

namespace Facebook_datatestdriven
{
 
    class Tests:BaseClass
    {
       [Test]
       //Reading the data from the Excel file
        public void ReadingDataFromExcelFile()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Facebook_datadriventesting.xlsx");
            Console.WriteLine("Login is Successful");
        }
       
    }
}

       
        
   
    

