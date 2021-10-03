/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using Facebook_datatestdriven.Resources;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using AutoItX3Lib;
using OpenQA.Selenium.Firefox;

namespace Facebook_datatestdriven
{
    public class BaseClass
    {
        public static IWebDriver driver;
        //Get Logger for  'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
        protected string browser;
        //default constructor
        public BaseClass()
        {

        }
        //parameterized constructor
        public BaseClass(string browser)
        {
            this.browser = browser;
        }

        [SetUp]
        public void SetUp()
        {
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            try
            {
                switch (browser)
                {

                    case "chrome":
                        //Creating an instance of chrome webdriver
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments("--disable-notifications");

                        driver = new ChromeDriver(options);
                        break;
                    case "firefox":
                        //Creating an instance of firefox webdriver
                        driver = new FirefoxDriver();
                        break;
                    default:
                        driver = new ChromeDriver();
                        break;
                }

                //print which browser is started
                Console.WriteLine(browser + " Started");
                log.Debug("navigating to url");
                log.Info("Entering Setup");

                //ChromeOptions options = new ChromeOptions();

                // options.AddArguments("--disable-notifications"); // to disable notification

                //local selenium webdriver
                // driver = new ChromeDriver(options);

                //To maximize the screen 
                driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(200);
                driver.Url = "https://www.facebook.com/";


                log.Debug("navigating to url");

                log.Info("Exiting setup");

            }
            catch
            {
                Console.WriteLine("Successfull");
            }
        }
            [TearDown]
            public void TearDown()
            {
                driver.Quit();
             
            }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Screenshot\text8.png");
        }
    }
}


    

