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
    public partial class FrmJournalType : Form
    {
        public FrmJournalType()
        {
            InitializeComponent();
        }

        MDIParent1 mdiparent1 = new MDIParent1();
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            TxtTypeName.Text = "";
            CmdSave.Enabled = true;
            CmList.Enabled = false;
            CmdNew.Enabled = false;
            CmdUpdate.Enabled = false;
            CmdDel.Enabled = false;
        }

        private void FrmJournalType_Load(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            DataTable Dt = new DataTable();
            mdiparent1.FtsCompanyId.Text = "1";
            Class1.AddPara("@comId", mdiparent1.FtsCompanyId.Text);
            Class1.AddPara("@Fid", mdiparent1.FtsFiscalYear.Text);
            Dt = Class1.ExecQuery("DocTypeSearchByComId");
            CmList.DataSource = Dt;
            CmList.ValueMember = Dt.Columns[0].ToString();
            CmList.DisplayMember = Dt.Columns[1].ToString();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@TypeName", TxtTypeName.Text);
            Class1.AddPara("@ComId", mdiparent1.FtsCompanyId.Text);
            Class1.AddPara("@Fis", mdiparent1.FtsFiscalYear.Text);
            mdiparent1.FtsCompanyId.Text = "1";
            Class1.ExecNonQuery("DocTypeNew");

            MessageBox.Show("تم تاسيس يومية جديدة", "T-System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtTypeName.Text = "";
            CmdSave.Enabled = false;
            CmList.Enabled = true;
            CmdNew.Enabled = true;
        }

        private void CmList_Click(object sender, EventArgs e)
        {
            TxtTypeName.Text = CmList.SelectedText;
            LblId.Text = CmList.SelectedValue.ToString();
            CmdSave.Enabled = false;
            CmdUpdate.Enabled = false;
            CmdDel.Enabled = false;
        }
    }
}
