namespace T
{
    partial class FrmFiscalYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiscalYear));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.CmdNew = new System.Windows.Forms.ToolStripButton();
            this.CmdSave = new System.Windows.Forms.ToolStripButton();
            this.CmdUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdDel = new System.Windows.Forms.ToolStripButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtYearName = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.LinkLabel();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.CmList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.CmdNew,
            this.CmdSave,
            this.CmdUpdate,
            this.toolStripSeparator1,
            this.CmdDel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 39);
            this.toolStrip.TabIndex = 11;
            this.toolStrip.Text = "ToolStrip";
            // 
            // CmdNew
            // 
            this.CmdNew.Image = ((System.Drawing.Image)(resources.GetObject("CmdNew.Image")));
            this.CmdNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(67, 36);
            this.CmdNew.Text = "جديد";
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
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Enabled = false;
            this.CmdUpdate.Image = ((System.Drawing.Image)(resources.GetObject("CmdUpdate.Image")));
            this.CmdUpdate.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(71, 36);
            this.CmdUpdate.Text = "تعديل";
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // CmdDel
            // 
            this.CmdDel.Enabled = false;
            this.CmdDel.Image = ((System.Drawing.Image)(resources.GetObject("CmdDel.Image")));
            this.CmdDel.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdDel.Name = "CmdDel";
            this.CmdDel.Size = new System.Drawing.Size(70, 36);
            this.CmdDel.Text = "حذف";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(711, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // TxtYearName
            // 
            this.TxtYearName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtYearName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearName.Location = new System.Drawing.Point(18, 26);
            this.TxtYearName.Multiline = true;
            this.TxtYearName.Name = "TxtYearName";
            this.TxtYearName.Size = new System.Drawing.Size(411, 30);
            this.TxtYearName.TabIndex = 13;
            this.TxtYearName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtYearName.WordWrap = false;
            // 
            // LblId
            // 
            this.LblId.BackColor = System.Drawing.Color.White;
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.Blue;
            this.LblId.LinkColor = System.Drawing.Color.Blue;
            this.LblId.Location = new System.Drawing.Point(18, 26);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(55, 30);
            this.LblId.TabIndex = 12;
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DtFrom
            // 
            this.DtFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFrom.Location = new System.Drawing.Point(13, 25);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(296, 22);
            this.DtFrom.TabIndex = 17;
            // 
            // CmList
            // 
            this.CmList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CmList.FormattingEnabled = true;
            this.CmList.Location = new System.Drawing.Point(35, 53);
            this.CmList.Name = "CmList";
            this.CmList.Size = new System.Drawing.Size(245, 287);
            this.CmList.TabIndex = 19;
            this.CmList.SelectedIndexChanged += new System.EventHandler(this.CmList_SelectedIndexChanged);
            this.CmList.Click += new System.EventHandler(this.CmList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.TxtYearName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(302, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 72);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات السنة المالية";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtFrom);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(357, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 65);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "من";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtTo);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(357, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 65);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الى";
            // 
            // DtTo
            // 
            this.DtTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTo.Location = new System.Drawing.Point(13, 25);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(296, 22);
            this.DtTo.TabIndex = 17;
            // 
            // FrmFiscalYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmList);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFiscalYear";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "السنة المالية";
            this.Load += new System.EventHandler(this.FrmFiscalYear_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton CmdNew;
        private System.Windows.Forms.ToolStripButton CmdSave;
        private System.Windows.Forms.ToolStripButton CmdUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CmdDel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtYearName;
        private System.Windows.Forms.LinkLabel LblId;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.ComboBox CmList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DtTo;
    }
}