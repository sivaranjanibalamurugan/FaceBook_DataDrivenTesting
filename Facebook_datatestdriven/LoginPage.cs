/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //To locate the webelement 
        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginBt;

        /*[FindsBy(How = How.XPath, Using = "(//span[@class='l9j0dhe7'])")]
        [CacheLookup]
        public IWebElement Home;*/

        /* [FindsBy(How = How.XPath, Using = "(//span[@text()='Photo/Video']")]*/
        /*[FindsBy(How = How.XPath, Using = "(//span[@class='a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5'])")]
        [CacheLookup]
        public IWebElement photo;*/
    }
}
