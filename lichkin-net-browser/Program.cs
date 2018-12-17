using System;
using System.Windows.Forms;

namespace lichkin_net_browser
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("不能同时运行多个程序", "提示信息");
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}
