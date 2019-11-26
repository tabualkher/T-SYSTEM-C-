namespace T
{
    partial class FrmJournalType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJournalType));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.CmdNew = new System.Windows.Forms.ToolStripButton();
            this.CmdSave = new System.Windows.Forms.ToolStripButton();
            this.CmdUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CmdDel = new System.Windows.Forms.ToolStripButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CmList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblId = new System.Windows.Forms.LinkLabel();
            this.TxtTypeName = new System.Windows.Forms.TextBox();
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
            this.CmdUpdate,
            this.toolStripSeparator1,
            this.CmdDel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(737, 39);
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
            this.CmdNew.Click += new System.EventHandler(this.newToolStripButton_Click);
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
            this.pictureBox3.Location = new System.Drawing.Point(650, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // CmList
            // 
            this.CmList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmList.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CmList.FormattingEnabled = true;
            this.CmList.Location = new System.Drawing.Point(16, 48);
            this.CmList.Name = "CmList";
            this.CmList.Size = new System.Drawing.Size(245, 287);
            this.CmList.TabIndex = 21;
            this.CmList.Click += new System.EventHandler(this.CmList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.TxtTypeName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(281, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 72);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات اليومية";
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
            // TxtTypeName
            // 
            this.TxtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTypeName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTypeName.Location = new System.Drawing.Point(18, 26);
            this.TxtTypeName.Multiline = true;
            this.TxtTypeName.Name = "TxtTypeName";
            this.TxtTypeName.Size = new System.Drawing.Size(411, 30);
            this.TxtTypeName.TabIndex = 13;
            this.TxtTypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTypeName.WordWrap = false;
            // 
            // FrmJournalType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmList);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmJournalType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اليومية";
            this.Load += new System.EventHandler(this.FrmJournalType_Load);
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
        private System.Windows.Forms.ToolStripButton CmdSave;
        private System.Windows.Forms.ToolStripButton CmdUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CmdDel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox CmList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel LblId;
        private System.Windows.Forms.TextBox TxtTypeName;
    }
}