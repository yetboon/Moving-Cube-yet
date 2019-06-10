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
using System.Media;


namespace Moving_Cube_yet
{
    public partial class map_level1 : Form
    {
        SoundPlayer sound_pop1 = new SoundPlayer();
        SoundPlayer sound_pop2 = new SoundPlayer();
        SoundPlayer sound_pop3 = new SoundPlayer();
        Random rx_food = new Random();
        Random ry_food = new Random();
        Random form_color = new Random();
        string C_code = File.ReadAllText("data//C.dll");
        int file_score = Convert.ToInt32(File.ReadAllText("data//score.dll"));
        int live,score,add_score,final_score,time = 5;
        bool top, bottom, left, right;
        int color_index;
        Form_SC SC = new Form_SC();

        public map_level1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {//720,741
            Class_staticsound.bt_click3();
            food1.Top = rx_food.Next(20, 700);
            food1.Left = rx_food.Next(21, 721);
            food2.Top = rx_food.Next(20, 700);
            food2.Left = rx_food.Next(21, 721);
            food3.Top = rx_food.Next(20, 700);
            food3.Left = rx_food.Next(21, 721);
            if (C_code == "1")
            {
                timer_c_1.Start();
            }
            if (C_code == "2")
            {
                timer_c_2.Start();
            }
            if (C_code == "3")
            {
                timer_c_3.Start();
            }
            if (C_code == "4")
            {
                timer_c_4.Start();
            }
            if (C_code == "5")
            {
                timer_c_5.Start();
            }
            if (C_code == "cursor")
            {
                timer_c_1.Dispose();
                timer_c_2.Dispose();
                timer_c_3.Dispose();
                timer_c_4.Dispose();
                timer_c_5.Dispose();
                timer_c_cursor.Start();
            }
            timer_count.Start();
            button_start.Visible = false;
        }

        private void map_level1_Load(object sender, EventArgs e)
        {
            if(C_code == "1")
            {
                player.ImageLocation = "data//picture//p_white.png";
                label_heart.Text = "生命：1";
                live = 1;
            }
            if(C_code == "2")
            {
                player.ImageLocation = "data//picture//p_blue.png";
                label_heart.Text = "生命：1";
                live = 1;
            }
            if (C_code == "3")
            {
                player.ImageLocation = "data//picture//p_green.png";
                label_heart.Text = "生命：2";
                live = 2;
            }
            if (C_code == "4")
            {
                player.ImageLocation = "data//picture//p_red.png";
                label_heart.Text = "生命：3";
                live = 3;
            }
            if (C_code == "5")
            {
                player.ImageLocation = "data//picture//p_orange.png";
                label_heart.Text = "生命：4";
                live = 4;
            }
            if (C_code == "cursor")
            {
                player.ImageLocation = "data//picture//cursor.png";
                label_heart.Text = "生命：5";
                live = 5;
            }
            sound_pop1.SoundLocation = "data//sound//1.wav";
            sound_pop2.SoundLocation = "data//sound//2.wav";
            sound_pop3.SoundLocation = "data//sound//3.wav";
            sound_pop1.Load();
            sound_pop2.Load();
            sound_pop3.Load();
        }

        private void timer_c_1_Tick(object sender, EventArgs e)
        {
            if (top == true) { player.Top -= 10; }
            if (left == true) { player.Left -= 10; }
            if(bottom == true) { player.Top += 10; }
            if(right == true) { player.Left += 10; }
            collision_wall();
            collision();
        }

        private void timer_c_2_Tick(object sender, EventArgs e)
        {
            if (top == true) { player.Top -= 10; }
            if (left == true) { player.Left -= 10; }
            if (bottom == true) { player.Top += 10; }
            if (right == true) { player.Left += 10; }
            collision_wall();
            collision();
        }

        private void timer_c_3_Tick(object sender, EventArgs e)
        {
            if (top == true) { player.Top -= 15; }
            if (left == true) { player.Left -= 15; }
            if (bottom == true) { player.Top += 15; }
            if (right == true) { player.Left += 15; }
            collision_wall();
            collision();
        }

        private void timer_c_4_Tick(object sender, EventArgs e)
        {
            if (top == true) { player.Top -= 20; }
            if (left == true) { player.Left -= 20; }
            if (bottom == true) { player.Top += 20; }
            if (right == true) { player.Left += 20; }
            collision_wall();
            collision();
        }

        private void timer_c_5_Tick(object sender, EventArgs e)
        {
            if (top == true) { player.Top -= 30; }
            if (left == true) { player.Left -= 30; }
            if (bottom == true) { player.Top += 30; }
            if (right == true) { player.Left += 30; }
            collision_wall();
            collision();
        }

