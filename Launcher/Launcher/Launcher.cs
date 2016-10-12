using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Launcher
{
    class LauncherBackEnd
    {
        public static void PlayGame()
        {
            Process.Start("test.txt");
        }

        public static void LaunchWebsite(string url)
        {
            Process.Start(url);
        }
    }
}
