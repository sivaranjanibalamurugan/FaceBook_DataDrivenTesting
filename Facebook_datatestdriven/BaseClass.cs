/*
 * project = data driven testing 
 * created by = SIVA RANJANI B
 * created on = 12/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Facebook_datatestdriven
{
    class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("headless");

            //local selenium webdriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            System.Threading.Thread.Sleep(200);
            Takescreenshot();
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
            screenshot.SaveAsFile(@"C:\Users\sivaranjani.b\source\repos\Facebook_datatestdriven\Facebook_datatestdriven\Screenshot\text1.png");
        }
    }
}
    

