using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;

namespace Userinterface.Test.Form_Objects
{
    internal class HelpForm : Form
    {
        private IButton sendButton = ElementFactory.GetButton(By.XPath("//button[contains(@class, 'help-form__send')]"), "Send_Form_Button");

        public HelpForm() : base(By.XPath("//div[@class='help-form']"), "Help_Form") { }

        public void ClickSendButton()
        {
            sendButton.ClickAndWait();
        }

        public bool WaitHelpFormClose()
        {
            bool isHided() => !sendButton.State.IsDisplayed;
            Func<bool> isHelpHided = isHided;
            return AqualityServices.ConditionalWait.WaitFor(isHelpHided);
        }
    }
}
