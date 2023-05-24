using Aquality.Selenium.Browsers;
using Aquality.Selenium.Elements;
using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace Userinterface.Test.Form_Objects
{
    internal class Card3 : Form
    {
        public Card3() : base(By.XPath("//div[@class='page-indicator' and contains(text(), '3')]"), "Card_3") { }
    }
}
