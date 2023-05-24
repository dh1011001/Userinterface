using NUnit.Framework;
using Aquality.Selenium;
using Userinterface.Test.Supporting_Classes;
using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using Aquality.Selenium.Browsers;

namespace Userinterface
{
    public class BaseTest
    {
        private ISettingsFile settingsFile = new JsonSettingsFile("Config.json");
        private static Browser browser;

        [SetUp]
        public void Setup()
        {
            browser = AqualityServices.Browser;
            browser.Maximize();
            browser.GoTo(settingsFile.GetValue<string>("remoteConnectionUrl"));
            browser.WaitForPageToLoad();
        }

        [TearDown]
        public void TearDown()
        {
            browser.Quit();
        }
    }
}
