using Fastie.Screens.Analytics;
using Fastie.Screens.Login;
using Fastie.Screens.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastie
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HomeForm());
            Application.Run(new LoginForm());
            //Application.Run(new XuatFile("Word", "TK0000000004"));
        }
    }
}
