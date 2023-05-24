using NUnit.Framework;
using Aquality.Selenium.Browsers;
using Userinterface.Test.Supporting_Classes;
using Userinterface.Test.Form_Objects;
using System.Threading;
using System;
using System.IO;
using Aquality.Selenium.Core.Logging;

namespace Userinterface
{
    public class Tests : BaseTest
    {
        /*[Test]
        public void LoginTest()
        {
            Logger.Instance.Info("Start case 1 step 1");

            WelcomePage welcomePage = new WelcomePage();
            Assert.IsTrue(welcomePage.State.WaitForDisplayed(), "Welcome page was not opened");

            Logger.Instance.Info("Start case 1 step 2");

            welcomePage.ClickNextLink();
            Card1 card1 = new Card1();
            Assert.IsTrue(card1.State.WaitForDisplayed(), "Card_1 page was not opened");
            Logger.Instance.Info("Start case 1 step 3");
            string emailFirstPart = RandomUtils.CreateRandomString();
            string Domain = RandomUtils.CreateRandomString();
            string Password = RandomUtils.CreateCrazyPassword(emailFirstPart);
            card1.SendEmailFirsPart(emailFirstPart);
            card1.SendDomain(Domain);
            card1.SendPassword(Password);
            card1.SelectItemInDomainDropdownList();
            card1.clickAcceptCheckBox();
            card1.clickNextButton();
            Card2 card2 = new Card2();
            Assert.IsTrue(card2.State.WaitForDisplayed(), "Card_2 page was not opened");

            Logger.Instance.Info("Start case 1 step 4");

            var exePath = AppDomain.CurrentDomain.BaseDirectory;
            card2.uploadImage(Path.Combine(exePath, TestData.localPathToAvatarImage));
            card2.UnCheckAllInterests();
            card2.CheckInterests(TestData.interestsCountToCheck);
            card2.clickNextButton();
            Card3 card3 = new Card3();
            Assert.True(card3.State.WaitForDisplayed(), "Card_3 page was not opened");

            
        }*/
        [Test]
        public void HideHelpForm()
        {
            Logger.Instance.Info("Start case 2 step 1");

            WelcomePage welcomePage = new WelcomePage();
            Assert.IsTrue(welcomePage.State.WaitForDisplayed(), "Welcome page was not opened");
            welcomePage.ClickNextLink();
            Card1 card1 = new Card1();

            Logger.Instance.Info("Start case 2 step 2");

            HelpForm helpForm = new HelpForm();
            helpForm.State.WaitForDisplayed();
            helpForm.ClickSendButton();
            Assert.IsTrue(helpForm.WaitHelpFormClose(), "Help_Form was not closed");
        }

        [Test]
        public void AcceptCoocies()
        {

            Logger.Instance.Info("Start case 3 step 1");

            WelcomePage welcomePage = new WelcomePage();
            Assert.IsTrue(welcomePage.State.WaitForDisplayed(), "Welcome page was not opened");
            welcomePage.ClickNextLink();
            Card1 card1 = new Card1();

            Logger.Instance.Info("Start case 3 step 2");

            CookiesForm cookiesForm = new CookiesForm();
            cookiesForm.State.WaitForDisplayed();
            cookiesForm.ClickAcceptButton();
            Assert.IsTrue(!cookiesForm.State.IsDisplayed, "Cookies_Form was not closed");
        }

        [Test]
        public void CheckTimerValue()
        {
            Logger.Instance.Info("Start case 4 step 1");

            WelcomePage welcomePage = new WelcomePage();
            Assert.IsTrue(welcomePage.State.WaitForDisplayed(), "Welcome page was not opened");
            welcomePage.ClickNextLink();
            Card1 card1 = new Card1();
            string actualTimerValue = card1.GetTimerValue();
            StringAssert.StartsWith(TestData.expectedTimerValue, actualTimerValue, "Unexpected first timer values");

        }
    }
}