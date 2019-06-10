using System;
using System.Windows.Forms;

namespace Moving_Cube_yet
{
    public partial class Form_GS : Form
    {
        Form_SC SC = new Form_SC();
        public Form_GS()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click2_sync();
            Application.Exit();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            Form_about fa = new Form_about();
            fa.Show();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            SC.Show();
            this.Hide();
            Class_staticsound.bt_click();
        }

        private void Form_GS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Class_staticsound.bt_click();
            DialogResult del_data_ms = MessageBox.Show("您确定删除所有资料?所购买的人物与分数将初始化!!!", "确定真的要删除资料？", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if(del_data_ms == DialogResult.OK)
            {
                DialogResult del_data_ms2 = MessageBox.Show("您确定真的要初始化一切档案吗？", "确定真的真的真的要删除资料？ლ(ﾟдﾟლ)", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if(del_data_ms2 == DialogResult.OK)
                {
                    Form_DATA_DEL deldata = new Form_DATA_DEL();
                    deldata.Show();
                }
            }
        }

        private void button_LS_Click(object sender, EventArgs e)
        {
            Form_LS ls = new Form_LS();
            ls.Show();
        }
    }
}
