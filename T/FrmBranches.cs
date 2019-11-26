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
    public partial class FrmBranches : Form
    {


        DataTable DT = Class1.ExecQuery("Company_Select_all");

        public FrmBranches()
        {
            InitializeComponent();
            Class1.IsAdmin = false;

        }

        MDIParent1 mDIParent1 = new MDIParent1();

        private void FrmBranches_Load(object sender, EventArgs e)
        {

            CmCompany.DataSource = DT;
            CmCompany.ValueMember = DT.Columns[0].ToString();
            CmCompany.DisplayMember = DT.Columns[1].ToString();
            int i = 0;
            int R = 0;
            if (Class1.IsAdmin == true)
            {
                DT = Class1.ExecQuery("CompBr");


                for (i = 0; i < DT.Rows.Count; i++)
                {

                    if (i == 0)
                    {
                        TrBranch.Nodes.Add(DT.Rows[i][0].ToString());
                        TrBranch.Nodes[i].Nodes.Add(DT.Rows[i][2].ToString() + " - " + DT.Rows[i][1].ToString());

                    }
                    else
                    {
                        if (DT.Rows[i][0].ToString() != TrBranch.Nodes[R].Text)
                        {
                            R += 1;
                            TrBranch.Nodes.Add(DT.Rows[i][0].ToString());
                            TrBranch.Nodes[R].Nodes.Add(DT.Rows[i][2].ToString() + " - " + DT.Rows[i][1].ToString());

                        }
                        else
                        {

                            TrBranch.Nodes[R].Nodes.Add(DT.Rows[i][2].ToString() + " - " + DT.Rows[i][1].ToString());
                        }
                    }
                }
            }
            else
            {

                Class1.AddPara("@compId", mDIParent1.FtsCompanyId.Text);
                DT = Class1.ExecQuery("CompBr2");
                Class1.CMD.Parameters.Clear();

                for (i = 0; i < DT.Rows.Count; i++)
                {

                    if (i == 0)
                    {
                        TrBranch.Nodes.Add(DT.Rows[i][0].ToString());
                        TrBranch.Nodes[i].Nodes.Add(DT.Rows[i][2].ToString() + " - " + DT.Rows[i][1].ToString());
                    }
                    else
                    {
                        TrBranch.Nodes[R].Nodes.Add(DT.Rows[i][2].ToString() + " - " + DT.Rows[i][1].ToString());
                    }

                }
            }
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            Class1.IsAdmin = false;
            if (Class1.IsAdmin == true)
            {
                CmCompany.Visible = true;
                groupBox2.Visible = true;
                LblId.Text = "";
                TxtBranch.Text = "";
                CmdSave.Enabled = true;
            }
            else
            {
                LblId.Text = "";
                TxtBranch.Text = "";
                CmdSave.Enabled = true;
            }



        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //Create New Branch
            if (Class1.IsAdmin == true)
            {
                Class1.AddPara("@CompId", CmCompany.SelectedValue.ToString());
                Class1.AddPara("@BranchName", TxtBranch.Text);
                Class1.ExecNonQuery("Branch_New");
                MessageBox.Show("تم انشاء فرع جديد", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.CMD.Parameters.Clear();
            }
            else
            {

                Class1.AddPara("@CompId", Class1.CompanyId.ToString());
                Class1.AddPara("@BranchName", TxtBranch.Text);
                Class1.ExecNonQuery("Branch_New");
                MessageBox.Show("تم انشاء فرع جديد", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class1.CMD.Parameters.Clear();
            }


        }

        private void TrBranch_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                string A = TrBranch.SelectedNode.Text.Substring(0, 1);
                if (char.IsNumber(A , 0))
                {
                    Class1.AddPara("@BranchName", TrBranch.SelectedNode.Text.Substring(0, 2));
                    DataTable DT = Class1.ExecQuery("CompBr1");
                    if (DT.Rows.Count is 0)
                    {
                        Class1.CMD.Parameters.Clear();
                        return;
                    }
                    LblId.Text = DT.Rows[0][0].ToString();
                    TxtBranch.Text = DT.Rows[0][1].ToString();
                    LblCompId.Text = DT.Rows[0][2].ToString();
                    Class1.CMD.Parameters.Clear();
                    CmaEdit.Enabled = true;

                }
            }
            catch (ApplicationException)
            {
                MessageBox.Show("Err");
                Application.ExitThread();
                throw;
            }
        } 
                
                    

        private void CmaEdit_Click(object sender, EventArgs e)
        {
            Class1.AddPara("@BranchId", LblId.Text);
            Class1.AddPara("@branchName", TxtBranch.Text);
            Class1.ExecNonQuery("BranchUpdate");
            MessageBox.Show("تم تحديث بيانات الفرع", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CmaEdit.Enabled = false;
            Class1.CMD.Parameters.Clear();
        }

        private void TrBranch_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