        private void button_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.S) { bottom = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }
        private void button_start_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.S) { bottom = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }

        private void map_level1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer_done_show_Tick(object sender, EventArgs e)
        {
            food1.Top = rx_food.Next(20, 700);
            food1.Left = rx_food.Next(21, 721);
            food2.Top = rx_food.Next(20, 700);
            food2.Left = rx_food.Next(21, 721);
            food3.Top = rx_food.Next(20, 700);
            food3.Left = rx_food.Next(21, 721);
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            File.WriteAllText("data//score.dll", Convert.ToString(file_score));
            string history_record_read = File.ReadAllText("data//history record.dll");
            File.WriteAllText("data//history record.dll", "|" + DateTime.Now + "|" + "你在level1关卡中获得了总共"
+ final_score + "分数，生命剩余" + live
+ "加分数为：" + add_score + history_record_read);
            timer_done_show.Stop();
            SC.Show();
            this.Dispose();
        }

        private void button_back_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.S) { bottom = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }

        private void button_back_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.S) { bottom = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }

        private void map_level1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出吗？已收集的分数将不会被保存。", "确定吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            if(dr == DialogResult.OK)
            {
                SC.Show();
                this.Dispose();
            }
        }

        private void timer_c_cursor_Tick(object sender, EventArgs e)
        {
            player.Top = Cursor.Position.Y - 93;
            player.Left = Cursor.Position.X - 455;
            collision_wall();
            collision();
        }

        private void timer_count_Tick(object sender, EventArgs e)
        {
            timer_count.Stop();
            time -= 1;
            label_time.Text = "时间剩余:" + time;
            if(time == 0)
            {
                label_score.Hide();
                player.Top = -100; player.Left = -100;
                player.Dispose();
                timer_count.Stop();
                final_add_score();
                label_time.Text = "时间剩余:" + time;
                label_time.ForeColor = Color.Red;
                label_done.Visible = true;
                label_done_addscore.Visible = true;
                label_done_addscore.Text = "加分：" + add_score;
                label_done_score.Visible = true;
                label_done_score.Text = "分数：" + score;
                button_done.Visible = true;
                final_score = score + add_score;
                timer_done_show.Start();
                timer_c_1.Stop();
                timer_c_2.Stop();
                timer_c_3.Stop();
                timer_c_4.Stop();
                timer_c_5.Stop();
                file_score = final_score + file_score;
            }
            else
            {
                timer_count.Start();
            }
        }

        private void map_level1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.S) { bottom = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }
        private void map_level1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.S) { bottom = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }

        void collision()
        {
            if(player.Bounds.IntersectsWith(food1.Bounds))
            {
                score += 1;
                label_score.Text = "Score:" + score;
                food1.Top = rx_food.Next(20, 700);
                food1.Left = rx_food.Next(21, 721);
                form_color_change();
                sound_pop1.Play();
            }
            if(player.Bounds.IntersectsWith(food2.Bounds))
            {
                score += 1;
                label_score.Text = "Score:" + score;
                food2.Top = rx_food.Next(20, 700);
                food2.Left = rx_food.Next(21, 721);
                form_color_change();
                sound_pop2.Play();
            }
            if (player.Bounds.IntersectsWith(food3.Bounds))
            {
                score += 1;
                label_score.Text = "Score:" + score;
                food3.Top = rx_food.Next(20, 700);
                food3.Left = rx_food.Next(21, 721);
                form_color_change();
                sound_pop3.Play();
            }
        }
        void final_add_score()
        {
            if(score > 10)
            {
                add_score = 1;
            }
            if (score > 15)
            {
                add_score = 2;
            }
            if (score > 20)
            {
                add_score = 3;
            }
            if (score > 25)
            {
                add_score = 4;
            }
            if (score > 30)
            {
                add_score = 5;
            }
            if (score > 35)
            {
                add_score = 6;
            }
        }
        void collision_wall()
        {
            if (player.Top > 720) { player.Top = 720; }
            if (player.Left > 741) { player.Left = 741; }
            if (player.Top < 0) { player.Top = 0; }
            if (player.Left < 1) { player.Left = 1; }
        }
        void form_color_change()
        {
            color_index = form_color.Next(1,5);
            if(color_index == 1)
            {
                this.BackColor = Color.LightCoral;
            }
            if (color_index == 2)
            {
                this.BackColor = Color.NavajoWhite;
            }
            if (color_index == 3)
            {
                this.BackColor = Color.YellowGreen;
            }
            if (color_index == 4)
            {
                this.BackColor = Color.MediumSpringGreen;
            }
        }
    }
}
