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
    public partial class Form_SC : Form
    {
        int Score = Convert.ToInt32(File.ReadAllText("data//score.dll"));
        string bool_blue = File.ReadAllText("data//bool_blue.dll");
        string bool_green = File.ReadAllText("data//bool_green.dll");
        string bool_red = File.ReadAllText("data//bool_red.dll");
        string bool_orange = File.ReadAllText("data//bool_orange.dll");
        public Form_SC()
        {
            InitializeComponent();
        }

        private void Form_SC_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_GS gs = new Form_GS();
            gs.Show();
            this.Dispose();
        }

        private void Form_SC_Load(object sender, EventArgs e)
        {
            label_score.Text = "Score:" + File.ReadAllText("data//score.dll");
            if (bool_blue == "true")
            {
                label2.Text = "已购买";
                button_blue.Text = "使用";
            }
            if(bool_green == "true")
            {
                label3.Text = "已购买";
                button_green.Text = "使用";
            }
            if (bool_red == "true")
            {
                label4.Text = "已购买";
                button_red.Text = "使用";
            }
            if (bool_orange == "true")
            {
                label5.Text = "已购买";
                button_orange.Text = "使用";
            }
        }

        private void button_blue_Click(object sender, EventArgs e)
        {
            if (bool_blue == "false")
            {
                if (Score < 200)
                {
                    Class_staticsound.bt_click2();
                    MessageBox.Show("分数不足");
                }
                else
                {
                    Class_staticsound.bt_click();
                    label2.Text = "已购买";
                    button_blue.Text = "使用";
                    Score = Score - 200;
                    File.WriteAllText("data//score.dll", Score.ToString());
                    File.WriteAllText("data//bool_blue.dll", "true");
                    label_score.Text = "Score:" + File.ReadAllText("data//score.dll");
                    MessageBox.Show("请重新打开游戏以便使用您购买的物件","需要重启");
                }
            }
            if(bool_blue == "true")
            {
                File.WriteAllText("data//C.dll", "2");
                NextForm();
            }
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            if (bool_green == "false")
            {
                if (Score < 500)
                {
                    Class_staticsound.bt_click2();
                    MessageBox.Show("分数不足");
                }
                else
                {
                    Class_staticsound.bt_click();
                    label3.Text = "已购买";
                    button_green.Text = "使用";
                    Score = Score - 500;
                    File.WriteAllText("data//score.dll", Score.ToString());
                    File.WriteAllText("data//bool_green.dll", "true");
                    label_score.Text = "Score:" + File.ReadAllText("data//score.dll");
                    MessageBox.Show("请重新打开游戏以便使用您购买的物件", "需要重启");
                }
            }
            if (bool_green == "true")
            {
                File.WriteAllText("data//C.dll", "3");
                NextForm();
            }
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            if (bool_red == "false")
            {
                if (Score < 1000)
                {
                    Class_staticsound.bt_click2();
                    MessageBox.Show("分数不足");
                }
                else
                {
                    Class_staticsound.bt_click();
                    label4.Text = "已购买";
                    button_red.Text = "使用";
                    Score = Score - 1000;
                    File.WriteAllText("data//score.dll", Score.ToString());
                    File.WriteAllText("data//bool_red.dll", "true");
                    label_score.Text = "Score:" + File.ReadAllText("data//score.dll");
                    MessageBox.Show("请重新打开游戏以便使用您购买的物件", "需要重启");
                }
            }
            if (bool_red == "true")
            {
                File.WriteAllText("data//C.dll", "4");
                NextForm();
            }
        }

        private void button_orange_Click(object sender, EventArgs e)
        {
            if (bool_orange == "false")
            {
                if (Score < 2000)
                {
                    Class_staticsound.bt_click2();
                    MessageBox.Show("分数不足");
                }
                else
                {
                    Class_staticsound.bt_click();
                    label5.Text = "已购买";
                    button_orange.Text = "使用";
                    Score = Score - 2000;
                    File.WriteAllText("data//score.dll", Score.ToString());
                    File.WriteAllText("data//bool_orange.dll", "true");
                    label_score.Text = "Score:" + File.ReadAllText("data//score.dll");
                    MessageBox.Show("请重新打开游戏以便使用您购买的物件", "需要重启");
                }
            }
            if (bool_orange == "true")
            {
                File.WriteAllText("data//C.dll", "5");
                NextForm();
            }
        }

        private void button_white_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            File.WriteAllText("data//C.dll", "1");
            NextForm();
        }

        void NextForm()
        {
            Form_SM sm = new Form_SM();
            sm.Show();
            this.Dispose();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click2_sync();
            this.Close();
        }

        private void button_cursor_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            File.WriteAllText("data//C.dll", "cursor");
            NextForm();
        }
    }
}



