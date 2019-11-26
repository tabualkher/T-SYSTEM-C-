namespace T
{
    partial class FrmTreeOfAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeOfAccount));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsNew = new System.Windows.Forms.ToolStripSplitButton();
            this.TsMain = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSave = new System.Windows.Forms.ToolStripButton();
            this.TsUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsDel = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkCash = new System.Windows.Forms.CheckBox();
            this.RbIncome = new System.Windows.Forms.RadioButton();
            this.RbBsheet = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TxtAccName = new System.Windows.Forms.TextBox();
            this.LblLevel = new System.Windows.Forms.LinkLabel();
            this.LblAcc1 = new System.Windows.Forms.LinkLabel();
            this.LblAcc2 = new System.Windows.Forms.LinkLabel();
            this.LblAcc3 = new System.Windows.Forms.LinkLabel();
            this.LblAcc4 = new System.Windows.Forms.LinkLabel();
            this.TxtBbal = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblPath = new System.Windows.Forms.Label();
            this.LblAccNo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsNew,
            this.TsSave,
            this.TsUpdate,
            this.toolStripSeparator1,
            this.TsDel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(732, 39);
            this.toolStrip.TabIndex = 12;
            this.toolStrip.Text = "ToolStrip";
            // 
            // TsNew
            // 
            this.TsNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsMain,
            this.TsBranch});
            this.TsNew.Enabled = false;
            this.TsNew.Image = ((System.Drawing.Image)(resources.GetObject("TsNew.Image")));
            this.TsNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.TsNew.Name = "TsNew";
            this.TsNew.Size = new System.Drawing.Size(151, 36);
            this.TsNew.Text = "اضافة حساب جديد";
            this.TsNew.ButtonClick += new System.EventHandler(this.TsNew_ButtonClick);
            this.TsNew.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // TsMain
            // 
            this.TsMain.Name = "TsMain";
            this.TsMain.Size = new System.Drawing.Size(180, 24);
            this.TsMain.Text = "حساب رئيسى";
            this.TsMain.Click += new System.EventHandler(this.TsMain_Click);
            // 
            // TsBranch
            // 
            this.TsBranch.Name = "TsBranch";
            this.TsBranch.Size = new System.Drawing.Size(180, 24);
            this.TsBranch.Text = "حساب فرعى";
            this.TsBranch.Click += new System.EventHandler(this.TsBranch_Click);
            // 
            // TsSave
            // 
            this.TsSave.Enabled = false;
            this.TsSave.Image = ((System.Drawing.Image)(resources.GetObject("TsSave.Image")));
            this.TsSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.TsSave.Name = "TsSave";
            this.TsSave.Size = new System.Drawing.Size(66, 36);
            this.TsSave.Text = "حفظ";
            this.TsSave.Click += new System.EventHandler(this.TsSave_Click);
            // 
            // TsUpdate
            // 
            this.TsUpdate.Enabled = false;
            this.TsUpdate.Image = ((System.Drawing.Image)(resources.GetObject("TsUpdate.Image")));
            this.TsUpdate.ImageTransparentColor = System.Drawing.Color.Black;
            this.TsUpdate.Name = "TsUpdate";
            this.TsUpdate.Size = new System.Drawing.Size(71, 36);
            this.TsUpdate.Text = "تعديل";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // TsDel
            // 
            this.TsDel.Enabled = false;
            this.TsDel.Image = ((System.Drawing.Image)(resources.GetObject("TsDel.Image")));
            this.TsDel.ImageTransparentColor = System.Drawing.Color.Black;
            this.TsDel.Name = "TsDel";
            this.TsDel.Size = new System.Drawing.Size(70, 36);
            this.TsDel.Text = "حذف";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkCash);
            this.groupBox1.Controls.Add(this.RbIncome);
            this.groupBox1.Controls.Add(this.RbBsheet);
            this.groupBox1.Location = new System.Drawing.Point(338, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 58);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // ChkCash
            // 
            this.ChkCash.AutoSize = true;
            this.ChkCash.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCash.ForeColor = System.Drawing.Color.Blue;
            this.ChkCash.Location = new System.Drawing.Point(23, 19);
            this.ChkCash.Name = "ChkCash";
            this.ChkCash.Size = new System.Drawing.Size(76, 23);
            this.ChkCash.TabIndex = 25;
            this.ChkCash.Text = "غير نقدى";
            this.ChkCash.UseVisualStyleBackColor = true;
            // 
            // RbIncome
            // 
            this.RbIncome.AutoSize = true;
            this.RbIncome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbIncome.ForeColor = System.Drawing.Color.Red;
            this.RbIncome.Location = new System.Drawing.Point(126, 19);
            this.RbIncome.Name = "RbIncome";
            this.RbIncome.Size = new System.Drawing.Size(86, 23);
            this.RbIncome.TabIndex = 1;
            this.RbIncome.TabStop = true;
            this.RbIncome.Text = "قائمة الدخل";
            this.RbIncome.UseVisualStyleBackColor = true;
            // 
            // RbBsheet
            // 
            this.RbBsheet.AutoSize = true;
            this.RbBsheet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbBsheet.ForeColor = System.Drawing.Color.Red;
            this.RbBsheet.Location = new System.Drawing.Point(236, 19);
            this.RbBsheet.Name = "RbBsheet";
            this.RbBsheet.Size = new System.Drawing.Size(129, 23);
            this.RbBsheet.TabIndex = 0;
            this.RbBsheet.TabStop = true;
            this.RbBsheet.Text = "قائمة المركز المالى";
            this.RbBsheet.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TxtAccName
            // 
            this.TxtAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccName.Location = new System.Drawing.Point(6, 66);
            this.TxtAccName.Multiline = true;
            this.TxtAccName.Name = "TxtAccName";
            this.TxtAccName.Size = new System.Drawing.Size(370, 30);
            this.TxtAccName.TabIndex = 13;
            this.TxtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TxtAccName, "اسم الفرع");
            this.TxtAccName.WordWrap = false;
            // 
            // LblLevel
            // 
            this.LblLevel.BackColor = System.Drawing.Color.White;
            this.LblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblLevel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLevel.ForeColor = System.Drawing.Color.Blue;
            this.LblLevel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblLevel.Location = new System.Drawing.Point(6, 33);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(50, 30);
            this.LblLevel.TabIndex = 14;
            this.LblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LblLevel, "كود الشركة");
            // 
            // LblAcc1
            // 
            this.LblAcc1.BackColor = System.Drawing.Color.White;
            this.LblAcc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAcc1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcc1.ForeColor = System.Drawing.Color.Blue;
            this.LblAcc1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblAcc1.Location = new System.Drawing.Point(62, 33);
            this.LblAcc1.Name = "LblAcc1";
            this.LblAcc1.Size = new System.Drawing.Size(50, 30);
            this.LblAcc1.TabIndex = 15;
            this.LblAcc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LblAcc1, "كود الشركة");
            // 
            // LblAcc2
            // 
            this.LblAcc2.BackColor = System.Drawing.Color.White;
            this.LblAcc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAcc2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcc2.ForeColor = System.Drawing.Color.Blue;
            this.LblAcc2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblAcc2.Location = new System.Drawing.Point(118, 33);
            this.LblAcc2.Name = "LblAcc2";
            this.LblAcc2.Size = new System.Drawing.Size(66, 30);
            this.LblAcc2.TabIndex = 16;
            this.LblAcc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LblAcc2, "كود الشركة");
            // 
            // LblAcc3
            // 
            this.LblAcc3.BackColor = System.Drawing.Color.White;
            this.LblAcc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAcc3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcc3.ForeColor = System.Drawing.Color.Blue;
            this.LblAcc3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblAcc3.Location = new System.Drawing.Point(190, 33);
            this.LblAcc3.Name = "LblAcc3";
            this.LblAcc3.Size = new System.Drawing.Size(66, 30);
            this.LblAcc3.TabIndex = 17;
            this.LblAcc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LblAcc3, "كود الشركة");
            // 
            // LblAcc4
            // 
            this.LblAcc4.BackColor = System.Drawing.Color.White;
            this.LblAcc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAcc4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAcc4.ForeColor = System.Drawing.Color.Blue;
            this.LblAcc4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LblAcc4.Location = new System.Drawing.Point(262, 33);
            this.LblAcc4.Name = "LblAcc4";
            this.LblAcc4.Size = new System.Drawing.Size(114, 30);
            this.LblAcc4.TabIndex = 18;
            this.LblAcc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LblAcc4, "كود الشركة");
            // 
            // TxtBbal
            // 
            this.TxtBbal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBbal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBbal.Location = new System.Drawing.Point(6, 25);
            this.TxtBbal.Multiline = true;
            this.TxtBbal.Name = "TxtBbal";
            this.TxtBbal.Size = new System.Drawing.Size(370, 30);
            this.TxtBbal.TabIndex = 13;
            this.TxtBbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TxtBbal, "اسم الفرع");
            this.TxtBbal.WordWrap = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.Size = new System.Drawing.Size(294, 346);
            this.treeView1.TabIndex = 29;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblPath);
            this.groupBox2.Controls.Add(this.LblAccNo);
            this.groupBox2.Controls.Add(this.LblAcc4);
            this.groupBox2.Controls.Add(this.LblAcc3);
            this.groupBox2.Controls.Add(this.LblAcc2);
            this.groupBox2.Controls.Add(this.LblAcc1);
            this.groupBox2.Controls.Add(this.LblLevel);
            this.groupBox2.Controls.Add(this.TxtAccName);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(338, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 117);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الحساب";
            // 
            // LblPath
            // 
            this.LblPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPath.ForeColor = System.Drawing.Color.Red;
            this.LblPath.Location = new System.Drawing.Point(6, 99);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(370, 15);
            this.LblPath.TabIndex = 37;
            this.LblPath.Text = "L";
            // 
            // LblAccNo
            // 
            this.LblAccNo.AutoSize = true;
            this.LblAccNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAccNo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccNo.ForeColor = System.Drawing.Color.Red;
            this.LblAccNo.Location = new System.Drawing.Point(236, 0);
            this.LblAccNo.Name = "LblAccNo";
            this.LblAccNo.Size = new System.Drawing.Size(16, 16);
            this.LblAccNo.TabIndex = 32;
            this.LblAccNo.Text = "L";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtBbal);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(338, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(382, 70);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الرصيد الافتتاحى";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(244, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "الغاء";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTreeOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTreeOfAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدليل المحاسبى";
            this.Load += new System.EventHandler(this.FrmTreeOfAccount_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsSave;
        private System.Windows.Forms.ToolStripButton TsUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkCash;
        private System.Windows.Forms.RadioButton RbIncome;
        private System.Windows.Forms.RadioButton RbBsheet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel LblLevel;
        private System.Windows.Forms.TextBox TxtAccName;
        private System.Windows.Forms.Label LblAccNo;
        private System.Windows.Forms.LinkLabel LblAcc4;
        private System.Windows.Forms.LinkLabel LblAcc3;
        private System.Windows.Forms.LinkLabel LblAcc2;
        private System.Windows.Forms.LinkLabel LblAcc1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtBbal;
        private System.Windows.Forms.Label LblPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripSplitButton TsNew;
        private System.Windows.Forms.ToolStripMenuItem TsMain;
        private System.Windows.Forms.ToolStripMenuItem TsBranch;
    }
}