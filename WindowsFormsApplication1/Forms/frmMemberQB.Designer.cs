namespace WindowsFormsApplication1.Forms
{
    partial class frmMemberQB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkParticipentActive = new System.Windows.Forms.CheckBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartiName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartiCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btbnRemovePartici = new System.Windows.Forms.Button();
            this.btnAddPatici = new System.Windows.Forms.Button();
            this.lstSelectedQB = new System.Windows.Forms.ListBox();
            this.lstAvailableQB = new System.Windows.Forms.ListBox();
            this.btnEditPartici = new System.Windows.Forms.Button();
            this.cbParticipent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.chkParticipentActive);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPartiName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPartiCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participent";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(161, 243);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(18, 243);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 23);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(89, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkParticipentActive
            // 
            this.chkParticipentActive.AutoSize = true;
            this.chkParticipentActive.Location = new System.Drawing.Point(25, 200);
            this.chkParticipentActive.Name = "chkParticipentActive";
            this.chkParticipentActive.Size = new System.Drawing.Size(56, 17);
            this.chkParticipentActive.TabIndex = 14;
            this.chkParticipentActive.Text = "Active";
            this.chkParticipentActive.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(166, 95);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 13;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(95, 95);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 12;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(95, 159);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 20);
            this.txtRemarks.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remarks";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "EMail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender";
            // 
            // txtPartiName
            // 
            this.txtPartiName.Location = new System.Drawing.Point(95, 64);
            this.txtPartiName.Name = "txtPartiName";
            this.txtPartiName.Size = new System.Drawing.Size(100, 20);
            this.txtPartiName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtPartiCode
            // 
            this.txtPartiCode.Location = new System.Drawing.Point(95, 35);
            this.txtPartiCode.Name = "txtPartiCode";
            this.txtPartiCode.Size = new System.Drawing.Size(100, 20);
            this.txtPartiCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btbnRemovePartici);
            this.groupBox2.Controls.Add(this.btnAddPatici);
            this.groupBox2.Controls.Add(this.lstSelectedQB);
            this.groupBox2.Controls.Add(this.lstAvailableQB);
            this.groupBox2.Location = new System.Drawing.Point(273, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ParticipentQB";
            // 
            // btbnRemovePartici
            // 
            this.btbnRemovePartici.Location = new System.Drawing.Point(235, 109);
            this.btbnRemovePartici.Name = "btbnRemovePartici";
            this.btbnRemovePartici.Size = new System.Drawing.Size(31, 23);
            this.btbnRemovePartici.TabIndex = 19;
            this.btbnRemovePartici.Text = "<<";
            this.btbnRemovePartici.UseVisualStyleBackColor = true;
            this.btbnRemovePartici.Click += new System.EventHandler(this.btbnRemovePartici_Click);
            // 
            // btnAddPatici
            // 
            this.btnAddPatici.Location = new System.Drawing.Point(235, 69);
            this.btnAddPatici.Name = "btnAddPatici";
            this.btnAddPatici.Size = new System.Drawing.Size(31, 23);
            this.btnAddPatici.TabIndex = 18;
            this.btnAddPatici.Text = ">>";
            this.btnAddPatici.UseVisualStyleBackColor = true;
            this.btnAddPatici.Click += new System.EventHandler(this.btnAddPatici_Click);
            // 
            // lstSelectedQB
            // 
            this.lstSelectedQB.FormattingEnabled = true;
            this.lstSelectedQB.Location = new System.Drawing.Point(273, 16);
            this.lstSelectedQB.Name = "lstSelectedQB";
            this.lstSelectedQB.Size = new System.Drawing.Size(218, 186);
            this.lstSelectedQB.TabIndex = 1;
            // 
            // lstAvailableQB
            // 
            this.lstAvailableQB.FormattingEnabled = true;
            this.lstAvailableQB.Location = new System.Drawing.Point(12, 18);
            this.lstAvailableQB.Name = "lstAvailableQB";
            this.lstAvailableQB.Size = new System.Drawing.Size(218, 186);
            this.lstAvailableQB.TabIndex = 0;
            // 
            // btnEditPartici
            // 
            this.btnEditPartici.Location = new System.Drawing.Point(537, 19);
            this.btnEditPartici.Name = "btnEditPartici";
            this.btnEditPartici.Size = new System.Drawing.Size(51, 23);
            this.btnEditPartici.TabIndex = 22;
            this.btnEditPartici.Text = "Edit";
            this.btnEditPartici.UseVisualStyleBackColor = true;
            this.btnEditPartici.Click += new System.EventHandler(this.btnEditPartici_Click);
            // 
            // cbParticipent
            // 
            this.cbParticipent.FormattingEnabled = true;
            this.cbParticipent.Location = new System.Drawing.Point(376, 22);
            this.cbParticipent.Name = "cbParticipent";
            this.cbParticipent.Size = new System.Drawing.Size(121, 21);
            this.cbParticipent.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Participent";
            // 
            // frmMemberQB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 316);
            this.Controls.Add(this.btnEditPartici);
            this.Controls.Add(this.cbParticipent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMemberQB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMemberQB";
            this.Load += new System.EventHandler(this.frmMemberQB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPartiName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartiCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkParticipentActive;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btbnRemovePartici;
        private System.Windows.Forms.Button btnAddPatici;
        private System.Windows.Forms.ListBox lstSelectedQB;
        private System.Windows.Forms.ListBox lstAvailableQB;
        private System.Windows.Forms.Button btnEditPartici;
        private System.Windows.Forms.ComboBox cbParticipent;
        private System.Windows.Forms.Label label7;
    }
}