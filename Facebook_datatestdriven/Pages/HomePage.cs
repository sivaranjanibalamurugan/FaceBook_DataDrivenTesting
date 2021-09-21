﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven.Pages
{
   public class HomePage:BaseClass
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //To locate the webelement 
        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement mail;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement pass;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginBt;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        [CacheLookup]
        public IWebElement Home;

        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        //[CacheLookup]
        //public IWebElement Home;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]/div")]
        [CacheLookup]
        public IWebElement post;

        
    }
}