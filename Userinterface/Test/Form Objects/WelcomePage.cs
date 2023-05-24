using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.Test.Form_Objects
{
    internal class WelcomePage : Form
    {
        private ILink nextLink = ElementFactory.GetLink(By.XPath("//a[@class='start__link']"), "Next_Link");

        public WelcomePage() : base(By.XPath("//button[@class='start__button']"), "Welcome_Page") {}

        public void ClickNextLink()
        {
            nextLink.ClickAndWait();
        }
    }
}
