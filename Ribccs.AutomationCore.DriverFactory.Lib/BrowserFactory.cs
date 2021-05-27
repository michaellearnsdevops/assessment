using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;

namespace Ribccs.AutomationCore.DriverFactory.Lib
{
    public class BrowserFactory
    {
        public IWebDriver InitializeDriver(Browsers browserName, bool headlessMode)
        {
            switch (browserName)
            {
                case Browsers.Chrome:

                    var options = new ChromeOptions();
                    options.PageLoadStrategy = PageLoadStrategy.Eager;
                    return new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);
                    
                case Browsers.FireFox:
                    return new FirefoxDriver();

                default:
                    return new ChromeDriver();
            }
        }
    }
}
