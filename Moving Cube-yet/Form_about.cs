using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Cube_yet
{
    public partial class Form_about : Form
    {
        public Form_about()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form_about_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
