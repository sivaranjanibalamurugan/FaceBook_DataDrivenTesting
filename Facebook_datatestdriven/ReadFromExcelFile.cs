using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven
{
 
    class ReadFromExcelFile:BaseClass
    {
        [Test]
        public void ReadingData()
        {
                ExcelOperations.PopulateInCollection(@"C:\Users\sivaranjani.b\Documents\Facebook_datadriventesting.xlsx");
                Debug.WriteLine("**");
                driver.FindElement(By.Name("email")).SendKeys(ExcelOperations.ReadData(1, "email"));
                System.Threading.Thread.Sleep(2000);

                driver.FindElement(By.Id("pass")).SendKeys(ExcelOperations.ReadData(1, "password"));
                 System.Threading.Thread.Sleep(2000);

                driver.FindElement(By.Name("login")).Click();
                System.Threading.Thread.Sleep(10000);
   
        }
    }
}

       
        
   
    

