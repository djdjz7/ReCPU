using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCPU
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
            MessageBox.Show(@"Alpha Release
Supported model:

Intel Core:
i3 Gen 10 Desktop
i5 Gen 10 Desktop & Mobile
i7 Gen 10 Desktop
i9 Gen 10 Desktop & Mobile

Not supported:

Intel Core:
All i3, i5, i7 Gen 1-9;
All i9 Gen 7-9

AMD:
All", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Run(new Form1());
        }
    }
}
