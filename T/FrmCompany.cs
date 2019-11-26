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
    public partial class FrmCompany : Form
    {
        
        public FrmCompany()
        {
            InitializeComponent();
        }

        private void FrmCompany_Load(object sender, EventArgs e)
        {
            DataTable DT = Class1.ExecQuery("Company_Select_all");
            CmList.DataSource = DT;
            CmList.DisplayMember = DT.Columns[1].ToString() ;
            CmList.ValueMember = DT.Columns[0].ToString();
            LblId.Text = "";
            TxtCompany.Text = "";
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            CmList.Enabled = false;
            LblId.Text = "";
            TxtCompany.Text = "";
            CmdSave.Enabled = true;
            TxtCompany.Focus();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //Create New Company
            if (TxtCompany.Text != null)
            {
                Class1.AddPara("@comp_Name", TxtCompany.Text);
                Class1.ExecNonQuery("New_compamy");
                MessageBox.Show("تم انشاء شركة جديدة", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable DT = Class1.ExecQuery("Company_Select_all");
                CmList.DataSource = DT;
                CmList.Refresh();
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لحفظها", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        
        private void CmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (CmList.SelectedValue != null)
            {
                LblId.Text = CmList.SelectedValue.ToString();
                TxtCompany.Text = CmList.Text;
            }
            
            
        }

        private void CmList_MouseClick(object sender, MouseEventArgs e)
        {
            CmaDel.Enabled = true;
            CmdUpdate.Enabled = true;
        }

        
        private void CmList_Validated(object sender, EventArgs e)
        {
            
            if (CmList.SelectedValue != null)
            {
                LblId.Text = CmList.SelectedValue.ToString();
                TxtCompany.Text = CmList.Text;
            }
            else
            {
                MessageBox.Show("هذه الشركة غير متاحة");
            }
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            //Update Company

            if (TxtCompany.Text != null)
            {
                Class1.AddPara("@comName", TxtCompany.Text);
                Class1.AddPara("@ComId", LblId.Text);
                Class1.ExecNonQuery("ComUpdate");
                MessageBox.Show("تم تعديل البيانات بنجاح", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmdUpdate.Enabled = false;
                Class1.CMD.Parameters.Clear();
            }
            else
            {
                MessageBox.Show("لا يوجد بيانات لتعديلها", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
