using Ribccs.AutomationCore.IntracteWithBrowser.Lib;
using Ribccs.GlobalSqa.Lib.PageObject;
using NUnit.Framework;

namespace Ribccs.GlobalSqa.Tests.UI
{

    [TestFixture]
    public class DragAndDropTests : Base
    {

        [Test]
        public void MoveImagesFromPhotoManagerToTrash()
        {
            //Arrange
            DragAndDrop dragAndDrop = new DragAndDrop(Driver);

            //Act
            dragAndDrop.NavigateTo();
            dragAndDrop.ClickAndHoldHighTatras4();
            dragAndDrop.DragHighTatras4();
            dragAndDrop.DropHighTatras4();

            dragAndDrop.ClickAndHoldHighTatras3();
            dragAndDrop.DragHighTatras3();
            dragAndDrop.DropHighTatras3();

        }

    }
}

