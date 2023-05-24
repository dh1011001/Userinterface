using Aquality.Selenium.Browsers;
using Aquality.Selenium.Core.Elements;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using Userinterface.Test.Supporting_Classes;

namespace Userinterface.Test.Form_Objects
{
    internal class Card1 : Form
    {
        private ITextBox firstEmailPartTextBox = ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Your email']"), "First_Email_Part_TextBox");
        private ITextBox DomainTextBox = ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Domain']"), "Domain_TextBox");
        private ITextBox PasswordTextBox = ElementFactory.GetTextBox(By.XPath("//input[@placeholder='Choose Password']"), "Password_TextBox");
        private ILabel domainEndListHeadr = ElementFactory.GetLabel(By.XPath("//div[@class='dropdown__header']"), "DomainEnd_List_header");
        private ICheckBox acceptCheckBox = ElementFactory.GetCheckBox(By.XPath("//span[@class='checkbox__box']"), "Accept_CheckBox");
        private IButton nextButton = ElementFactory.GetButton(By.XPath("//a[@class='button--secondary' and text()='Next']"), "Next_Button");
        private ILabel timer = ElementFactory.GetLabel(By.XPath("//div[contains(@class, 'timer')]"), "Timer_Element");

        public Card1() : base(By.XPath("//div[@class='page-indicator' and contains(text(), '1')]"), "Card_1") { }

        public void SendEmailFirsPart(string toSend)
        { 
            firstEmailPartTextBox.ClearAndType(toSend);
        }

        public void SendDomain(string toSend)
        {
            DomainTextBox.ClearAndType(toSend);
        }

        public void SendPassword(string toSend)
        {
            PasswordTextBox.ClearAndType(toSend);
        }

        public void SelectItemInDomainDropdownList()
        {
            domainEndListHeadr.Click();
            var availableDomainNames = ElementFactory.FindElements<ILabel>(By.XPath("//div[@class='dropdown__list-item']"));
            availableDomainNames[RandomUtils.GetRandomNum(availableDomainNames.Count)].Click();
        }

        public void clickAcceptCheckBox()
        {
            acceptCheckBox.Click();
        }

        public void clickNextButton()
        {
            nextButton.ClickAndWait();
        }

        public string GetTimerValue()
        {
            return timer.Text;
        }
    }
}
