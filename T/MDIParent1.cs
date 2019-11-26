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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void TsChart_Click(object sender, EventArgs e)
        {
            FrmTreeOfAccount frmTreeOfAccount = new FrmTreeOfAccount();
            frmTreeOfAccount.MdiParent = MDIParent1.ActiveForm;
            frmTreeOfAccount.Show();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
            
            FTsDate.Text = DateTime.Now.Date.ToShortDateString();
            FtsUserName.Text = Class1.UserName;
            FtsUserId.Text = Class1.UserId.ToString();
            FtsCompanyName.Text = Class1.CompanyName;
            FtsCompanyId.Text = Class1.CompanyId.ToString();
            FtsBranchId.Text = Class1.BranchId.ToString();
            FtsBranchName.Text = Class1.BranchName;

            FtsCompanyId.Text = "1";
            FtsBranchId.Text = "1";
            

            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
            
        }

        private void TsCompanies_Click(object sender, EventArgs e)
        {
            FrmCompany frmcompany = new FrmCompany();
            frmcompany.MdiParent = MDIParent1.ActiveForm;
            frmcompany.Show();
        }

        private void TsBranchies_Click(object sender, EventArgs e)
        {
            FrmBranches frmBranches = new FrmBranches();
            frmBranches.MdiParent = MDIParent1.ActiveForm;
            frmBranches.Show();
        }

        private void TsFiscalYear_Click(object sender, EventArgs e)
        {
            FrmFiscalYear frmfiscalyear = new FrmFiscalYear();
            frmfiscalyear.MdiParent = MDIParent1.ActiveForm;
            frmfiscalyear.Show();
        }

        private void TsCostCenter_Click(object sender, EventArgs e)
        {
            FrmCostCenter frmCostCenter = new FrmCostCenter();
            frmCostCenter.MdiParent = MDIParent1.ActiveForm;
            frmCostCenter.Show();
        }

        private void TsBooks_Click(object sender, EventArgs e)
        {
            FrmJournalType frmJournalType = new FrmJournalType();
            frmJournalType.MdiParent = MDIParent1.ActiveForm;
            frmJournalType.Show();
        }

        private void TsEntry_Click(object sender, EventArgs e)
        {
            FrmJournalEntry frmJournalEntry = new FrmJournalEntry();
            frmJournalEntry.MdiParent = MDIParent1.ActiveForm;
            frmJournalEntry.Show();
        }

        private void TsPayCash_Click(object sender, EventArgs e)
        {
            FrmCashPay frmCashPay = new FrmCashPay();
            frmCashPay.MdiParent = MDIParent1.ActiveForm;
            frmCashPay.Show();
        }

        private void TsReceiveCash_Click(object sender, EventArgs e)
        {
            FrmCashReceived frmCashReceived = new FrmCashReceived();
            frmCashReceived.MdiParent = MDIParent1.ActiveForm;
            frmCashReceived.Show();
        }

        private void TsPayCheque_Click(object sender, EventArgs e)
        {
            FrmPayCheque frmPayCheque = new FrmPayCheque();
            frmPayCheque.MdiParent = MDIParent1.ActiveForm;
            frmPayCheque.Show();
        }

        private void TsReceiveCheque_Click(object sender, EventArgs e)
        {
            FrmRecivedCheque frmRecivedCheque = new FrmRecivedCheque();
            frmRecivedCheque.MdiParent = MDIParent1.ActiveForm;
            frmRecivedCheque.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
