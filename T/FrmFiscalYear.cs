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
    public partial class FrmFiscalYear : Form
    {
        public FrmFiscalYear()
        {
            InitializeComponent();
        }

        MDIParent1 mdiparent1 = new MDIParent1();
        
        private void CmdNew_Click(object sender, EventArgs e)
        {
            TxtYearName.Text = "";
            CmdSave.Enabled = true;
            CmList.Enabled = false;
            CmdNew.Enabled = false;
            CmdUpdate.Enabled = false;
            CmdDel.Enabled = false;

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@FYN", TxtYearName.Text);
            Class1.AddPara("@ST", DtFrom.Value.Date.ToString());
            Class1.AddPara("@ED", DtTo.Value.Date.ToString());
            mdiparent1.FtsCompanyId.Text = "1";
            Class1.AddPara("@CI", mdiparent1.FtsCompanyId.Text);
            Class1.ExecNonQuery("FiscalYearNew");
            
            MessageBox.Show("تم تاسيس سنة مالية جديدة", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtYearName.Text = "";
            CmdSave.Enabled = false;
            CmList.Enabled = true;
            CmdNew.Enabled = true;
        }

        private void FrmFiscalYear_Load(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            DataTable Dt = new DataTable();
            mdiparent1.FtsCompanyId.Text = "1";
            Class1.AddPara("@compId", mdiparent1.FtsCompanyId.Text);
            Dt = Class1.ExecQuery("FiscalYearSearchByCompany");
            CmList.DataSource = Dt;
            CmList.ValueMember = Dt.Columns[0].ToString();
            CmList.DisplayMember = Dt.Columns[1].ToString();

        }

        
        private void CmList_Click(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            DataTable Dt = new DataTable();
            Class1.AddPara("@YearId", CmList.SelectedValue.ToString());
            Dt = Class1.ExecQuery("FiscalYearSearchById");
            TxtYearName.Text = Dt.Rows[0][1].ToString();
            LblId.Text = Dt.Rows[0][0].ToString();
            DtFrom.Text = Dt.Rows[0][2].ToString();
            DtTo.Text = Dt.Rows[0][3].ToString();
            CmdUpdate.Enabled = true;
            CmdDel.Enabled = true;

        }

        private void CmList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
