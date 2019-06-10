using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Moving_Cube_yet
{
    public partial class Form_DATA_DEL : Form
    {
        public Form_DATA_DEL()
        {
            InitializeComponent();
        }

        private void Form_DATA_DEL_Load(object sender, EventArgs e)
        {
            File.WriteAllText("data//score.dll", "0");
            progressBar1.Value = 15;
            File.WriteAllText("data//C.dll", "1");
            progressBar1.Value = 25;
            File.WriteAllText("data//bool_blue.dll", "false");
            progressBar1.Value = 50;
            File.WriteAllText("data//bool_green.dll", "false");
            progressBar1.Value = 75;
            File.WriteAllText("data//bool_red.dll", "false");
            progressBar1.Value = 100;
            File.WriteAllText("data//bool_orange.dll", "false");
            File.WriteAllText("data//history record.dll", "");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form_DATA_DEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
