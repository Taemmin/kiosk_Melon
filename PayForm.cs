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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("SKT 통신 점검 다른 방법 사용하세요.");
                }
                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("KT / LG U+ / 알뜰폰 통신 점검 다른 방법 사용하세요.");
                }
                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("카카오 점검 다른 방법 사용하세요.");
                }
                else if (radioButton5.Checked == true)
                {
                    MessageBox.Show("카카오 점검 다른 방법 사용하세요.");
                }
                else
                {
                    {
                        if (comboBox1.Text == "" || lbPayInfo.Text == "")
                        {
                            MessageBox.Show("결제방법 및 정보를 다시 확인해 주세요");
                            return;
                        }
                        if (checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
                        {
                            Form3 form3 = new Form3();
                            form3.ShowDialog();
                        }
                        else if (checkBox3.Checked == false && checkBox4.Checked == false)
                        {
                            Form4 form4 = new Form4();
                            form4.ShowDialog();
                        }
                        else if (checkBox4.Checked == false)
                        {
                            Form5 form5 = new Form5();
                            form5.ShowDialog();
                        }
                    }
                    
                    string str = comboBox1.Text + "(으)로 " + lbPayInfo.Text + " 결제방법을" + "\n선택하셨습니다.";
                    MessageBox.Show(str);

                    MessageBox.Show("4400원 결제되셨습니다.");
                    Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("2개월 할부");
                lbPayInfo.Items.Add("3개월 할부");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("2개월 할부");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("일시불");
            }
        }
    }
}
