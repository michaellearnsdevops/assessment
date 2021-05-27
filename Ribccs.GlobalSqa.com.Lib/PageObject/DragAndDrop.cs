using Ribccs.AutomationCore.Selenium.Lib;
using OpenQA.Selenium;

namespace Ribccs.GlobalSqa.Lib.PageObject
{
    public class DragAndDrop : Base
    {

        public By HighTatras4 = By.XPath("//*[text() = 'High Tatras 4']");
        public By HighTatras3 = By.XPath("//img[contains(@src,'high_tatras3_min.jpg')]");
        public By trash = By.CssSelector("div#trash.ui-widget-content.ui-state-default.ui-droppable");
        public By dropDownMenu = By.Id("menu-item-2803");
        public By iframe = By.CssSelector("iframe.demo-frame.lazyloaded");

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/draganddrop/");
            setWindowSize();
            SelectFrame();
        }
        
        public void setWindowSize()
        {
            Driver.Manage().Window.Size = new System.Drawing.Size(1366, 728);
        }

        public void SelectFrame()
        {
            SwitchToFrame(iframe);
        }
              
        public void ClickAndHoldHighTatras4()
        {
            ClickAndHold(HighTatras4);
        }

        public void ClickAndHoldHighTatras3()
        {
            ClickAndHold(HighTatras3);
        }

        public void DragHighTatras4()
        {
            MoveMouseTo(trash);
        }

        public void DragHighTatras3()
        {
            MoveMouseTo(trash);
        }


        public void DropHighTatras4()
        {
           ReleaseMouseAt(trash);
        }

        public void DropHighTatras3()
        {
           ReleaseMouseAt(trash);
        }

        public void ClickDropDownMenu()
        {
            Driver.SwitchTo().DefaultContent();
            Click(dropDownMenu);
        }

        public DragAndDrop(IWebDriver driver) : base(driver)
        {

        }

    }
}
