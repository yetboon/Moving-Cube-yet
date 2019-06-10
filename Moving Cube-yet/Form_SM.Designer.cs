namespace Moving_Cube_yet
{
    partial class Form_SM
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
            this.button_level1 = new System.Windows.Forms.Button();
            this.button_level2 = new System.Windows.Forms.Button();
            this.button_level3 = new System.Windows.Forms.Button();
            this.button_level4 = new System.Windows.Forms.Button();
            this.button_level5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_level1
            // 
            this.button_level1.Location = new System.Drawing.Point(26, 171);
            this.button_level1.Name = "button_level1";
            this.button_level1.Size = new System.Drawing.Size(148, 23);
            this.button_level1.TabIndex = 0;
            this.button_level1.Text = "选择";
            this.button_level1.UseVisualStyleBackColor = true;
            this.button_level1.Click += new System.EventHandler(this.button_level1_Click);
            // 
            // button_level2
            // 
            this.button_level2.Location = new System.Drawing.Point(180, 171);
            this.button_level2.Name = "button_level2";
            this.button_level2.Size = new System.Drawing.Size(148, 23);
            this.button_level2.TabIndex = 6;
            this.button_level2.Text = "选择";
            this.button_level2.UseVisualStyleBackColor = true;
            this.button_level2.Click += new System.EventHandler(this.button_level2_Click);
            // 
            // button_level3
            // 
            this.button_level3.Location = new System.Drawing.Point(334, 171);
            this.button_level3.Name = "button_level3";
            this.button_level3.Size = new System.Drawing.Size(148, 23);
            this.button_level3.TabIndex = 7;
            this.button_level3.Text = "选择";
            this.button_level3.UseVisualStyleBackColor = true;
            this.button_level3.Click += new System.EventHandler(this.button_level3_Click);
            // 
            // button_level4
            // 
            this.button_level4.Enabled = false;
            this.button_level4.Location = new System.Drawing.Point(488, 171);
            this.button_level4.Name = "button_level4";
            this.button_level4.Size = new System.Drawing.Size(148, 23);
            this.button_level4.TabIndex = 8;
            this.button_level4.Text = "选择";
            this.button_level4.UseVisualStyleBackColor = true;
            // 
            // button_level5
            // 
            this.button_level5.Enabled = false;
            this.button_level5.Location = new System.Drawing.Point(642, 171);
            this.button_level5.Name = "button_level5";
            this.button_level5.Size = new System.Drawing.Size(148, 23);
            this.button_level5.TabIndex = 9;
            this.button_level5.Text = "选择";
            this.button_level5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(148, 100);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "计时赛\r\n在时间限定内尽可能地吃掉更多食物\r\n全局时间:35秒\r\n无任何障碍\r\n1 青食物 = 1 score\r\n全局最大3个食物";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 200);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(148, 100);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "小心并躲避红色方块\r\n红色方块会随机出现\r\n尽可能地吃更多食物与躲避更多红色方块\r\n全局时间:25秒\r\n1 红食物 = 2 score\r\n全局最大1个食物\r\n剩余" +
    "十秒内收集分数翻倍";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(334, 200);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(148, 100);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "红色方块会从天上跌下来\r\n注意你的上空\r\n全局时间：45秒\r\n请注意！红色方块掉落速度将会跟着节奏更快\r\n尽可能地躲避更多红色方块\r\n1 紫食物 = 5 scor" +
    "e\r\n1 青食物 = 2 score\r\n全局最大3个食物\r\n分别是1紫食物/2青食物\r\n剩余十秒内收集分数翻倍";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(488, 200);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 100);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "等待下次更新";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(642, 200);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 100);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "等待下次更新";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Moving_Cube_yet.Properties.Resources.no;
            this.pictureBox4.Location = new System.Drawing.Point(642, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(148, 148);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Moving_Cube_yet.Properties.Resources.no;
            this.pictureBox6.Location = new System.Drawing.Point(488, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(148, 148);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Moving_Cube_yet.Properties.Resources.l3_map;
            this.pictureBox3.Location = new System.Drawing.Point(334, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 148);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Moving_Cube_yet.Properties.Resources.l2_map;
            this.pictureBox2.Location = new System.Drawing.Point(180, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 148);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moving_Cube_yet.Properties.Resources.l1_map;
            this.pictureBox1.Location = new System.Drawing.Point(26, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form_SM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(816, 312);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_level5);
            this.Controls.Add(this.button_level4);
            this.Controls.Add(this.button_level3);
            this.Controls.Add(this.button_level2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_level1);
            this.MaximumSize = new System.Drawing.Size(832, 350);
            this.MinimumSize = new System.Drawing.Size(832, 350);
            this.Name = "Form_SM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SM_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_level1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_level2;
        private System.Windows.Forms.Button button_level3;
        private System.Windows.Forms.Button button_level4;
        private System.Windows.Forms.Button button_level5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}