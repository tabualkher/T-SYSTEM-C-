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
    public partial class FrmTreeOfAccount : Form
    {
        public FrmTreeOfAccount()
        {
            InitializeComponent();
        }

        MDIParent1 mDIParent1 = new MDIParent1();
        private void FrmTreeOfAccount_Load(object sender, EventArgs e)
        {

            Class1.FiscalYear = 2019;
            Class1.CompanyId = 1;
                Class1.CMD.Parameters.Clear();
                DataTable DT = new DataTable();
                Class1.AddPara("@compId", mDIParent1.FtsCompanyId.Text);
                Class1.AddPara("@Fis", mDIParent1.FtsFiscalYear.Text);
                DT = Class1.ExecQuery("TreeSelectByCompIdFiscalId");
                                   
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    string A = DT.Rows[i][5].ToString();
                    string B = DT.Rows[i][4].ToString();
                    string C1= DT.Rows[i][0].ToString();
                    string C2 = DT.Rows[i][1].ToString();
                    string C3 = DT.Rows[i][2].ToString();
                    string D = DT.Rows[i][6].ToString();

                switch (int.Parse(A))
                {
                    case 0:
                        treeView1.Nodes.Add(B);
                        break;

                    case 1:
                        treeView1.Nodes[int.Parse(C1) - 1].Nodes.Add(B);
                        break;

                    case 2:
                        treeView1.Nodes[int.Parse(C1) - 1].Nodes[int.Parse(C2) - 1].Nodes.Add(B);
                        break;

                    case 3:
                        treeView1.Nodes[int.Parse(C1) - 1].Nodes[int.Parse(C2) - 1].Nodes[int.Parse(C3) - 1].Nodes.Add(B);
                        break;

                }                
                
                }

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            DataTable DT = new DataTable();
            Class1.AddPara("@AccName", treeView1.SelectedNode.Text);
            DT = Class1.ExecQuery("ChartSearchByName");
            LblAcc1.Text = DT.Rows[0][0].ToString();
            LblAcc2.Text = DT.Rows[0][1].ToString();
            LblAcc3.Text = DT.Rows[0][2].ToString();
            LblAcc4.Text = DT.Rows[0][3].ToString();
            LblLevel.Text = DT.Rows[0][6].ToString();
            ChkCash.Checked = Boolean.Parse(DT.Rows[0][7].ToString());
            if (Boolean.Parse(DT.Rows[0][8].ToString()))
            {
                RbBsheet.Checked = true;
                RbIncome.Checked = false;
            }
            else
            {
                RbBsheet.Checked = false;
                RbIncome.Checked = true;
            }
            TxtBbal.Text = DT.Rows[0][9].ToString();
            TxtAccName.Text = DT.Rows[0][5].ToString();
            LblAccNo.Text= DT.Rows[0][4].ToString();
            LblPath.Text = treeView1.SelectedNode.FullPath;
            TsNew.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Enabled = true;
            TsNew.Enabled = true;
            TsSave.Enabled = false;
            button1.Visible = false;
            LblAcc1.Text = "";
            LblAcc2.Text = "";
            LblAcc3.Text = "";
            LblAcc4.Text = "";
            LblLevel.Text = "";
            LblPath.Text = "";
        }

        private void TsSave_Click(object sender, EventArgs e)
        {
            treeView1.Enabled = true;
            TsSave.Enabled = false;
            TsNew.Enabled = true;
            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@Acc1", LblAcc1.Text);
            Class1.AddPara("@Acc2", LblAcc2.Text);
            Class1.AddPara("@Acc3", LblAcc3.Text);
            Class1.AddPara("@Acc4", LblAcc4.Text);
            Class1.AddPara("@AccNo", LblAccNo.Text);
            Class1.AddPara("@AccName", LblAccNo.Text + " - " + TxtAccName.Text );
            Class1.AddPara("@AccLevel", LblLevel.Text);
            Class1.AddPara("@IsCash", ChkCash.Checked.ToString());
            Class1.AddPara("@IsBsheet", RbBsheet.Checked.ToString());
            Class1.AddPara("@BB", TxtBbal.Text);
            Class1.AddPara("@compId", Class1.CompanyId.ToString());
            Class1.AddPara("@Fy", Class1.FiscalYear.ToString());
            Class1.ExecNonQuery("ChartNew");
        }

        private void TsNew_ButtonClick(object sender, EventArgs e)
        {

        }

        private void TsMain_Click(object sender, EventArgs e)
        {
            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@AccLevel", LblLevel.Text);
            Class1.AddPara("@Acc1", LblAcc1.Text);
            Class1.AddPara("@Acc2", LblAcc2.Text);
            Class1.AddPara("@Acc3", LblAcc3.Text);
            Class1.AddPara("@Acc4", LblAcc4.Text);
            DataTable Dt = new DataTable();
            Dt = Class1.ExecQuery("TreeAccMax");
            button1.Visible = true;

            switch (LblLevel.Text)
            {
                case "0":
                    if (Dt.Rows[0][0].ToString() =="")
                    {
                        LblAcc1.Text = "1";
                    }
                    else
                    {
                        LblAcc1.Text = Dt.Rows[0][0].ToString();
                    }
                    
                    LblAcc2.Text = "0";
                    LblAcc3.Text = "0";
                    LblAcc4.Text = "0";
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;

                case "1":
                    if (Dt.Rows[0][1].ToString() =="")
                    {
                        LblAcc2.Text = "1";
                    }
                    else
                    {
                        LblAcc2.Text = Dt.Rows[0][1].ToString();
                    }
                    
                    LblAcc3.Text = "0";
                    LblAcc4.Text = "0";
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;

                case "2":
                    if (Dt.Rows[0][2].ToString() =="")
                    {
                        LblAcc3.Text = "1";
                    }
                    else
                    {
                        LblAcc3.Text = Dt.Rows[0][2].ToString();
                    }
                    
                    LblAcc4.Text = "0";
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;

                case "3":
                    if (Dt.Rows[0][3].ToString() =="")
                    {
                        LblAcc4.Text = "1";
                    }
                    else
                    {
                        LblAcc4.Text = Dt.Rows[0][3].ToString();
                    }
                    
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;
            }

            LblAccNo.Text = LblAcc1.Text + LblAcc2.Text + LblAcc3.Text + LblAcc4.Text;
            TxtAccName.Text = "";
        }

        private void TsBranch_Click(object sender, EventArgs e)
        {
             
            Class1.CMD.Parameters.Clear();
            Class1.AddPara("@AccLevel", LblLevel.Text);
            Class1.AddPara("@Acc1", LblAcc1.Text);
            Class1.AddPara("@Acc2", LblAcc2.Text);
            Class1.AddPara("@Acc3", LblAcc3.Text);
            Class1.AddPara("@Acc4", LblAcc4.Text);
            DataTable Dt = new DataTable();
            Dt = Class1.ExecQuery("TreeAccMax");
            button1.Visible = true;

            switch (LblLevel.Text)
            {
                case "0":
                    LblLevel.Text = (int.Parse(LblLevel.Text)+1).ToString();
                    if (Dt.Rows[0][1].ToString() =="")
                    {
                        LblAcc2.Text = "1";
                    }
                    else
                    {
                        LblAcc2.Text = Dt.Rows[0][1].ToString();
                    }
                    LblAcc3.Text = "0";
                    LblAcc4.Text = "0";
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;

                case "1":
                    LblLevel.Text = (int.Parse(LblLevel.Text) + 1).ToString();
                    if (Dt.Rows[0][2].ToString() =="")
                    {
                        LblAcc3.Text = "1";
                    }
                    else
                    {
                        LblAcc3.Text = Dt.Rows[0][2].ToString();
                    }
                    
                    LblAcc4.Text = "0";
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;

                case "2":
                    LblLevel.Text = (int.Parse(LblLevel.Text) + 1).ToString();
                    if (Dt.Rows[0][3].ToString() =="")
                    {
                        LblAcc4.Text = "1";
                    }
                    else
                    {
                        LblAcc4.Text = Dt.Rows[0][3].ToString();
                    }
                    
                    treeView1.Enabled = false;
                    TsSave.Enabled = true;
                    TsNew.Enabled = false;
                    break;
                                                       
            }

            LblAccNo.Text = LblAcc1.Text + LblAcc2.Text + LblAcc3.Text + LblAcc4.Text;
            TxtAccName.Text = "";
        }
    }
}
