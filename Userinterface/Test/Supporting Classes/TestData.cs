using Aquality.Selenium.Core.Configurations;
using Aquality.Selenium.Core.Utilities;
using Newtonsoft.Json.Linq;

namespace Userinterface.Test.Supporting_Classes
{
    public class TestData
    {
        public static ISettingsFile testDataArr = new JsonSettingsFile("Test Data//Test_Data.json");

        public static string expectedTimerValue = testDataArr.GetValue<string>("expectedTimerValue");
        public static int interestsCountToCheck = testDataArr.GetValue<int>("interestsCountToCheck");
        public static string localPathToAvatarImage = testDataArr.GetValue<string>("localPathToAvatarImage");
    }
}
