using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System.Threading;
using Aquality.Selenium.Core.Elements;
using Userinterface.Test.Supporting_Classes;
using NUnit.Framework;

namespace Userinterface.Test.Form_Objects
{
    internal class Card2 : Form
    {
        private IButton uploadButton = ElementFactory.GetButton(By.ClassName("avatar-and-interests__upload-button"), "Upload_Button");
        private IButton nextButton = ElementFactory.GetButton(By.XPath("//button[@type='button' and text()='Next']"), "Next_Button");
        private ICheckBox unselectAllCheckboxes = ElementFactory.GetCheckBox(RelativeBy.WithLocator(By.XPath("//span[contains(@class, 'checkbox')]"))
            .LeftOf(By.XPath("//span[text()='Unselect all']")), "UnselectAll_Checkbox");
        private ICheckBox selectAllCheckboxes = ElementFactory.GetCheckBox(RelativeBy.WithLocator(By.XPath("//span[contains(@class, 'checkbox')]"))
            .LeftOf(By.XPath("//span[text()='Select all']")), "UnselectAll_Checkbox");

        private By interestsCheckBoxesLocator = By.XPath("//div[@class='avatar-and-interests__interests-list']//span[@class='checkbox__box']");

        public Card2() : base(By.XPath("//div[@class='page-indicator' and contains(text(), '2')]"), "Card_2") { }

        public void uploadImage(string path)
        {
            uploadButton.Click();
        }

        public void UnCheckAllInterests() 
        {
            unselectAllCheckboxes.Check();
        }

        public void CheckInterests(int count)
        {
            var checkBoxes = ElementFactory.FindElements<ICheckBox>(interestsCheckBoxesLocator);
            foreach (int indexCheckBoxToSelect in RandomUtils.GetListDifferentRandomNums(count, checkBoxes.Count)) 
            {
                ICheckBox checkBoxToSelect = checkBoxes[indexCheckBoxToSelect];
                By checkBoxToSelectTextLocator = RelativeBy.WithLocator(By.XPath("//span")).RightOf(checkBoxToSelect.Locator);
                ILabel checkBoxToSelectText = ElementFactory.GetLabel(checkBoxToSelectTextLocator, "CheckBoxToSelectText");
                if (checkBoxToSelectText.Text.Equals("Unselect all") || checkBoxToSelectText.Text.Equals("Select all"))
                {
                    checkBoxes[indexCheckBoxToSelect - 1].Check();
                    continue;
                }
                checkBoxes[indexCheckBoxToSelect].Check();
            }
        }

        public void clickNextButton()
        {
            nextButton.ClickAndWait();
        }
    }
}
