using Ribccs.AutomationCore.IntracteWithBrowser.Lib;
using OpenQA.Selenium;
using System.IO;
using System.Reflection;

namespace Ribccs.GlobalSqa.Lib.PageObject
{
    public class SamplePage : Base
    {

        private string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\profilePicture.png";
       
        private By samplePageLink = By.Id("menu-item-2818");
        private By chooseFile = By.CssSelector("input.wpcf7-form-control.wpcf7-file");
        private By name = By.CssSelector("input#g2599-name.name");
        private By email = By.CssSelector("input#g2599-email.email"); 
        private By website = By.CssSelector("input#g2599-website.url");
        private By experienceInYears = By.Name("g2599-experienceinyears");
        private By expertiseFunctional = By.XPath("//*[text() = ' Functional Testing']");
        private By expertiseAutomation = By.XPath("//*[text() = ' Automation Testing']");
        private By expertiseManual = By.XPath("//*[text() = ' Manual Testing']");
        private By education = By.XPath("//*[text() = ' Post Graduate']");
        private By alertButton = By.XPath("//*[text() = 'Alert Box : Click Here']");
        private By contactFormComment = By.Name("g2599-comment");
        private By submit = By.ClassName("contact-submit");

        public void ClickSamplePageTest()
        {
            Driver.SwitchTo().DefaultContent();
            Click(samplePageLink);
        }

  public void UploadProfilePicture()
        {
            SendKeys(chooseFile, filePath);
        }
        
        public void SetName()
        {
            Click(name);
            SendKeys(name, "Michael");
        }

        public void setEmailAddress()
        {
            SendKeys(email, Keys.Tab);
            SendKeys(email, "michael@test.com");
        }
        
        public void SetWebsite()
        {
            SendKeys(website, "http://www.test.com");
        }

        public void SelectExperience()
        {
            SelectFromDropDown(experienceInYears, "7-10");
        }
        
      public void SelectExpertise()
        {
            Click(expertiseManual);
            Click(expertiseAutomation);
            Click(expertiseFunctional);
        }
    
     public void SelectEducation()
        {
            Click(education);
        }
    
        public void ClickAlertButton()
        {
            Click(alertButton);
        }

        public void ConfirmAlert()
        {
            Driver.SwitchTo().Alert().Accept();
            Driver.SwitchTo().Alert().Accept();
        }

        public void setComment()
        {
            SendKeys(contactFormComment, "Thank you");
        }

        public void submitForm()
        {
            Click(submit);
        }

        public SamplePage(IWebDriver driver) : base(driver)
        {

        }

    }
}
