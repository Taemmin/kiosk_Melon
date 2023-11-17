using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Project
{
    public partial class Form1 : Form
    {
        LoginForm loginForm = new LoginForm();
        DialogResult result;
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Visible= false;
        }

        private void toolStrip앨범1_Click(object sender, EventArgs e)
        {
            NewJeansForm modal = null;
            if (modal == null)
            {
                modal = new NewJeansForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip1위가사_Click(object sender, EventArgs e)
        {
            NewJeansForm2 modal = null;
            if (modal == null)
            {
                modal = new NewJeansForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범2_Click(object sender, EventArgs e)
        {
            SevenForm modal = null;
            if (modal == null)
            {
                modal = new SevenForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip2위가사_Click(object sender, EventArgs e)
        {
            SevenForm2 modal = null;
            if (modal == null)
            {
                modal = new SevenForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범3_Click(object sender, EventArgs e)
        {
            NewJeansForm modal = null;
            if (modal == null)
            {
                modal = new NewJeansForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip3위가사_Click(object sender, EventArgs e)
        {
            ETAAForm modal = null;
            if (modal == null)
            {
                modal = new ETAAForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범4_Click(object sender, EventArgs e)
        {
            IFeelForm modal = null;
            if (modal == null)
            {
                modal = new IFeelForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip4위가사_Click(object sender, EventArgs e)
        {
            IFeelForm2 modal = null;
            if (modal == null)
            {
                modal = new IFeelForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범5_Click(object sender, EventArgs e)
        {
            ParkForm modal = null;
            if (modal == null)
            {
                modal = new ParkForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip5위가사_Click(object sender, EventArgs e)
        {
            ParkForm2 modal = null;
            if (modal == null)
            {
                modal = new ParkForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범6_Click(object sender, EventArgs e)
        {
            IVEForm modal = null;
            if (modal == null)
            {
                modal = new IVEForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip6위가사_Click(object sender, EventArgs e)
        {
            IVEForm2 modal = null;
            if (modal == null)
            {
                modal = new IVEForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범7_Click(object sender, EventArgs e)
        {
            LESSERAFIMForm modal = null;
            if (modal == null)
            {
                modal = new LESSERAFIMForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip7위가사_Click(object sender, EventArgs e)
        {
            LESSERAFIMForm2 modal = null;
            if (modal == null)
            {
                modal = new LESSERAFIMForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범8_Click(object sender, EventArgs e)
        {
            AespaForm modal = null;
            if (modal == null)
            {
                modal = new AespaForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip8위가사_Click(object sender, EventArgs e)
        {
            AespaForm2 modal = null;
            if (modal == null)
            {
                modal = new AespaForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범9_Click(object sender, EventArgs e)
        {
            HEROForm modal = null;
            if (modal == null)
            {
                modal = new HEROForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip9위가사_Click(object sender, EventArgs e)
        {
            HEROForm2 modal = null;
            if (modal == null)
            {
                modal = new HEROForm2();
                modal.ShowDialog();
            }
        }

        private void toolStrip앨범10_Click(object sender, EventArgs e)
        {
            NewJeansForm modal = null;
            if (modal == null)
            {
                modal = new NewJeansForm();
                modal.ShowDialog();
            }
        }

        private void toolStrip10위가사_Click(object sender, EventArgs e)
        {
            New10Form modal = null;
            if (modal == null)
            {
                modal = new New10Form();
                modal.ShowDialog();
            }
        }

        private void toolStripMenuMymusic_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1위담기_Click(object sender, EventArgs e)
        {
            pick("NewJeans - Super Shy");
        }

        void pick(string sname)
        {
            ToolStripMenuItem fourthItem = (ToolStripMenuItem)menuStrip1.Items[3];
            fourthItem.DropDownItems.Add(sname);
        }

        private void toolStrip2위담기_Click(object sender, EventArgs e)
        {
            pick("정국 - Seven (feat.Latto) - Clean Ver.");
        }

        private void toolStrip3위담기_Click(object sender, EventArgs e)
        {
            pick("NewJeans - ETA");
        }

        private void toolStrip4위담기_Click(object sender, EventArgs e)
        {
            pick("(여자)아이돌 - 퀸카(Queencard)");
        }

        private void toolStrip5위담기_Click(object sender, EventArgs e)
        {
            pick("박재정 - 헤어지자 말해요");
        }

        private void toolStrip6위담기_Click(object sender, EventArgs e)
        {
            pick("IVE(아이브) - I AM");
        }

        private void toolStrip7위담기_Click(object sender, EventArgs e)
        {
            pick("LE SSERAFIM - 이브, 프시케 그리고 푸른 수염의 아내");
        }

        private void toolStrip8위담기_Click(object sender, EventArgs e)
        {
            pick("aespa - Spicy");
        }

        private void toolStrip9위담기_Click(object sender, EventArgs e)
        {
            pick("임영웅 - 사랑은 늘 도망가");
        }

        private void toolStrip10위담기_Click(object sender, EventArgs e)
        {
            pick("NewJeans - New Jeans");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginForm modal = null;
            if (modal == null)
            {
                modal = new LoginForm();
                modal.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginForm modal = null;
            result = loginForm.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                button1.Visible = loginForm.Loginbutton;
                menuStrip1.Visible = loginForm.menustriptf;
            }
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            PayForm modal = null;
            if (modal == null)
            {
                modal = new PayForm();
                modal.ShowDialog();
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {

        }
    }
}
