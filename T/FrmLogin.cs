using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Class1.OpenConnection();
            Class1.IsAdmin = false;
            timer1.Enabled = true;
            for (int i = 1; i < 101; i++)
            {
                i += 1;
                progressBar1.Value = i;
            }

            if (progressBar1.Value == 100)
            {
                this.Hide();
            }


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
