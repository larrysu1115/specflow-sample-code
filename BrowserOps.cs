using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SpecFlowDemo
{
    public class BrowserOps
    {
        protected IWebDriver driver;

        public void Init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public void Goto(string url)
        {
            driver.Url = url;
        }

        public void Close()
        {
            driver.Quit();
        }

        public IWebElement FindElementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public IWebDriver WebDriver => driver;
    }
}