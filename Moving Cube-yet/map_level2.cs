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
    public partial class map_level2 : Form
    {
        string C_code = File.ReadAllText("data//C.dll");
        Random rx_food = new Random();
        Random ry_food = new Random();
        Random block_random = new Random();
        SoundPlayer sp = new SoundPlayer();
        SoundPlayer sp2 = new SoundPlayer();
        SoundPlayer hit = new SoundPlayer();
        int file_score = Convert.ToInt32(File.ReadAllText("data//score.dll"));
        int live, score, add_score, final_score, time = 45;
        Form_SC SC = new Form_SC();
        bool top, bottom, left, right;

        int move_count,move_count2;
        bool bool_block_move = false;
        bool bool_block2_move = false;

        private void map_level2_FormClosing(object sender, FormClosingEventArgs e)
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
            timer_count.Stop();
            time -= 1;
            label_time.Text = "时间剩余:" + time;
            if(time < 20)
            {
                label_time.ForeColor = Color.Blue;
                timer_block2.Start();
            }
            if (time < 10)
            {
                label_time.ForeColor = Color.Yellow;
                timer_block2.Start();
            }
            if (time <= 0)
            {
                if(live < 0)
                {
                    live = 0;
                }
                string history_record_read = File.ReadAllText("data//history record.dll");
                File.WriteAllText("data//history record.dll", "||你在level2关卡中获得了总共"
                    + final_score + "分数，生命剩余" + live + "加分数为：" + add_score + history_record_read);
                timer_coolshow.Start();
                label_score.Hide();
                player.Top = -100; player.Left = -100;
                player.Dispose();
                block1.Dispose();
                block2.Dispose();
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
                timer_block1.Stop();
                timer_block2.Stop();
            }
            else
            {
                timer_count.Start();
            }
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            file_score = final_score + file_score;
            File.WriteAllText("data//score.dll", Convert.ToString(file_score));
            timer_coolshow.Stop();
            SC.Show();
            this.Dispose();
        }

        private void timer_block1_Tick(object sender, EventArgs e)
        {
            if(bool_block_move == true)
            {
                if(move_count == 1)
                {
                    block1.Left -= 10;
                    if(block1.Left < -50)
                    {
                        bool_block_move = false;
                    }
                }
                if(move_count == 2)
                {
                    block1.Left += 10;
                    if(block1.Left > 784)
                    {
                        bool_block_move = false;
                    }
                }
                if (move_count == 3)
                {
                    block1.Left -= 10;
                    if (block1.Left < -50)
                    {
                        bool_block_move = false;
                    }
                }
                if (move_count == 4)
                {
                    block1.Left += 10;
                    if (block1.Left > 784)
                    {
                        bool_block_move = false;
                    }
                }
                if (move_count == 5)
                {
                    block1.Left -= 10;
                    if (block1.Left < -50)
                    {
                        bool_block_move = false;
                    }
                }
                if (move_count == 6)
                {
                    block1.Left += 10;
                    if (block1.Left > 784)
                    {
                        bool_block_move = false;
                    }
                }
            }
            else if (bool_block_move == false)
            {
                move_count = block_random.Next(1,7);
                if (move_count == 1)
                {
                    block1.Top = 32;
                    block1.Left = 784;
                }
                if (move_count == 2)
                {
                    block1.Top = 148;
                    block1.Left = -50;
                }
                if (move_count == 3)
                {
                    block1.Top = 264;
                    block1.Left = 784;
                }
                if (move_count == 4)
                {
                    block1.Top = 380;
                    block1.Left = -50;
                }
                if (move_count == 5)
                {
                    block1.Top = 496;
                    block1.Left = 784;
                }
                if (move_count == 6)
                {
                    block1.Top = 612;
                    block1.Left = -50;
                }
                bool_block_move = true;
            }
        }

        private void button_start_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.S) { bottom = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }

        private void timer_coolshow_Tick(object sender, EventArgs e)
        {
            food.Top = rx_food.Next(20, 700);
            food.Left = rx_food.Next(21, 721);
        }

        private void timer_c_cursor_Tick(object sender, EventArgs e)
        {
            player.Top = Cursor.Position.Y - 93;
            player.Left = Cursor.Position.X - 455;
            collision_wall();
            collision();
            if(player.Bounds.IntersectsWith(block1.Bounds))
            {
                cursor_collision_block1();
            }
            if(player.Bounds.IntersectsWith(block2.Bounds))
            {
                cursor_collision_block2();
            }
        }

        private void timer_block2_Tick(object sender, EventArgs e)
        {
            block2.Visible = true;
            if (bool_block2_move == true)
            {
                if (move_count2 == 1)
                {
                    block2.Left -= 10;
                    if (block2.Left < -50)
                    {
                        bool_block2_move = false;
                    }
                }
                if (move_count2 == 2)
                {
                    block2.Left += 10;
                    if (block2.Left > 784)
                    {
                        bool_block2_move = false;
                    }
                }
                if (move_count2 == 3)
                {
                    block2.Left -= 10;
                    if (block2.Left < -50)
                    {
                        bool_block2_move = false;
                    }
                }
                if (move_count2 == 4)
                {
                    block2.Left += 10;
                    if (block2.Left > 784)
                    {
                        bool_block2_move = false;
                    }
                }
                if (move_count2 == 5)
                {
                    block2.Left -= 10;
                    if (block2.Left < -50)
                    {
                        bool_block2_move = false;
                    }
                }
                if (move_count2 == 6)
                {
                    block2.Left += 10;
                    if (block2.Left > 784)
                    {
                        bool_block2_move = false;
                    }
                }
            }
            else if (bool_block2_move == false)
            {
                move_count2 = block_random.Next(1, 7);
                if (move_count2 == 1)
                {
                    block2.Top = 32;
                    block2.Left = 784;
                }
                if (move_count2 == 2)
                {
                    block2.Top = 148;
                    block2.Left = -50;
                }
                if (move_count2 == 3)
                {
                    block2.Top = 264;
                    block2.Left = 784;
                }
                if (move_count2 == 4)
                {
                    block2.Top = 380;
                    block2.Left = -50;
                }
                if (move_count2 == 5)
                {
                    block2.Top = 496;
                    block2.Left = 784;
                }
                if (move_count2 == 6)
                {
                    block2.Top = 612;
                    block2.Left = -50;
                }
                bool_block2_move = true;
            }
        }

        private void button_start_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { top = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.S) { bottom = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }

        public map_level2()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click3();
            food.Top = rx_food.Next(20, 700);
            food.Left = rx_food.Next(21, 721);
            block1.Visible = true;
            timer_block1.Start();
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
            if(C_code == "cursor")
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

        private void map_level2_Load(object sender, EventArgs e)
        {
            if (C_code == "1")
            {
                player.ImageLocation = "data//picture//p_white.png";
                label_heart.Text = "生命：1";
                live = 1;
            }
            if (C_code == "2")
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
            sp.SoundLocation = "data//sound//2.wav";
            sp.Load();
            sp2.SoundLocation = "data//sound//3.wav";
            sp2.Load();
            hit.SoundLocation = "data//sound//Hit01.wav";
            hit.Load();
        }

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
            if(score > 35)
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
        void collision()
        {
            if (player.Bounds.IntersectsWith(food.Bounds))
            {
                if(time < 10)
                {
                    score += 3;
                    label_score.Text = "Score:" + score;
                    food.Top = rx_food.Next(40, 680);
                    food.Left = rx_food.Next(41, 701);
                    sp2.Play();
                }
                if(time > 10)
                {
                    score += 2;
                    label_score.Text = "Score:" + score;
                    food.Top = rx_food.Next(20, 700);
                    food.Left = rx_food.Next(21, 721);
                    sp.Play();
                }

            }
            if(player.Bounds.IntersectsWith(block1.Bounds))
            {
                live -= 1;
                hit.Play();
                bool_block_move = false;
                label_heart.Text = "生命：" + live;
                if (live == 0)
                {
                    time = 1;
                }
            }
            if (player.Bounds.IntersectsWith(block2.Bounds))
            {
                live -= 1;
                hit.Play();
                bool_block2_move = false;
                label_heart.Text = "生命：" + live;
                if (live == 0)
                {
                    time = 1;
                }
            }
        }
        void cursor_collision_block1()
        {
            move_count = block_random.Next(1, 7);
            if (move_count == 1)
            {
                block1.Top = 32;
                block1.Left = 784;
            }
            if (move_count == 2)
            {
                block1.Top = 148;
                block1.Left = -50;
            }
            if (move_count == 3)
            {
                block1.Top = 264;
                block1.Left = 784;
            }
            if (move_count == 4)
            {
                block1.Top = 380;
                block1.Left = -50;
            }
            if (move_count == 5)
            {
                block1.Top = 496;
                block1.Left = 784;
            }
            if (move_count == 6)
            {
                block1.Top = 612;
                block1.Left = -50;
            }
        }
        void cursor_collision_block2()
        {
            move_count2 = block_random.Next(1, 7);
            if (move_count2 == 1)
            {
                block2.Top = 32;
                block2.Left = 784;
            }
            if (move_count2 == 2)
            {
                block2.Top = 148;
                block2.Left = -50;
            }
            if (move_count2 == 3)
            {
                block2.Top = 264;
                block2.Left = 784;
            }
            if (move_count2 == 4)
            {
                block2.Top = 380;
                block2.Left = -50;
            }
            if (move_count2 == 5)
            {
                block2.Top = 496;
                block2.Left = 784;
            }
            if (move_count2 == 6)
            {
                block2.Top = 612;
                block2.Left = -50;
            }
        }
        void collision_wall()
        {
            if (player.Top > 720) { player.Top = 720; }
            if (player.Left > 741) { player.Left = 741; }
            if (player.Top < 0) { player.Top = 0; }
            if (player.Left < 1) { player.Left = 1; }
        }
    }
}
