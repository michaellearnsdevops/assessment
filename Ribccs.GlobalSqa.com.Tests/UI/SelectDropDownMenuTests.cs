using Ribccs.AutomationCore.Selenium.Lib;
using Ribccs.GlobalSqa.Lib.PageObject;
using NUnit.Framework;

namespace Ribccs.GlobalSqa.Tests.UI
{
    [TestFixture]

    public class SelectDropDownMenuTests : Base
    {

        [TestCase("India")]
        public void NavigateFromDragAndDropToSelectACountry(string country)
        {
            // Arrange
            DragAndDrop dragAndDrop = new DragAndDrop(Driver);
            SelectDropDownMenu dropDown = new SelectDropDownMenu(Driver);

            //Act
            dragAndDrop.NavigateTo();
            dragAndDrop.ClickDropDownMenu();
            dropDown.SelectCountry(country);

        }
    }
}
