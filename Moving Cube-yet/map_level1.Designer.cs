namespace Moving_Cube_yet
{
    partial class map_level1
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
            this.label_time = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.timer_c_1 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_2 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_3 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_4 = new System.Windows.Forms.Timer(this.components);
            this.timer_c_5 = new System.Windows.Forms.Timer(this.components);
            this.label_heart = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.timer_count = new System.Windows.Forms.Timer(this.components);
            this.label_done = new System.Windows.Forms.Label();
            this.label_done_score = new System.Windows.Forms.Label();
            this.label_done_addscore = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.food3 = new System.Windows.Forms.PictureBox();
            this.food2 = new System.Windows.Forms.PictureBox();
            this.food1 = new System.Windows.Forms.PictureBox();
            this.timer_done_show = new System.Windows.Forms.Timer(this.components);
            this.timer_c_cursor = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("SimSun", 15F);
            this.label_time.Location = new System.Drawing.Point(12, 9);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(119, 20);
            this.label_time.TabIndex = 0;
            this.label_time.Text = "时间剩余:35";
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("SimSun", 18F);
            this.button_start.Location = new System.Drawing.Point(327, 409);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(130, 60);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            this.button_start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyDown);
            this.button_start.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button_start_KeyUp);
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
            // label_heart
            // 
            this.label_heart.AutoSize = true;
            this.label_heart.Font = new System.Drawing.Font("SimSun", 15F);
            this.label_heart.Location = new System.Drawing.Point(633, 9);
            this.label_heart.Name = "label_heart";
            this.label_heart.Size = new System.Drawing.Size(69, 20);
            this.label_heart.TabIndex = 3;
            this.label_heart.Text = "生命：";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("SimSun", 25F);
            this.label_score.Location = new System.Drawing.Point(12, 719);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(117, 34);
            this.label_score.TabIndex = 7;
            this.label_score.Text = "Score:";
            // 
            // timer_count
            // 
            this.timer_count.Interval = 1000;
            this.timer_count.Tick += new System.EventHandler(this.timer_count_Tick);
            // 
            // label_done
            // 
            this.label_done.AutoSize = true;
            this.label_done.BackColor = System.Drawing.SystemColors.Control;
            this.label_done.Font = new System.Drawing.Font("SimSun", 50F);
            this.label_done.ForeColor = System.Drawing.Color.Red;
            this.label_done.Location = new System.Drawing.Point(311, 81);
            this.label_done.Name = "label_done";
            this.label_done.Size = new System.Drawing.Size(163, 67);
            this.label_done.TabIndex = 8;
            this.label_done.Text = "完成";
            this.label_done.Visible = false;
            // 
            // label_done_score
            // 
            this.label_done_score.AutoSize = true;
            this.label_done_score.Font = new System.Drawing.Font("SimSun", 20F);
            this.label_done_score.Location = new System.Drawing.Point(228, 151);
            this.label_done_score.Name = "label_done_score";
            this.label_done_score.Size = new System.Drawing.Size(93, 27);
            this.label_done_score.TabIndex = 9;
            this.label_done_score.Text = "分数：";
            this.label_done_score.Visible = false;
            // 
            // label_done_addscore
            // 
            this.label_done_addscore.AutoSize = true;
            this.label_done_addscore.Font = new System.Drawing.Font("SimSun", 20F);
            this.label_done_addscore.Location = new System.Drawing.Point(228, 178);
            this.label_done_addscore.Name = "label_done_addscore";
            this.label_done_addscore.Size = new System.Drawing.Size(93, 27);
            this.label_done_addscore.TabIndex = 10;
            this.label_done_addscore.Text = "加分：";
            this.label_done_addscore.Visible = false;
            // 
            // button_done
            // 
            this.button_done.Font = new System.Drawing.Font("SimSun", 25F);
            this.button_done.Location = new System.Drawing.Point(323, 227);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(130, 60);
            this.button_done.TabIndex = 11;
            this.button_done.Text = "返回";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Visible = false;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(371, 360);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(43, 43);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // food3
            // 
            this.food3.Image = global::Moving_Cube_yet.Properties.Resources.f_green;
            this.food3.Location = new System.Drawing.Point(420, 371);
            this.food3.Name = "food3";
            this.food3.Size = new System.Drawing.Size(21, 21);
            this.food3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food3.TabIndex = 6;
            this.food3.TabStop = false;
            // 
            // food2
            // 
            this.food2.Image = global::Moving_Cube_yet.Properties.Resources.f_green;
            this.food2.Location = new System.Drawing.Point(344, 371);
            this.food2.Name = "food2";
            this.food2.Size = new System.Drawing.Size(21, 21);
            this.food2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food2.TabIndex = 5;
            this.food2.TabStop = false;
            // 
            // food1
            // 
            this.food1.Image = global::Moving_Cube_yet.Properties.Resources.f_green;
            this.food1.Location = new System.Drawing.Point(382, 333);
            this.food1.Name = "food1";
            this.food1.Size = new System.Drawing.Size(21, 21);
            this.food1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.food1.TabIndex = 4;
            this.food1.TabStop = false;
            // 
            // timer_done_show
            // 
            this.timer_done_show.Interval = 40;
            this.timer_done_show.Tick += new System.EventHandler(this.timer_done_show_Tick);
            // 
            // timer_c_cursor
            // 
            this.timer_c_cursor.Interval = 1;
            this.timer_c_cursor.Tick += new System.EventHandler(this.timer_c_cursor_Tick);
            // 
            // map_level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.player);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.label_done_addscore);
            this.Controls.Add(this.label_done_score);
            this.Controls.Add(this.label_done);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.food3);
            this.Controls.Add(this.food2);
            this.Controls.Add(this.food1);
            this.Controls.Add(this.label_heart);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_time);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "map_level1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.map_level1_FormClosing_1);
            this.Load += new System.EventHandler(this.map_level1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.map_level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.map_level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer_c_1;
        private System.Windows.Forms.Timer timer_c_2;
        private System.Windows.Forms.Timer timer_c_3;
        private System.Windows.Forms.Timer timer_c_4;
        private System.Windows.Forms.Timer timer_c_5;
        private System.Windows.Forms.Label label_heart;
        private System.Windows.Forms.PictureBox food1;
        private System.Windows.Forms.PictureBox food2;
        private System.Windows.Forms.PictureBox food3;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Timer timer_count;
        private System.Windows.Forms.Label label_done;
        private System.Windows.Forms.Label label_done_score;
        private System.Windows.Forms.Label label_done_addscore;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Timer timer_done_show;
        private System.Windows.Forms.Timer timer_c_cursor;
    }
}