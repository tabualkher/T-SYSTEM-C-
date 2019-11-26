namespace T
{
    partial class FrmCashPay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashPay));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LstCompanies = new System.Windows.Forms.ListView();
            this.LblId = new System.Windows.Forms.LinkLabel();
            this.CmaDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.CmaEdit = new System.Windows.Forms.ToolStripButton();
            this.CmdSave = new System.Windows.Forms.ToolStripButton();
            this.CmdNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Blue;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(332, 195);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(143, 21);
            this.linkLabel2.TabIndex = 62;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "0";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "مركز التكلفة";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "اسم الحساب";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "رقم الحساب";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(550, 117);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 21);
            this.linkLabel1.TabIndex = 60;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "0";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(38, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "المبلغ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Blue;
            this.maskedTextBox1.Location = new System.Drawing.Point(80, 196);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBox1.TabIndex = 58;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 180);
            this.dataGridView1.TabIndex = 57;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "المبلغ";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "الخزينة";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 117);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(464, 21);
            this.comboBox3.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(38, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "البيان";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(613, 20);
            this.textBox2.TabIndex = 53;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "اسم المستفيد";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(612, 20);
            this.textBox1.TabIndex = 51;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "تاريخ الاذن";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "رقم الاذن";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // LstCompanies
            // 
            this.LstCompanies.BackColor = System.Drawing.Color.White;
            this.LstCompanies.ForeColor = System.Drawing.Color.Yellow;
            this.LstCompanies.HideSelection = false;
            this.LstCompanies.Location = new System.Drawing.Point(699, 48);
            this.LstCompanies.Name = "LstCompanies";
            this.LstCompanies.Size = new System.Drawing.Size(73, 358);
            this.LstCompanies.TabIndex = 41;
            this.LstCompanies.UseCompatibleStateImageBehavior = false;
            // 
            // LblId
            // 
            this.LblId.BackColor = System.Drawing.Color.White;
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.Blue;
            this.LblId.LinkColor = System.Drawing.Color.Blue;
            this.LblId.Location = new System.Drawing.Point(80, 61);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(108, 27);
            this.LblId.TabIndex = 40;
            this.LblId.TabStop = true;
            this.LblId.Text = "ID";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Pic1
            // 
            this.Pic1.Image = ((System.Drawing.Image)(resources.GetObject("Pic1.Image")));
            this.Pic1.Location = new System.Drawing.Point(602, 15);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(54, 73);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 61;
            this.Pic1.TabStop = false;
            // 
            // CmaEdit
            // 
            this.CmaEdit.Enabled = false;
            this.CmaEdit.Image = ((System.Drawing.Image)(resources.GetObject("CmaEdit.Image")));
            this.CmaEdit.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmaEdit.Name = "CmaEdit";
            this.CmaEdit.Size = new System.Drawing.Size(71, 36);
            this.CmaEdit.Text = "تعديل";
            this.CmaEdit.ToolTipText = "تعديل بيانات الشركة الحالية";
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
            // 
            // CmdNew
            // 
            this.CmdNew.Image = ((System.Drawing.Image)(resources.GetObject("CmdNew.Image")));
            this.CmdNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(67, 36);
            this.CmdNew.Text = "جديد";
            this.CmdNew.ToolTipText = "انشاء شركة جديدة";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdNew,
            this.CmdSave,
            this.CmaEdit,
            this.toolStripSeparator1,
            this.CmaDel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 39);
            this.toolStrip.TabIndex = 39;
            this.toolStrip.Text = "ToolStrip";
            // 
            // FrmCashPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 419);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LstCompanies);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.Pic1);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCashPay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اذن صرف نقدى";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView LstCompanies;
        private System.Windows.Forms.LinkLabel LblId;
        private System.Windows.Forms.ToolStripButton CmaDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.ToolStripButton CmaEdit;
        private System.Windows.Forms.ToolStripButton CmdSave;
        private System.Windows.Forms.ToolStripButton CmdNew;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}