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
    public partial class FrmCostCenter : Form
    {
        public FrmCostCenter()
        {
            InitializeComponent();
        }

        MDIParent1 mdiparent1 = new MDIParent1();
        private void CmdNew_Click(object sender, EventArgs e)
        {
            TxtCostName.Text = "";
            CmdSave.Enabled = true;
            CmList.Enabled = false;
            CmdNew.Enabled = false;
            CmdUpdate.Enabled = false;
            CmdDel.Enabled = false;

        }

        private void FrmCostCenter_Load(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            DataTable Dt = new DataTable();
            mdiparent1.FtsCompanyId.Text = "1";
            Class1.AddPara("@comId", mdiparent1.FtsCompanyId.Text);
            Dt = Class1.ExecQuery("CostCenterSelectByCompanyId");
            CmList.DataSource = Dt;
            CmList.ValueMember = Dt.Columns[0].ToString();
            CmList.DisplayMember = Dt.Columns[1].ToString();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@CName", TxtCostName.Text);
            Class1.AddPara("@ComId", mdiparent1.FtsCompanyId.Text);
            Class1.AddPara("@FId", mdiparent1.FtsFiscalYear.Text);
            mdiparent1.FtsCompanyId.Text = "1";
            Class1.ExecNonQuery("CostCenterNew");

            MessageBox.Show("تم تاسيس مركز تكلفة جديدة", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtCostName.Text = "";
            CmdSave.Enabled = false;
            CmList.Enabled = true;
            CmdNew.Enabled = true;
        }

        
        private void CmList_Click(object sender, EventArgs e)
        {
            
            Class1.CMD.Parameters.Clear();
            DataTable Dt = new DataTable();
            Class1.AddPara("@comId", "1");
            Class1.AddPara("@CostId", CmList.SelectedValue.ToString());
            Dt = Class1.ExecQuery("CostCenterFindByCostName");
            if (Dt.Rows.Count != 0)
            {
                TxtCostName.Text = Dt.Rows[0][1].ToString();
                LblId.Text = Dt.Rows[0][0].ToString();
                CmdUpdate.Enabled = true;
                CmdDel.Enabled = true;
            }
            

        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@CostName", TxtCostName.Text);
            Class1.AddPara("@CostId", LblId.Text);
            Class1.ExecNonQuery("CostUpdate");
            MessageBox.Show("تم تعديل مركز التكلفة", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CmdUpdate.Enabled = false;
            CmdDel.Enabled = false;
            CmdSave.Enabled = false;
            CmdNew.Enabled = true;
            CmList.Enabled = true;
        }
    }
}
