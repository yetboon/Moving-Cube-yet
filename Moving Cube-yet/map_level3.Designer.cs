namespace Moving_Cube_yet
{
    partial class map_level3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.label_heart = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            this.label_done_addscore = new System.Windows.Forms.Label();
            this.label_done_score = new System.Windows.Forms.Label();
            this.label_done = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.timer_c_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_2 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_3 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_4 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_5 = new System.Windows.Forms.Timer(this.components);
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.timer_block_1 = new System.Windows.Forms.Timer(this.components);
            this.block_6 = new System.Windows.Forms.PictureBox();
            this.block_5 = new System.Windows.Forms.PictureBox();
            this.block_4 = new System.Windows.Forms.PictureBox();
            this.block_3 = new System.Windows.Forms.PictureBox();
            this.block_2 = new System.Windows.Forms.PictureBox();
            this.block_1 = new System.Windows.Forms.PictureBox();
            this.food3 = new System.Windows.Forms.PictureBox();
            this.food2 = new System.Windows.Forms.PictureBox();
            this.food1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer_random_block = new System.Windows.Forms.Timer(this.components);
            this.timer_c_cursor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.block_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Yellow;
            this.button_start.Font = new System.Drawing.Font("SimSun", 18F);
            this.button_start.Location = new System.Drawing.Point(327, 409);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(130, 60);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            this.button_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyDown);
            this.button_start.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyUp);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("SimSun", 15F);
            this.label_time.Location = new System.Drawing.Point(12, 9);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(119, 20);
            this.label_time.TabIndex = 8;
            this.label_time.Text = "时间剩余:40";
            // 
            // label_heart
            // 
            this.label_heart.AutoSize = true;
            this.label_heart.BackColor = System.Drawing.SystemColors.Window;
            this.label_heart.Font = new System.Drawing.Font("SimSun", 15F);
            this.label_heart.Location = new System.Drawing.Point(633, 9);
            this.label_heart.Name = "label_heart";
            this.label_heart.Size = new System.Drawing.Size(69, 20);
            this.label_heart.TabIndex = 7;
            this.label_heart.Text = "生命：";
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_done.Font = new System.Drawing.Font("SimSun", 25F);
            this.button_done.Location = new System.Drawing.Point(323, 227);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(130, 60);
            this.button_done.TabIndex = 19;
            this.button_done.Text = "返回";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Visible = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // label_done_addscore
            // 
            this.label_done_addscore.AutoSize = true;
            this.label_done_addscore.Font = new System.Drawing.Font("SimSun", 20F);
            this.label_done_addscore.Location = new System.Drawing.Point(212, 175);
            this.label_done_addscore.Name = "label_done_addscore";
            this.label_done_addscore.Size = new System.Drawing.Size(93, 27);
            this.label_done_addscore.TabIndex = 18;
            this.label_done_addscore.Text = "加分：";
            this.label_done_addscore.Visible = false;
            // 
            // label_done_score
            // 
            this.label_done_score.AutoSize = true;
            this.label_done_score.Font = new System.Drawing.Font("SimSun", 20F);
            this.label_done_score.Location = new System.Drawing.Point(212, 148);
            this.label_done_score.Name = "label_done_score";
            this.label_done_score.Size = new System.Drawing.Size(93, 27);
            this.label_done_score.TabIndex = 17;
            this.label_done_score.Text = "分数：";
            this.label_done_score.Visible = false;
            // 
            // label_done
            // 
            this.label_done.AutoSize = true;
            this.label_done.BackColor = System.Drawing.Color.Chartreuse;
            this.label_done.Font = new System.Drawing.Font("SimSun", 50F);
            this.label_done.ForeColor = System.Drawing.Color.Red;
            this.label_done.Location = new System.Drawing.Point(311, 81);
            this.label_done.Name = "label_done";
            this.label_done.Size = new System.Drawing.Size(163, 67);
            this.label_done.TabIndex = 16;
            this.label_done.Text = "完成";
            this.label_done.Visible = false;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("SimSun", 25F);
            this.label_score.Location = new System.Drawing.Point(12, 719);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(134, 34);
            this.label_score.TabIndex = 23;
            this.label_score.Text = "Score:0";
            // 
            // timer_c_1
            // 
            this.timer_c_1.Interval = 55;
            this.timer_c_1.Tick += new System.EventHandler(this.timer_c_1_Tick);
            // 
            // timer_c_2
            // 
            this.timer_c_2.Interval = 40;
            this.timer_c_2.Tick += new System.EventHandler(this.timer_c_2_Tick);
            // 
            // timer_c_3
            // 
            this.timer_c_3.Interval = 35;
            this.timer_c_3.Tick += new System.EventHandler(this.timer_c_3_Tick);
            // 
            // timer_c_4
            // 
            this.timer_c_4.Interval = 30;
            this.timer_c_4.Tick += new System.EventHandler(this.timer_c_4_Tick);
            // 
            // timer_c_5
            // 
            this.timer_c_5.Interval = 20;
            this.timer_c_5.Tick += new System.EventHandler(this.timer_c_5_Tick);
            // 
            // timer_count
            // 
            this.timer_count.Interval = 1000;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // timer_block_1
            // 
            this.timer_block_1.Interval = 50;
            this.timer_block_1.Tick += new System.EventHandler(this.timer_block_1_Tick);
            // 
            // block_6
            // 
            this.block_6.Image = global::Moving_Cube_yet.Properties.Resources.b_red2;
            this.block_6.Location = new System.Drawing.Point(627, 765);
            this.block_6.Name = "block_6";
            this.block_6.Size = new System.Drawing.Size(110, 50);
            this.block_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block_6.TabIndex = 29;
            this.block_6.TabStop = false;
            // 
            // block_5
            // 
            this.block_5.Image = global::Moving_Cube_yet.Properties.Resources.b_red2;
            this.block_5.Location = new System.Drawing.Point(511, 765);
            this.block_5.Name = "block_5";
            this.block_5.Size = new System.Drawing.Size(110, 50);
            this.block_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block_5.TabIndex = 28;
            this.block_5.TabStop = false;
            // 
            // block_4
            // 
            this.block_4.Image = global::Moving_Cube_yet.Properties.Resources.b_red2;
            this.block_4.Location = new System.Drawing.Point(395, 765);
            this.block_4.Name = "block_4";
            this.block_4.Size = new System.Drawing.Size(110, 50);
            this.block_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block_4.TabIndex = 27;
            this.block_4.TabStop = false;
            // 
            // block_3
            // 
            this.block_3.Image = global::Moving_Cube_yet.Properties.Resources.b_red2;
            this.block_3.Location = new System.Drawing.Point(279, 765);
            this.block_3.Name = "block_3";
            this.block_3.Size = new System.Drawing.Size(110, 50);
            this.block_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block_3.TabIndex = 26;
            this.block_3.TabStop = false;
            // 
            // block_2
            // 
            this.block_2.Image = global::Moving_Cube_yet.Properties.Resources.b_red2;
            this.block_2.Location = new System.Drawing.Point(163, 765);
            this.block_2.Name = "block_2";
            this.block_2.Size = new System.Drawing.Size(110, 50);
            this.block_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block_2.TabIndex = 25;
            this.block_2.TabStop = false;
            // 
            // block_1
            // 
            this.block_1.Image = global::Moving_Cube_yet.Properties.Resources.b_red2;
            this.block_1.Location = new System.Drawing.Point(47, 765);
            this.block_1.Name = "block_1";
            this.block_1.Size = new System.Drawing.Size(110, 50);
            this.block_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block_1.TabIndex = 24;
            this.block_1.TabStop = false;
            // 
            // food3
            // 
            this.food3.Image = global::Moving_Cube_yet.Properties.Resources.f_green;
            this.food3.Location = new System.Drawing.Point(420, 371);
            this.food3.Name = "food3";
            this.food3.Size = new System.Drawing.Size(21, 21);
            this.food3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food3.TabIndex = 22;
            this.food3.TabStop = false;
            // 
            // food2
            // 
            this.food2.Image = global::Moving_Cube_yet.Properties.Resources.f_green;
            this.food2.Location = new System.Drawing.Point(344, 371);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(21, 21);
            this.food2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food2.TabIndex = 21;
            this.food2.TabStop = false;
            // 
            // food1
            // 
            this.food1.Image = global::Moving_Cube_yet.Properties.Resources.f_purple;
            this.food1.Location = new System.Drawing.Point(382, 333);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(21, 21);
            this.food1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food1.TabIndex = 20;
            this.food1.TabStop = false;
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(371, 360);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(43, 43);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // timer_random_block
            // 
            this.timer_random_block.Interval = 500;
            this.timer_random_block.Tick += new System.EventHandler(this.timer_random_block_Tick);
            // 
            // timer_c_cursor
            // 
            this.timer_c_cursor.Interval = 1;
            this.timer_c_cursor.Tick += new System.EventHandler(this.timer_c_cursor_Tick);
            // 
            // map_level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.block_6);
            this.Controls.Add(this.block_5);
            this.Controls.Add(this.block_4);
            this.Controls.Add(this.block_3);
            this.Controls.Add(this.block_2);
            this.Controls.Add(this.block_1);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.food3);
            this.Controls.Add(this.food2);
            this.Controls.Add(this.food1);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.label_done_addscore);
            this.Controls.Add(this.label_done_score);
            this.Controls.Add(this.label_done);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_heart);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button_start);
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "map_level3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.map_level3_FormClosing);
            this.Load += new System.EventHandler(this.map_level3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.map_level3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.map_level3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.block_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_heart;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Label label_done_addscore;
        private System.Windows.Forms.Label label_done_score;
        private System.Windows.Forms.Label label_done;
        private System.Windows.Forms.PictureBox food1;
        private System.Windows.Forms.PictureBox food2;
        private System.Windows.Forms.PictureBox food3;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Timer timer_c_1;
        private System.Windows.Forms.Timer timer_c_2;
        private System.Windows.Forms.Timer timer_c_3;
        private System.Windows.Forms.Timer timer_c_4;
        private System.Windows.Forms.Timer timer_c_5;
        private System.Windows.Forms.Timer timer_count;
        private System.Windows.Forms.PictureBox block_1;
        private System.Windows.Forms.PictureBox block_2;
        private System.Windows.Forms.PictureBox block_3;
        private System.Windows.Forms.PictureBox block_4;
        private System.Windows.Forms.PictureBox block_5;
        private System.Windows.Forms.PictureBox block_6;
        private System.Windows.Forms.Timer timer_block_1;
        private System.Windows.Forms.Timer timer_random_block;
        private System.Windows.Forms.Timer timer_c_cursor;
    }
}