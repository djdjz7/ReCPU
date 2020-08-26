using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCPU
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void changelogButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/djdjz7/ReCPU/releases/");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
