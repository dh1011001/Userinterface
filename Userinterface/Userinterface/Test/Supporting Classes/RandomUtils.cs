using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userinterface.Test.Supporting_Classes
{
    internal class RandomUtils
    {
        private static Random rnd = new Random();
        public static string CreateCrazyPassword(string emailString, int minPasswordLength = 10)
        {
            const string littleChars = "abcdefghijklmnopqrstuvwxyz";
            const string bigChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string rusChars = "йцукенгшщзхъэждлорпавыфячсмитьбюЙЦУКЕНГШЩЗХЪЭЖДЛОРВЫФЯЧСМИТЬБЮ";
            const string nums = "0123456789";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < minPasswordLength; i++)
            {
                int index = rnd.Next(littleChars.Length);
                sb.Append(littleChars[index]);
            }

            sb.Append(bigChars[rnd.Next(bigChars.Length)]);
            sb.Append(rusChars[rnd.Next(rusChars.Length)]);
            sb.Append(nums[rnd.Next(nums.Length)]);
            sb.Append(emailString[rnd.Next(emailString.Length)]);
            return sb.ToString();
        }
        public static string CreateRandomString(int stringLength = 10)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < stringLength; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public static List<int> GetListDifferentRandomNums(int listCount, int range)
        {
            List<int> numsToSend = new List<int>();
            int currentNum;
            for (int i = 0; i < listCount; i++)
            {
                currentNum = rnd.Next(range);
                if (!numsToSend.Contains(currentNum))
                {
                    numsToSend.Add(currentNum);
                    continue;
                }
                else { i--; }
            }
            return numsToSend;
        }

        public static int GetRandomNum(int range)
        {
            return rnd.Next(range);
        }
    }
}
