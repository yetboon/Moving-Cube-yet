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
    public partial class map_level3 : Form
    {
        string C_code = File.ReadAllText("data//C.dll");
        Random rx_food = new Random();
        Random ry_food = new Random();
        Random block_random = new Random();
        int file_score = Convert.ToInt32(File.ReadAllText("data//score.dll"));
        int live, score, add_score, final_score, time = 40;
        Form_SC SC = new Form_SC();
        bool top, bottom, left, right;
        SoundPlayer hit1 = new SoundPlayer();
        SoundPlayer hit2 = new SoundPlayer();
        SoundPlayer eat1 = new SoundPlayer();
        SoundPlayer eat2 = new SoundPlayer();

        int g_b_c;
        bool bool_block_move = false;
        bool bool_block2_move = false;
        bool bool_block3_move = false;
        bool bool_block4_move = false;
        bool bool_block5_move = false;
        bool bool_block6_move = false;

        private void map_level3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出吗？已收集的分数将不会被保存。", "确定吗？", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            if (dr == DialogResult.OK)
            {
                SC.Show();
                this.Dispose();
            }
        }

        public map_level3()
        {
            InitializeComponent();
        }

        private void map_level3_Load(object sender, EventArgs e)
        {
            food1.Top = rx_food.Next(20, 700);
            food1.Left = rx_food.Next(21, 721);
            if (C_code == "1")
            {
                player.ImageLocation = "data//picture//p_white.png";
                label_heart.Text = "生命：1";
                live = 1;
                timer_c_2.Dispose();
                timer_c_3.Dispose();
                timer_c_4.Dispose();
                timer_c_5.Dispose();
            }
            if (C_code == "2")
            {
                player.ImageLocation = "data//picture//p_blue.png";
                label_heart.Text = "生命：1";
                live = 1;
                timer_c_1.Dispose();
                timer_c_3.Dispose();
                timer_c_4.Dispose();
                timer_c_5.Dispose();
            }
            if (C_code == "3")
            {
                player.ImageLocation = "data//picture//p_green.png";
                label_heart.Text = "生命：2";
                live = 2;
                timer_c_2.Dispose();
                timer_c_1.Dispose();
                timer_c_4.Dispose();
                timer_c_5.Dispose();
            }
            if (C_code == "4")
            {
                player.ImageLocation = "data//picture//p_red.png";
                label_heart.Text = "生命：3";
                live = 3;
                timer_c_2.Dispose();
                timer_c_3.Dispose();
                timer_c_1.Dispose();
                timer_c_5.Dispose();
            }
            if (C_code == "5")
            {
                player.ImageLocation = "data//picture//p_orange.png";
                label_heart.Text = "生命：4";
                live = 4;
                timer_c_2.Dispose();
                timer_c_3.Dispose();
                timer_c_4.Dispose();
                timer_c_4.Dispose();
                timer_c_1.Dispose();
            }
            if (C_code == "cursor")
            {
                player.ImageLocation = "data//picture//cursor.png";
                label_heart.Text = "生命：5";
                live = 5;
                timer_c_2.Dispose();
                timer_c_3.Dispose();
                timer_c_5.Dispose();
                timer_c_4.Dispose();
                timer_c_1.Dispose();
            }
            hit1.SoundLocation = "data//sound//Hit01.wav";
            hit1.Load();
            hit2.SoundLocation = "data//sound//Hit02.wav";
            hit2.Load();
            eat1.SoundLocation = "data//sound//1.wav";
            eat1.Load();
            eat2.SoundLocation = "data//sound//2.wav";
            eat2.Load();

        }

        private void button_done_Click(object sender, EventArgs e)
        {
            file_score = final_score + file_score;
            File.WriteAllText("data//score.dll", Convert.ToString(file_score));
            SC.Show();
            this.Dispose();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
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
                timer_c_cursor.Start();
            }
            timer_count.Start();
            button_start.Visible = false;
            timer_random_block.Start();
            timer_block_1.Start();
        }

        #region timer :)

        private void timer_c_1_Tick(object sender, EventArgs e)
        {
            if (top == true) { player.Top -= 10; }
            if (left == true) { player.Left -= 10; }
            if (bottom == true) { player.Top += 10; }
            if (right == true) { player.Left += 10; }
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
        private void timer_count_Tick(object sender, EventArgs e)
        {
            time -= 1;
            label_time.Text = "时间剩余:" + time;
            if (time < 10)
            {
                label_time.ForeColor = Color.Yellow;
            }
            if (time <= 0)
            {
                string history_record_read = File.ReadAllText("data//history record.dll");
                File.WriteAllText("data//history record.dll", "||你在level3关卡中获得了总共"
                    + final_score + "分数，生命剩余" + live+ "加分数为：" + add_score + history_record_read);
                label_score.Hide();
                player.Top = -100; player.Left = -150;
                player.Dispose();
                timer_count.Stop();
                final_add_score();
                timer_random_block.Stop();
                label_time.Text = "时间剩余:" + time;
                label_time.ForeColor = Color.White;
                label_done.Visible = true;
                label_done_addscore.Visible = true;
                label_done_addscore.Text = "加分：" + add_score;
                label_done_score.Visible = true;
                label_done_score.Text = "分数：" + score;
                button_done.Visible = true;
                final_score = score + add_score;
            }
            if (time > 1)
            {
                timer_block_1.Interval = time;
            }
        }

        private void timer_random_block_Tick(object sender, EventArgs e)
        {
            g_b_c = block_random.Next(1, 7);
            if (g_b_c == 1)
            {
                if (block_1.Top < 770) { }
                else { bool_block_move = true; }
            }
            if (g_b_c == 2)
            {
                if (block_1.Top < 770) { }
                else { bool_block2_move = true; }
            }
            if (g_b_c == 3)
            {
                if (block_1.Top < 770) { }
                else { bool_block3_move = true; }
            }
            if (g_b_c == 4)
            {
                if (block_1.Top < 770) { }
                else { bool_block4_move = true; }
            }
            if (g_b_c == 5)
            {
                if (block_1.Top < 770) { }
                else { bool_block5_move = true; }
            }
            if (g_b_c == 6)
            {
                if (block_1.Top < 770) { }
                else { bool_block6_move = true; }
            }
        }

        private void timer_block_1_Tick(object sender, EventArgs e)
        {// 47,-50
            if (bool_block_move == true) { bool_block_move = false; block_1.Top = -50; block_1.Left = 47; }
            if (bool_block2_move == true) { bool_block2_move = false; block_2.Top = -50; block_2.Left = 163; }
            if (bool_block3_move == true) { bool_block3_move = false; block_3.Top = -50; block_3.Left = 279; }
            if (bool_block4_move == true) { bool_block4_move = false; block_4.Top = -50; block_4.Left = 395; }
            if (bool_block5_move == true) { bool_block5_move = false; block_5.Top = -50; block_5.Left = 511; }
            if (bool_block6_move == true) { bool_block6_move = false; block_6.Top = -50; block_6.Left = 627; }

            if (block_1.Top < 770) { block_1.Top += 11; }
            if (block_2.Top < 770) { block_2.Top += 11; }
            if (block_3.Top < 770) { block_3.Top += 11; }
            if (block_4.Top < 770) { block_4.Top += 11; }
            if (block_5.Top < 770) { block_5.Top += 11; }
            if (block_6.Top < 770) { block_6.Top += 11; }
        }

        #endregion

        #region void list 1
        void final_add_score()
        {
            if (score > 5)
            {
                add_score = 1;
            }
            if (score > 10)
            {
                add_score = 2;
            }
            if (score > 15)
            {
                add_score = 3;
            }
            if (score > 20)
            {
                add_score = 4;
            }
            if (score > 25)
            {
                add_score = 5;
            }
            if (score > 30)
            {
                add_score = 6;
            }
            if (score > 35)
            {
                add_score = 8;
            }
            if (score > 40)
            {
                add_score = 10;
            }
            if (score > 45)
            {
                add_score = 12;
            }
        }

        private void timer_c_cursor_Tick(object sender, EventArgs e)
        {
            player.Top = Cursor.Position.Y - 93;
            player.Left = Cursor.Position.X - 455;
            collision_wall();
            collision();
        }

        void collision()
        {
            if (player.Bounds.IntersectsWith(food1.Bounds))
            { if (time < 10)
                {
                    score += 10;
                    label_score.Text = "Score:" + score;
                    food1.Top = rx_food.Next(40, 680);
                    food1.Left = rx_food.Next(41, 701);
                } if (time > 10)
                {
                    score += 6;
                    label_score.Text = "Score:" + score;
                    food1.Top = rx_food.Next(20, 700);
                    food1.Left = rx_food.Next(21, 721);
                }
                eat1.Play();
            }
            if (player.Bounds.IntersectsWith(food2.Bounds))
            { if (time < 10)
                {
                    score += 5;
                    label_score.Text = "Score:" + score;
                    food2.Top = rx_food.Next(40, 680);
                    food2.Left = rx_food.Next(41, 701);
                } if (time > 10)
                {
                    score += 2;
                    label_score.Text = "Score:" + score;
                    food2.Top = rx_food.Next(20, 700);
                    food2.Left = rx_food.Next(21, 721);
                }
                eat2.Play();
            }
            if (player.Bounds.IntersectsWith(food3.Bounds))
            { if (time < 10)
                {
                    score += 5;
                    label_score.Text = "Score:" + score;
                    food3.Top = rx_food.Next(40, 680);
                    food3.Left = rx_food.Next(41, 701);
                } if (time > 10)
                {
                    score += 2;
                    label_score.Text = "Score:" + score;
                    food3.Top = rx_food.Next(20, 700);
                    food3.Left = rx_food.Next(21, 721);
                }
                eat2.Play();
            }
            if (player.Bounds.IntersectsWith(block_1.Bounds)){collision_with_block(); block_1.Top = -50; hit1.Play(); }
            if (player.Bounds.IntersectsWith(block_2.Bounds)){collision_with_block(); block_2.Top = -50; hit2.Play(); }
            if (player.Bounds.IntersectsWith(block_3.Bounds)){collision_with_block(); block_3.Top = -50; hit1.Play(); }
            if (player.Bounds.IntersectsWith(block_4.Bounds)){collision_with_block(); block_4.Top = -50; hit2.Play(); }
            if (player.Bounds.IntersectsWith(block_5.Bounds)){collision_with_block(); block_5.Top = -50; hit1.Play(); }
            if (player.Bounds.IntersectsWith(block_6.Bounds)){collision_with_block(); block_6.Top = -50; hit2.Play(); }
        }
        void collision_with_block()
        {
            live -= 1;
            label_heart.Text = "生命：" + live;
            if (live == 0)
            {
                time = 1;
            }
        }
        void collision_wall()
        {
            if (player.Top > 720) { player.Top = 720; }
            if (player.Left > 741) { player.Left = 741; }
            if (player.Top < 0) { player.Top = 0; }
            if (player.Left < 1) { player.Left = 1; }
        }
        #endregion
        #region control move with keyboard :D
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
        private void map_level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.S) { bottom = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }
        private void map_level3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.S) { bottom = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }
        #endregion
    }
}
