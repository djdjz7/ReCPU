namespace ReCPU
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.modu1 = new System.Windows.Forms.ComboBox();
            this.manuname = new System.Windows.Forms.ComboBox();
            this.cpugen = new System.Windows.Forms.ComboBox();
            this.dein = new System.Windows.Forms.ComboBox();
            this.apply = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.usecheck = new System.Windows.Forms.CheckBox();
            this.ghzlabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.barLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isclear = new System.Windows.Forms.ToolStripMenuItem();
            this.useCustomCPUModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedinput = new System.Windows.Forms.MaskedTextBox();
            this.inputsellab = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "ReCPU";
            // 
            // modu1
            // 
            this.modu1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modu1.FormattingEnabled = true;
            this.modu1.Location = new System.Drawing.Point(126, 74);
            this.modu1.Name = "modu1";
            this.modu1.Size = new System.Drawing.Size(100, 23);
            this.modu1.TabIndex = 2;
            this.modu1.SelectedIndexChanged += new System.EventHandler(this.modu1_SelectedIndexChanged);
            // 
            // manuname
            // 
            this.manuname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manuname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuname.FormattingEnabled = true;
            this.manuname.Items.AddRange(new object[] {
            "Intel Core"});
            this.manuname.Location = new System.Drawing.Point(20, 74);
            this.manuname.Name = "manuname";
            this.manuname.Size = new System.Drawing.Size(100, 23);
            this.manuname.TabIndex = 3;
            this.manuname.SelectedIndexChanged += new System.EventHandler(this.manuname_SelectedIndexChanged);
            // 
            // cpugen
            // 
            this.cpugen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpugen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpugen.FormattingEnabled = true;
            this.cpugen.Location = new System.Drawing.Point(232, 74);
            this.cpugen.Name = "cpugen";
            this.cpugen.Size = new System.Drawing.Size(100, 23);
            this.cpugen.TabIndex = 4;
            this.cpugen.SelectedIndexChanged += new System.EventHandler(this.cpugen_SelectedIndexChanged);
            // 
            // dein
            // 
            this.dein.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dein.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dein.FormattingEnabled = true;
            this.dein.Location = new System.Drawing.Point(20, 122);
            this.dein.Name = "dein";
            this.dein.Size = new System.Drawing.Size(312, 23);
            this.dein.TabIndex = 5;
            this.dein.SelectedIndexChanged += new System.EventHandler(this.dein_SelectedIndexChanged);
            // 
            // apply
            // 
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(20, 176);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(100, 23);
            this.apply.TabIndex = 6;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // restore
            // 
            this.restore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restore.Location = new System.Drawing.Point(232, 176);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(100, 23);
            this.restore.TabIndex = 7;
            this.restore.Text = "Restore";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // usecheck
            // 
            this.usecheck.AutoSize = true;
            this.usecheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usecheck.Location = new System.Drawing.Point(20, 151);
            this.usecheck.Name = "usecheck";
            this.usecheck.Size = new System.Drawing.Size(158, 19);
            this.usecheck.TabIndex = 10;
            this.usecheck.Text = "Use Custom Clock Speed";
            this.usecheck.UseVisualStyleBackColor = true;
            this.usecheck.CheckedChanged += new System.EventHandler(this.usecheck_CheckedChanged);
            // 
            // ghzlabel
            // 
            this.ghzlabel.AutoSize = true;
            this.ghzlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghzlabel.Location = new System.Drawing.Point(303, 152);
            this.ghzlabel.Name = "ghzlabel";
            this.ghzlabel.Size = new System.Drawing.Size(29, 15);
            this.ghzlabel.TabIndex = 11;
            this.ghzlabel.Text = "GHz";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barProgress,
            this.barLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(355, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barProgress
            // 
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // barLabel
            // 
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(42, 17);
            this.barLabel.Text = "Ready.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isclear,
            this.useCustomCPUModelToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // isclear
            // 
            this.isclear.CheckOnClick = true;
            this.isclear.Name = "isclear";
            this.isclear.Size = new System.Drawing.Size(212, 22);
            this.isclear.Text = "ClearMode (Experimental)";
            this.isclear.Click += new System.EventHandler(this.isclear_Click);
            // 
            // useCustomCPUModelToolStripMenuItem
            // 
            this.useCustomCPUModelToolStripMenuItem.CheckOnClick = true;
            this.useCustomCPUModelToolStripMenuItem.Name = "useCustomCPUModelToolStripMenuItem";
            this.useCustomCPUModelToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.useCustomCPUModelToolStripMenuItem.Text = "Use Custom CPU Model";
            this.useCustomCPUModelToolStripMenuItem.Click += new System.EventHandler(this.allowCustomCPUModelToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // speedinput
            // 
            this.speedinput.Enabled = false;
            this.speedinput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedinput.Location = new System.Drawing.Point(184, 151);
            this.speedinput.Mask = "0.00";
            this.speedinput.Name = "speedinput";
            this.speedinput.Size = new System.Drawing.Size(113, 23);
            this.speedinput.TabIndex = 14;
            // 
            // inputsellab
            // 
            this.inputsellab.AutoSize = true;
            this.inputsellab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputsellab.Location = new System.Drawing.Point(18, 107);
            this.inputsellab.Name = "inputsellab";
            this.inputsellab.Size = new System.Drawing.Size(104, 15);
            this.inputsellab.TabIndex = 15;
            this.inputsellab.Text = "Select CPU model:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(355, 234);
            this.Controls.Add(this.inputsellab);
            this.Controls.Add(this.speedinput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ghzlabel);
            this.Controls.Add(this.usecheck);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.dein);
            this.Controls.Add(this.cpugen);
            this.Controls.Add(this.manuname);
            this.Controls.Add(this.modu1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReCPU";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox manuname;
        private System.Windows.Forms.ComboBox modu1;
        private System.Windows.Forms.ComboBox cpugen;
        private System.Windows.Forms.ComboBox dein;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.CheckBox usecheck;
        private System.Windows.Forms.Label ghzlabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar barProgress;
        private System.Windows.Forms.ToolStripStatusLabel barLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isclear;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox speedinput;
        private System.Windows.Forms.Label inputsellab;
        private System.Windows.Forms.ToolStripMenuItem useCustomCPUModelToolStripMenuItem;
    }
}

