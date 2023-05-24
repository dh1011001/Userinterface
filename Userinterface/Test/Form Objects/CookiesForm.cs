using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;

namespace Userinterface.Test.Form_Objects
{
    internal class CookiesForm : Form
    {
        private IButton acceptButton = ElementFactory.GetButton(By.XPath("//button[contains(@class, 'transparent')]"), "Accept_Cookies_Button");

        public CookiesForm() : base(By.ClassName("cookies"), "Cookies_Form") { }

        public void ClickAcceptButton()
        {
            acceptButton.Click();
        }
    }
}
