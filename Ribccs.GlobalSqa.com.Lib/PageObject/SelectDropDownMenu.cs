using Ribccs.AutomationCore.Selenium.Lib;
using OpenQA.Selenium;

namespace Ribccs.GlobalSqa.Lib.PageObject
{
    public class SelectDropDownMenu : Base
    {
        private By countryDropDown = By.TagName("select");

        public SelectDropDownMenu(IWebDriver driver) : base(driver)
        {
        }

       public void SelectCountry(string country)
        {
            SelectFromDropDown(countryDropDown,country);
        }
    }
}
