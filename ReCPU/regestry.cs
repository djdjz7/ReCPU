using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace ReCPU
{
    public partial class regestry : Control
    {
        public regestry()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }

    //保存为*.cs文件，让然后在对象浏览器中查看
    ///


    /// 该类是对注册表导入导出的操作
    ///
    public static class RegExportImport
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        static extern int MessageBox(IntPtr hwnd, string text, string caption, uint type);

        ///

        /// 从注册表导出到文件，在导出的过程是异步的，不受操作进程管理
        ///
        /// 从注册表导出的文件，如果是已存在的，会提示覆盖；
        /// 如果不存在由参数指定名字的文件，将自动创建一个。导出的文件的扩展名应当是.REG的
        /// 指定注册表的某一键被导出，如果指定null值，将导出整个注册表
        /// 成功返回0，用户中断返回1
        public static int ExportReg(string SavingFilePath, string regPath)
        {
            //如果文件存在，MSG提示是否覆盖，不覆盖，中断操作
            //如果注册表路径为空，导出全部



            if (File.Exists(SavingFilePath))
                if (MessageBox(IntPtr.Zero,
                    string.Format("存在名为：{0}的文件，是否覆盖 ？",
                    SavingFilePath),
                    string.Format("进程：{0} pid: {1}",
                    Process.GetCurrentProcess().ProcessName,
                    Process.GetCurrentProcess().Id),
                     0x00000004
                  | 0x00200000 | 0x00000020 | 0x00000100) == 7)
                {
                    return 1; //说明，在应用的地方，用对话框，再操作,再调用一次

                }

            Process.Start(
                    "regedit",
                    string.Format(" /E {0} {1} ", SavingFilePath, regPath));
            //   Console.WriteLine(10);//异步的，非同步执行
            // Feng.Regedit.RegExportImport.ExportReg(@"c:/789.reg",@"HKEY_LOCAL_MACHINE/Software/Microsoft/Windows/CurrentVersion/Run");
            //    Feng.Regedit.  RegExportImport.ExportReg(@"c:/789.reg",null);
            return 0;
        }
        ///


        /// 从文件导入的注册表
        ///
        /// 指定在磁盘上存在的文件，如果指定的文件不存在，将抛出异常
        /// 指定注册表的键（包含在SavedFilePath文件中保存的关键字），如果该参数设置为null将导入整个SavedFilePath文件
        /// 中保存的所有关于注册表的关键字
        /// 成功返回0
        public static int ImportReg(string SavedFilePath, string regPath)
        {
            if (!File.Exists(SavedFilePath))
                throw new ArgumentException("参数 SavedFilePath 指定无效路径");
            Process.Start(
                   "regedit",
                   string.Format(" /C {0} {1}",
                   SavedFilePath,
                   regPath));//线程外的
            return 0;

        }

    };
}
