using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ReCPU
{
    public partial class Form1 : Form
    {

        string str = Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void manuname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manuname.SelectedItem == "Intel Core")
            {
                modu1.Items.Clear();
                modu1.Items.Add("Core i3");
                modu1.Items.Add("Core i5");
                modu1.Items.Add("Core i7");
                modu1.Items.Add("Core i9");


            }
        }

        private void modu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpugen.Items.Clear();
            cpugen.Items.Add("Gen 1");
            cpugen.Items.Add("Gen 2");
            cpugen.Items.Add("Gen 3");
            cpugen.Items.Add("Gen 4");
            cpugen.Items.Add("Gen 5");
            cpugen.Items.Add("Gen 6");
            cpugen.Items.Add("Gen 7");
            cpugen.Items.Add("Gen 8");
            cpugen.Items.Add("Gen 9");
            cpugen.Items.Add("Gen 10");
        }

       

        private void cpugen_SelectedIndexChanged(object sender, EventArgs e)
        {
            dein.Items.Clear();
            switch (modu1.SelectedItem)
            {
                case "Core i5":
                    switch (cpugen.SelectedItem)
                    {
                        case "Gen 10":
                            dein.Items.Add("Intel(R) Core(TM) i5-1035G7 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-1035G4 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-1035G1 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-1030G1 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-1030G4 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10210U CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10310Y CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10210Y CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10300H CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10500K CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10600 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10600T CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10400F CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10600K CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10500 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10500T CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10400 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10400T CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10500H CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10600KF CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-1030NG7 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-10400H CPU");
                            dein.Items.Add("Intel(R) Core(TM) i5-1038NG7 CPU");
                            break;
                        default:
                            break;
                    }
                    break;
                default:break;
            }
        }

        private void dein_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (!File.Exists("ORGCPU.reg"))
            {
                global::ReCPU.RegExportImport.ExportReg(str + @"\ORGCPU.reg", @"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0");
            }

            File.WriteAllText("GENERATED.reg", @"Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0]
""ProcessorNameString""=""" + dein.SelectedItem + @"""");
            global::ReCPU.RegExportImport.ImportReg(str + @"\GENERATED.reg", null);
        }

        private void restore_Click(object sender, EventArgs e)
        {
            global::ReCPU.RegExportImport.ImportReg(str + @"\ORGCPU.reg", null);
        }
    }

   
}
