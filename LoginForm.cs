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
    public partial class LoginForm : Form
    {
        public bool menustriptf = false;
        public bool Loginbutton = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = ID.Text;
            int userPassword = int.Parse(Password.Text);

            if (userId.Equals("김태민") && userPassword.Equals(1111))
            {
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
                Close();
                this.Close();
                menustriptf = true;
                Loginbutton = true;
            }
            else
            {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }  
        }
    }
}
