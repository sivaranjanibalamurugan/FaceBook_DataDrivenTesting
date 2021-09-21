using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook_datatestdriven.Pages
{
    public class Postpage:BaseClass
    {
        public Postpage(IWebDriver driver)
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
        
       [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
       [CacheLookup]
       public IWebElement Home;

       [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div[3]/div/div[2]/div/div/div/div[1]/div")]
       [CacheLookup]
       public IWebElement post;

       [FindsBy(How = How.XPath, Using = "//*[@class='_1mf _1mj']")]
       [CacheLookup]
       public IWebElement text;

       [FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'] [1]")]
       [CacheLookup]
       public IWebElement uploadPhoto;

       [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn rt8b4zig n8ej3o3l agehan2d sk4xxmp2 rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
       [CacheLookup]
       public IWebElement addPhoto;

      /* [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Post')]")]
       [CacheLookup]
       public IWebElement uploadbt;*/

    }
}
