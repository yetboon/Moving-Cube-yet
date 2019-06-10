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
    public partial class Form_SM : Form
    {
        public Form_SM()
        {
            InitializeComponent();
        }
        private void Form_SM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_SC sc = new Form_SC();
            sc.Show();
            close_this();
        }

        private void button_level1_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            map_level1 main_game1 = new map_level1();
            main_game1.Show();
            close_this();
        }

        private void button_level2_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            map_level2 main_game2 = new map_level2();
            main_game2.Show();
            close_this();
        }
        private void button_level3_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            map_level3 main_game3 = new map_level3();
            main_game3.Show();
            close_this();
        }

        void close_this()
        {
            this.Dispose();
        }

    }
}
