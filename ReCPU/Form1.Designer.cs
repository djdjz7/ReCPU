﻿namespace ReCPU
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
            this.speedinput = new System.Windows.Forms.TextBox();
            this.usecheck = new System.Windows.Forms.CheckBox();
            this.ghzlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.modu1.Location = new System.Drawing.Point(126, 59);
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
            this.manuname.Location = new System.Drawing.Point(20, 59);
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
            this.cpugen.Location = new System.Drawing.Point(232, 59);
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
            this.dein.Location = new System.Drawing.Point(20, 88);
            this.dein.Name = "dein";
            this.dein.Size = new System.Drawing.Size(312, 23);
            this.dein.TabIndex = 5;
            this.dein.SelectedIndexChanged += new System.EventHandler(this.dein_SelectedIndexChanged);
            // 
            // apply
            // 
            this.apply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply.Location = new System.Drawing.Point(20, 142);
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
            this.restore.Location = new System.Drawing.Point(232, 142);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(100, 23);
            this.restore.TabIndex = 7;
            this.restore.Text = "Restore";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // speedinput
            // 
            this.speedinput.Enabled = false;
            this.speedinput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedinput.Location = new System.Drawing.Point(184, 115);
            this.speedinput.Name = "speedinput";
            this.speedinput.Size = new System.Drawing.Size(113, 23);
            this.speedinput.TabIndex = 9;
            // 
            // usecheck
            // 
            this.usecheck.AutoSize = true;
            this.usecheck.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usecheck.Location = new System.Drawing.Point(20, 117);
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
            this.ghzlabel.Location = new System.Drawing.Point(303, 118);
            this.ghzlabel.Name = "ghzlabel";
            this.ghzlabel.Size = new System.Drawing.Size(29, 15);
            this.ghzlabel.TabIndex = 11;
            this.ghzlabel.Text = "GHz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 187);
            this.Controls.Add(this.ghzlabel);
            this.Controls.Add(this.usecheck);
            this.Controls.Add(this.speedinput);
            this.Controls.Add(this.restore);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.dein);
            this.Controls.Add(this.cpugen);
            this.Controls.Add(this.manuname);
            this.Controls.Add(this.modu1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ReCPU";
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
        private System.Windows.Forms.TextBox speedinput;
        private System.Windows.Forms.CheckBox usecheck;
        private System.Windows.Forms.Label ghzlabel;
    }
}

