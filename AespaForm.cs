using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AespaForm : Form
    {
        public AespaForm()
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
            if (checkBox2.Checked == true)
            {
                strSong += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)
            {
                strSong += checkBox3.Text + "\n";
            }
            if (checkBox4.Checked == true)
            {
                strSong += checkBox4.Text + "\n";
            }
            if (checkBox5.Checked == true)
            {
                strSong += checkBox5.Text + "\n";
            }
            if (checkBox6.Checked == true)
            {
                strSong += checkBox6.Text + "\n";
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false &&
                checkBox3.Checked == false && checkBox4.Checked == false &&
                checkBox5.Checked == false && checkBox6.Checked == false)
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

        private void btnHeart3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum3.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum3.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum3.Text = num.ToString();
                click++;
            }
        }

        private void btnHeart4_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum4.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum4.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum4.Text = num.ToString();
                click++;
            }
        }

        private void btnHeart5_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum5.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum5.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum5.Text = num.ToString();
                click++;
            }
        }

        private void btnHeart6_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum6.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum6.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum6.Text = num.ToString();
                click++;
            }
        }

        private void btnHeart7_Click(object sender, EventArgs e)
        {
            int num = int.Parse(lblNum7.Text);

            if (click % 2 == 0)
            {
                num++;
                lblNum7.Text = num.ToString();
                click++;
            }
            else
            {
                num--;
                lblNum7.Text = num.ToString();
                click++;
            }
        }
    }
}
