using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project
{
    public partial class SevenForm : Form
    {
        public SevenForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSong = "";
            lblListen.Text = "";
            if (checkBox1.Checked == true)
            {
                strSong += checkBox1.Text + "\n";
            }
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("곡을 선택해주세요.");
            }
            else
            {
                lblListen.Text = strSong + "곡을 듣겠습니다.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblListen.Text = "";
        }
        int click = 0;
        private void btnHeart_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum.Text = num.ToString();
                click++;
            }
        }

        private void btnHeart2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum2.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum2.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum2.Text = num.ToString();
                click++;
            }
        }
    }
}
