using Ribccs.AutomationCore.IntracteWithBrowser.Lib;
using Ribccs.GlobalSqa.Lib.PageObject;
using NUnit.Framework;

namespace Ribccs.GlobalSqa.Tests.UI
{

    [TestFixture]
    public class SamplePageTests : Base
    {

        [Test]
        public void CompleteSamplePage()
        {
            //Arrange
            DragAndDrop dragAndDrop = new DragAndDrop(Driver);
            SamplePage samplePage = new SamplePage(Driver);

            //Act
            dragAndDrop.NavigateTo();

            samplePage.ClickSamplePageTest();
            samplePage.UploadProfilePicture();
            samplePage.SetName();
            samplePage.setEmailAddress();
            samplePage.SetWebsite();
            samplePage.SelectExperience();
            samplePage.SelectExpertise();
            samplePage.SelectEducation();
            samplePage.ClickAlertButton();
            samplePage.ConfirmAlert();
            samplePage.setComment();
            samplePage.submitForm();
        }

    }
}
