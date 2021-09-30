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

namespace Facebook_datatestdriven
{
    public class BaseClass
    {
        public static IWebDriver driver;
        //Get Logger for  'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        [SetUp]
        public void SetUp()
        {
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");

            ChromeOptions options = new ChromeOptions();
               
                options.AddArguments("--disable-notifications"); // to disable notification

                //local selenium webdriver
                driver = new ChromeDriver(options);

                //To maximize the screen 
                driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(200);
                driver.Url = "https://www.facebook.com/";
           // driver.Url = "https://accounts.google.com/";

            log.Debug("navigating to url");

            log.Info("Exiting setup");

        }
            [TearDown]
            public void TearDown()
            {
                driver.Quit();
              //  String path = @"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Screenshot\";
              //BaseReport.OnScreenCaptureAddedfromPath(path);
            }
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Screenshot\text8.png");
        }
    }
}


    

