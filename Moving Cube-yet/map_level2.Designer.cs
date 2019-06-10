namespace Moving_Cube_yet
{
    partial class map_level2
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
            this.label_heart = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer_c_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_2 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_3 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_4 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_5 = new System.Windows.Forms.Timer(this.components);
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.label_score = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            this.label_done_addscore = new System.Windows.Forms.Label();
            this.label_done_score = new System.Windows.Forms.Label();
            this.label_done = new System.Windows.Forms.Label();
            this.timer_block1 = new System.Windows.Forms.Timer(this.components);
            this.timer_block2 = new System.Windows.Forms.Timer(this.components);
            this.timer_coolshow = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.food = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer_c_cursor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.YellowGreen;
            this.button_start.Font = new System.Drawing.Font("SimSun", 18F);
            this.button_start.Location = new System.Drawing.Point(327, 409);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(130, 60);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            this.button_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyDown);
            this.button_start.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyUp);
            // 
            // label_heart
            // 
            this.label_heart.AutoSize = true;
            this.label_heart.BackColor = System.Drawing.SystemColors.Window;
            this.label_heart.Font = new System.Drawing.Font("SimSun", 15F);
            this.label_heart.Location = new System.Drawing.Point(633, 9);
            this.label_heart.Name = "label_heart";
            this.label_heart.Size = new System.Drawing.Size(69, 20);
            this.label_heart.TabIndex = 5;
            this.label_heart.Text = "生命：";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("SimSun", 15F);
            this.label_time.Location = new System.Drawing.Point(12, 9);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(119, 20);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "时间剩余:45";
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
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("SimSun", 25F);
            this.label_score.Location = new System.Drawing.Point(12, 719);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(134, 34);
            this.label_score.TabIndex = 8;
            this.label_score.Text = "Score:0";
            // 
            // button_done
            // 
            this.button_done.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_done.Font = new System.Drawing.Font("SimSun", 25F);
            this.button_done.Location = new System.Drawing.Point(323, 227);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(130, 60);
            this.button_done.TabIndex = 15;
            this.button_done.Text = "返回";
            this.button_done.UseVisualStyleBackColor = false;
            this.button_done.Visible = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // label_done_addscore
            // 
            this.label_done_addscore.AutoSize = true;
            this.label_done_addscore.Font = new System.Drawing.Font("SimSun", 20F);
            this.label_done_addscore.Location = new System.Drawing.Point(228, 178);
            this.label_done_addscore.Name = "label_done_addscore";
            this.label_done_addscore.Size = new System.Drawing.Size(93, 27);
            this.label_done_addscore.TabIndex = 14;
            this.label_done_addscore.Text = "加分：";
            this.label_done_addscore.Visible = false;
            // 
            // label_done_score
            // 
            this.label_done_score.AutoSize = true;
            this.label_done_score.Font = new System.Drawing.Font("SimSun", 20F);
            this.label_done_score.Location = new System.Drawing.Point(228, 151);
            this.label_done_score.Name = "label_done_score";
            this.label_done_score.Size = new System.Drawing.Size(93, 27);
            this.label_done_score.TabIndex = 13;
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
            this.label_done.TabIndex = 12;
            this.label_done.Text = "完成";
            this.label_done.Visible = false;
            // 
            // timer_block1
            // 
            this.timer_block1.Interval = 25;
            this.timer_block1.Tick += new System.EventHandler(this.timer_block1_Tick);
            // 
            // timer_block2
            // 
            this.timer_block2.Interval = 20;
            this.timer_block2.Tick += new System.EventHandler(this.timer_block2_Tick);
            // 
            // timer_coolshow
            // 
            this.timer_coolshow.Interval = 1;
            this.timer_coolshow.Tick += new System.EventHandler(this.timer_coolshow_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Moving_Cube_yet.Properties.Resources.b_red;
            this.pictureBox3.Location = new System.Drawing.Point(-50, 148);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // block2
            // 
            this.block2.Image = global::Moving_Cube_yet.Properties.Resources.b_red;
            this.block2.Location = new System.Drawing.Point(788, -113);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(50, 110);
            this.block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block2.TabIndex = 33;
            this.block2.TabStop = false;
            this.block2.Visible = false;
            // 
            // block1
            // 
            this.block1.Image = global::Moving_Cube_yet.Properties.Resources.b_red;
            this.block1.Location = new System.Drawing.Point(787, -113);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(50, 110);
            this.block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block1.TabIndex = 32;
            this.block1.TabStop = false;
            this.block1.Visible = false;
            // 
            // food
            // 
            this.food.Image = global::Moving_Cube_yet.Properties.Resources.f_red;
            this.food.Location = new System.Drawing.Point(382, 333);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(21, 21);
            this.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food.TabIndex = 7;
            this.food.TabStop = false;
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(371, 360);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(43, 43);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // timer_c_cursor
            // 
            this.timer_c_cursor.Interval = 1;
            this.timer_c_cursor.Tick += new System.EventHandler(this.timer_c_cursor_Tick);
            // 
            // map_level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.label_done_addscore);
            this.Controls.Add(this.label_done_score);
            this.Controls.Add(this.label_done);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.food);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_heart);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.player);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "map_level2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.map_level2_FormClosing);
            this.Load += new System.EventHandler(this.map_level2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_heart;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer_c_1;
        private System.Windows.Forms.Timer timer_c_2;
        private System.Windows.Forms.Timer timer_c_3;
        private System.Windows.Forms.Timer timer_c_4;
        private System.Windows.Forms.Timer timer_c_5;
        private System.Windows.Forms.Timer timer_count;
        private System.Windows.Forms.PictureBox food;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Label label_done_addscore;
        private System.Windows.Forms.Label label_done_score;
        private System.Windows.Forms.Label label_done;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.Timer timer_block1;
        private System.Windows.Forms.Timer timer_block2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer_coolshow;
        private System.Windows.Forms.Timer timer_c_cursor;
    }
}