using Ribccs.AutomationCore.DriverFactory.Lib;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Ribccs.AutomationCore.IntracteWithBrowser.Lib
{
    public class Base
    {
        BrowserFactory browser = new BrowserFactory();
        public IWebDriver Driver { get; set; }
        TimeSpan Timeout = TimeSpan.FromSeconds(5);

        public Base()
        {

        }

        public Base(IWebDriver driver)
        {
            if (Driver is null)
                Driver = driver;

        }

        public IWebDriver OpenBrowser(Browsers browserName, bool headlessMode = false)
        {
            return browser.InitializeDriver(browserName, headlessMode);
        }

        public void LaunchApplication(string url)
        {
            Driver.Url = url;
        }

        [SetUp]
        public void SetupTest()
        {
            if (Driver is null)
                Driver = OpenBrowser(Browsers.Chrome);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
        }

        [TearDown]
        public void EndTest()
        {
            CloseBrowser();
        }

        private void CloseBrowser()
        {
            Driver.Quit();
            Driver = null;
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }

        public void ClickAndHold(By by)
        {
            var element = Driver.FindElement(by);
            Actions builder = new Actions(Driver);
            builder.MoveToElement(element).ClickAndHold().Perform();
        }

        public void MoveMouseTo(By by)
        {
            var element = Driver.FindElement(by);
            Actions builder = new Actions(Driver);
            builder.MoveToElement(element).Perform();
        }

        public void ReleaseMouseAt(By by)
        {
            var element = Driver.FindElement(by);
            Actions builder = new Actions(Driver);
            builder.MoveToElement(element).Release().Perform();
            Delay();
        }

        public void SwitchToFrame(By by)
        {
            WebDriverWait wait = new WebDriverWait(Driver, Timeout);
            wait.Until(ExpectedConditions.ElementExists(by));

            var element = Driver.FindElement(by);
            Driver.SwitchTo().Frame(element);
        }

        public void Delay()
        {
            Thread.Sleep(5000);
        }

        public void ScrollToElement(By by)
        {
            var element = Driver.FindElement(by);
            Actions actions = new Actions(Driver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        public void Click(By by)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, Timeout);
                ScrollToElement(by);
                wait.Until(ExpectedConditions.ElementToBeClickable(by));
                Driver.FindElement(by).Click();
            }
            catch (Exception ex) when (ex is ElementClickInterceptedException)
            {
                _ = ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", Driver.FindElement(by));
            }

        }
      
        public void SendKeys(By by, string value)
        {
            var element = Driver.FindElement(by);
            element.Clear();
            element.SendKeys(value);
        }

        public void SelectFromDropDown(By by, string text)
        {
            var select = new SelectElement(Driver.FindElement(by));
            select.SelectByText(text);
        }
    }
}
