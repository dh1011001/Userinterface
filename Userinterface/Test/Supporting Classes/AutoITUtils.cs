using AutoItX3Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Userinterface.Test.Supporting_Classes
{
    internal class AutoITUtils
    {
        private static AutoItX3 autoIt = new AutoItX3();
        public static void UploadFile(string path)
        {
            autoIt.WinActivate("Open");
            Thread.Sleep(200);
            autoIt.Send(path);
            autoIt.Send("{Enter}");
        }
    }
}
