using System;
using System.Windows.Forms;

namespace OptimizedClevoFan
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // ***this line is added***
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppWindow());
        }

        // ***also dllimport of that function***
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
