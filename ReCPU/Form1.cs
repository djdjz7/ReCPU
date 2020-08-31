using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace ReCPU
{




    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        [StructLayout(LayoutKind.Sequential)]
        internal struct WindowCompositionAttributeData
        {
            public WindowCompositionAttribute Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        internal enum WindowCompositionAttribute
        {
            WCA_ACCENT_POLICY = 19
        }

        internal enum AccentState
        {
            ACCENT_DISABLED = 0,
            ACCENT_ENABLE_GRADIENT = 1,
            ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
            ACCENT_ENABLE_BLURBEHIND = 3,
            ACCENT_INVALID_STATE = 4
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct AccentPolicy
        {
            public AccentState AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        internal void EnableBlur()
        {
            var accent = new AccentPolicy();
            var accentStructSize = Marshal.SizeOf(accent);
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(this.Handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }


        string str = Environment.CurrentDirectory;
        string enableblur;
        string usecustomcpu;
        private static string ApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public Form1()
        {
            if (!Directory.Exists(ApplicationData + @"\ReCPU"))
                Directory.CreateDirectory(ApplicationData + @"\ReCPU");
            if (!File.Exists(ApplicationData + @"\ReCPU\Settings.ini"))
                File.Create(ApplicationData + @"\ReCPU\Settings.ini");
            InitializeComponent();
            //if (File.Exists(ApplicationData + @"\ReCPU\clear"))
            enableblur = IniFunc.getString("Section 1", "ClearMode", "false", ApplicationData + @"\ReCPU\Settings.ini");
            usecustomcpu = IniFunc.getString("Section 1", "UseCustomCPU", "false", ApplicationData + @"\ReCPU\Settings.ini");
            if(enableblur=="true")
            {
                EnableBlur();
                isclear.Checked = true;
            }
            if(usecustomcpu=="true")
            {
                inputsellab.Text = "Input or select CPU model:";
                dein.DropDownStyle = ComboBoxStyle.DropDown;
                useCustomCPUModelToolStripMenuItem.Checked = true;
                manuname.Enabled = false;
                modu1.Enabled = false;
                cpugen.Enabled = false;
            }
            if (!File.Exists(ApplicationData + @"\ReCPU\ORGCPU.reg"))
            {
                barLabel.Text = "Backing up original CPU information...";
                barProgress.Value = 20;
                global::ReCPU.RegExportImport.ExportReg(ApplicationData + @"\ReCPU\ORGCPU.reg", @"HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0");
            }
        }

        private void manuname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)manuname.SelectedItem == "Intel Core")
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
            dein.Enabled = true;
            apply.Enabled = true;
            switch (modu1.SelectedItem)
            {
                case "Core i3":
                    switch (cpugen.SelectedItem)
                    {
                        case "Gen 10":
                            dein.Items.Clear();
                            dein.Items.Add("Intel(R) Core(TM) i3-10320 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i3-10300 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i3-10100 CPU");
                            break;
                        default:
                            dein.Items.Clear();
                            if(usecustomcpu=="false")
                            {
                                dein.Items.Add("Not Supported");
                                dein.Text = "Not Supported";
                                dein.Enabled = false;
                                apply.Enabled = false;
                            }
                            break;
                    }
                    break;
                case "Core i5":
                    switch (cpugen.SelectedItem)
                    {
                        case "Gen 10":
                            dein.Items.Clear();
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
                            dein.Items.Clear();
                            if (usecustomcpu == "false")
                            {
                                dein.Items.Add("Not Supported");
                                dein.Text = "Not Supported";
                                dein.Enabled = false;
                                apply.Enabled = false;
                            }
                            break;
                    }
                    break;
                case "Core i7":
                    switch (cpugen.SelectedItem)
                    {
                        case "Gen 10":
                            dein.Items.Clear();
                            dein.Items.Add("Intel(R) Core(TM) i7-10700K CPU");
                            dein.Items.Add("Intel(R) Core(TM) i7-10700KF CPU");
                            dein.Items.Add("Intel(R) Core(TM) i7-10700 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i7-10700F CPU");
                            break;
                        default:
                            dein.Items.Clear();
                            if (usecustomcpu == "false")
                            {
                                dein.Items.Add("Not Supported");
                                dein.Text = "Not Supported";
                                dein.Enabled = false;
                                apply.Enabled = false;
                            }
                            break;
                    }
                    break;
                case "Core i9":
                    switch (cpugen.SelectedItem)
                    {
                        case "Gen 10":
                            dein.Items.Clear();
                            dein.Items.Add("Intel(R) Core(TM) i9-10900K CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10900F CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10940XE CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10900 CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10980HK CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10900KF CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10900XE CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10885H CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10990XE CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10900T CPU");
                            dein.Items.Add("Intel(R) Core(TM) i9-10920XE CPU");
                            break;
                        default:
                            dein.Items.Clear();
                            if (usecustomcpu == "false")
                            {
                                dein.Items.Add("Not Supported");
                                dein.Text = "Not Supported";
                                dein.Enabled = false;
                                apply.Enabled = false;
                            }
                            break;
                    }
                    break;
                default:
                    dein.Items.Clear();
                    if (usecustomcpu == "false")
                    {
                        dein.Items.Add("Not Supported");
                        dein.Text = "Not Supported";
                        dein.Enabled = false;
                        apply.Enabled = false;
                    }
                    break;
            }
        }

        private void dein_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apply_Click(object sender, EventArgs e)
        {

            
            barLabel.Text = "Generating configuration...";
            barProgress.Value = 50;
            if (dein.Text == "")
            {
                MessageBox.Show("No CPU model selected.\nPlease choose the fake CPU model you want.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barLabel.Text = "Progress Aborted: No CPU model selected.";
                barProgress.Value = 0;
                return;
            }
            if (usecheck.Checked == false)
                File.WriteAllText(ApplicationData + @"\ReCPU\GENERATED.reg", @"Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0]
""ProcessorNameString""=""" + dein.Text + @"""");
            if (usecheck.Checked == true)
                File.WriteAllText(ApplicationData + @"\ReCPU\GENERATED.reg", @"Windows Registry Editor Version 5.00

[HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0]
""ProcessorNameString""=""" + dein.Text + @" @ " + speedinput.Text + @" GHz""");
            barLabel.Text = "Importing configuration...";
            barProgress.Value = 70;
            global::ReCPU.RegExportImport.ImportReg(ApplicationData + @"\ReCPU\GENERATED.reg", null);
            barLabel.Text = "Done.";
            barProgress.Value = 100;
        }

        private void restore_Click(object sender, EventArgs e)
        {
            barLabel.Text = "Restoring CPU information...";
            barProgress.Value = 50;
            if (File.Exists(ApplicationData + @"\ReCPU\ORGCPU.reg"))
            {
                global::ReCPU.RegExportImport.ImportReg(ApplicationData + @"\ReCPU\ORGCPU.reg", null);
                barLabel.Text = "Done.";
                barProgress.Value = 100;
            }
            else
            {
                MessageBox.Show(@"Original CPU information not found.
The original CPU information is backed up the first time you apply the configuration.
Please click apply button to buckup you CPU information and try to restore again.
If you still get this error message, make sure you can access to the directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barLabel.Text = "Restore Failed.";
                barProgress.Value = 0;
            }
        }

        private void usecheck_CheckedChanged(object sender, EventArgs e)
        {
            if (usecheck.Checked == false)
            {
                speedinput.Enabled = false;
            }
            if (usecheck.Checked == true)
            {
                speedinput.Enabled = true;
            }
        }

        private void isclear_Click(object sender, EventArgs e)
        {
            if (isclear.Checked == true)
            {
                IniFunc.writeString("Section 1", "ClearMode", "true", ApplicationData + @"\ReCPU\Settings.ini");
                switch (MessageBox.Show(@"ClearMode should only be enabled under Windows 10 environment.
Do not try it under Windows 7/8/8.1.
The application will atomaticly reload to take effect.
Please notice: The display effect is not ideal.
Continue?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        break;
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.Abort:
                        break;
                    case DialogResult.Retry:
                        break;
                    case DialogResult.Ignore:
                        break;
                    case DialogResult.Yes:
                        break;
                    case DialogResult.No:
                        isclear.Checked = false;
                        return;
                    default:
                        break;
                }
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                IniFunc.writeString("Section 1", "ClearMode", "false", ApplicationData + @"\ReCPU\Settings.ini");
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void allowCustomCPUModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (useCustomCPUModelToolStripMenuItem.Checked == true)
            {
                IniFunc.writeString("Section 1", "UseCustomCPU", "true", ApplicationData + @"\ReCPU\Settings.ini");
                inputsellab.Text = "Input CPU model:";
                dein.DropDownStyle = ComboBoxStyle.DropDown;
                dein.Items.Clear();
                dein.Enabled = true;
                dein.Text = null;
                manuname.Enabled = false;
                manuname.Items.Clear();
                manuname.Text = null;
                modu1.Enabled = false;
                modu1.Items.Clear();
                modu1.Text = null;
                cpugen.Enabled = false;
                cpugen.Items.Clear();
                cpugen.Text = null;
            }
            else
            {
                IniFunc.writeString("Section 1", "UseCustomCPU", "false", ApplicationData + @"\ReCPU\Settings.ini");
                inputsellab.Text = "Select CPU model:";
                dein.DropDownStyle = ComboBoxStyle.DropDownList;
                manuname.Enabled = true;
                modu1.Enabled = true;
                cpugen.Enabled = true;
                manuname.Items.Clear();
                manuname.Items.Add("Intel Core");
            }
            usecustomcpu = IniFunc.getString("Section 1", "UseCustomCPU", "false", ApplicationData + @"\ReCPU\Settings.ini");
        }
    }


}
