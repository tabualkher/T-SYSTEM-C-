namespace T
{
    partial class FrmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompany));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.CmdNew = new System.Windows.Forms.ToolStripButton();
            this.CmdSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdUpdate = new System.Windows.Forms.ToolStripButton();
            this.CmaDel = new System.Windows.Forms.ToolStripButton();
            this.LblId = new System.Windows.Forms.LinkLabel();
            this.TxtCompany = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.CmList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdNew,
            this.CmdSave,
            this.toolStripSeparator1,
            this.CmdUpdate,
            this.CmaDel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(683, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "ToolStrip";
            // 
            // CmdNew
            // 
            this.CmdNew.Image = ((System.Drawing.Image)(resources.GetObject("CmdNew.Image")));
            this.CmdNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(67, 36);
            this.CmdNew.Text = "جديد";
            this.CmdNew.ToolTipText = "انشاء شركة جديدة";
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Enabled = false;
            this.CmdSave.Image = ((System.Drawing.Image)(resources.GetObject("CmdSave.Image")));
            this.CmdSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(66, 36);
            this.CmdSave.Text = "حفظ";
            this.CmdSave.ToolTipText = "حفظ بيانات الشركة";
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Enabled = false;
            this.CmdUpdate.Image = ((System.Drawing.Image)(resources.GetObject("CmdUpdate.Image")));
            this.CmdUpdate.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(71, 36);
            this.CmdUpdate.Text = "تعديل";
            this.CmdUpdate.ToolTipText = "تعديل بيانات الشركة الحالية";
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmaDel
            // 
            this.CmaDel.Enabled = false;
            this.CmaDel.Image = ((System.Drawing.Image)(resources.GetObject("CmaDel.Image")));
            this.CmaDel.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmaDel.Name = "CmaDel";
            this.CmaDel.Size = new System.Drawing.Size(70, 36);
            this.CmaDel.Text = "حذف";
            this.CmaDel.ToolTipText = "حذف بيانات الشركة الحالية";
            // 
            // LblId
            // 
            this.LblId.BackColor = System.Drawing.Color.White;
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.Blue;
            this.LblId.LinkColor = System.Drawing.Color.Red;
            this.LblId.Location = new System.Drawing.Point(23, 26);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(58, 32);
            this.LblId.TabIndex = 4;
            this.LblId.TabStop = true;
            this.LblId.Text = "ID";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.LblId, "كود الشركة");
            // 
            // TxtCompany
            // 
            this.TxtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCompany.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpKeyword(this.TxtCompany, "mnmnmnn");
            this.TxtCompany.Location = new System.Drawing.Point(23, 28);
            this.TxtCompany.Multiline = true;
            this.TxtCompany.Name = "TxtCompany";
            this.helpProvider1.SetShowHelp(this.TxtCompany, true);
            this.TxtCompany.Size = new System.Drawing.Size(368, 30);
            this.TxtCompany.TabIndex = 5;
            this.TxtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.TxtCompany, "اسم الشركة");
            this.TxtCompany.WordWrap = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(627, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // CmList
            // 
            this.CmList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CmList.FormattingEnabled = true;
            this.CmList.Location = new System.Drawing.Point(12, 57);
            this.CmList.Name = "CmList";
            this.CmList.Size = new System.Drawing.Size(245, 239);
            this.CmList.TabIndex = 12;
            this.CmList.SelectedIndexChanged += new System.EventHandler(this.CmList_SelectedIndexChanged);
            this.CmList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmList_MouseClick);
            this.CmList.Validated += new System.EventHandler(this.CmList_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.TxtCompany);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(263, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 79);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الشركة";
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 311);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmList);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCompany";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الشركات";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton CmdNew;
        private System.Windows.Forms.ToolStripButton CmdUpdate;
        private System.Windows.Forms.ToolStripButton CmdSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CmaDel;
        private System.Windows.Forms.LinkLabel LblId;
        private System.Windows.Forms.TextBox TxtCompany;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox CmList;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}