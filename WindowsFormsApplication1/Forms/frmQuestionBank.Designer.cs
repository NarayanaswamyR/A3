namespace WindowsFormsApplication1.Forms
{
    partial class frmQuestionBank
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAQSetRelations = new System.Windows.Forms.Button();
            this.cbAQTopictype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAQGroupType = new System.Windows.Forms.ComboBox();
            this.roupType = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.dgvAvailableQuestions = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQBQuestions = new System.Windows.Forms.RichTextBox();
            this.dgvQB = new System.Windows.Forms.DataGridView();
            this.ID_REL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnQBEdit = new System.Windows.Forms.Button();
            this.cbQB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnNewQB = new System.Windows.Forms.Button();
            this.txtQBRemarks = new System.Windows.Forms.TextBox();
            this.txtQBName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableQuestions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQB)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAQSetRelations);
            this.groupBox3.Controls.Add(this.cbAQTopictype);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbAQGroupType);
            this.groupBox3.Controls.Add(this.roupType);
            this.groupBox3.Controls.Add(this.txtQuestion);
            this.groupBox3.Controls.Add(this.dgvAvailableQuestions);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(760, 288);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available Questions";
            // 
            // btnAQSetRelations
            // 
            this.btnAQSetRelations.Location = new System.Drawing.Point(662, 28);
            this.btnAQSetRelations.Name = "btnAQSetRelations";
            this.btnAQSetRelations.Size = new System.Drawing.Size(75, 23);
            this.btnAQSetRelations.TabIndex = 35;
            this.btnAQSetRelations.Text = "Set";
            this.btnAQSetRelations.UseVisualStyleBackColor = true;
            this.btnAQSetRelations.Click += new System.EventHandler(this.btnAQSetRelations_Click);
            // 
            // cbAQTopictype
            // 
            this.cbAQTopictype.FormattingEnabled = true;
            this.cbAQTopictype.Location = new System.Drawing.Point(294, 30);
            this.cbAQTopictype.Name = "cbAQTopictype";
            this.cbAQTopictype.Size = new System.Drawing.Size(100, 21);
            this.cbAQTopictype.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Topic Type";
            // 
            // cbAQGroupType
            // 
            this.cbAQGroupType.FormattingEnabled = true;
            this.cbAQGroupType.Location = new System.Drawing.Point(100, 29);
            this.cbAQGroupType.Name = "cbAQGroupType";
            this.cbAQGroupType.Size = new System.Drawing.Size(100, 21);
            this.cbAQGroupType.TabIndex = 14;
            this.cbAQGroupType.SelectionChangeCommitted += new System.EventHandler(this.cbAQGroupType_SelectionChangeCommitted);
            // 
            // roupType
            // 
            this.roupType.AutoSize = true;
            this.roupType.Location = new System.Drawing.Point(27, 32);
            this.roupType.Name = "roupType";
            this.roupType.Size = new System.Drawing.Size(63, 13);
            this.roupType.TabIndex = 13;
            this.roupType.Text = "Group Type";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(6, 74);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(734, 34);
            this.txtQuestion.TabIndex = 1;
            this.txtQuestion.Text = "";
            // 
            // dgvAvailableQuestions
            // 
            this.dgvAvailableQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Question,
            this.Point,
            this.Group,
            this.Topic,
            this.Add});
            this.dgvAvailableQuestions.Location = new System.Drawing.Point(6, 125);
            this.dgvAvailableQuestions.Name = "dgvAvailableQuestions";
            this.dgvAvailableQuestions.Size = new System.Drawing.Size(734, 150);
            this.dgvAvailableQuestions.TabIndex = 0;
            this.dgvAvailableQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableQuestions_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Question
            // 
            this.Question.HeaderText = "Question";
            this.Question.Name = "Question";
            // 
            // Point
            // 
            this.Point.HeaderText = "Point";
            this.Point.Name = "Point";
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.Name = "Topic";
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQBQuestions);
            this.groupBox2.Controls.Add(this.dgvQB);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank Questions";
            // 
            // txtQBQuestions
            // 
            this.txtQBQuestions.Location = new System.Drawing.Point(9, 19);
            this.txtQBQuestions.Name = "txtQBQuestions";
            this.txtQBQuestions.Size = new System.Drawing.Size(731, 34);
            this.txtQBQuestions.TabIndex = 1;
            this.txtQBQuestions.Text = "";
            // 
            // dgvQB
            // 
            this.dgvQB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_REL,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Order,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewButtonColumn1});
            this.dgvQB.Location = new System.Drawing.Point(6, 70);
            this.dgvQB.Name = "dgvQB";
            this.dgvQB.Size = new System.Drawing.Size(734, 150);
            this.dgvQB.TabIndex = 0;
            this.dgvQB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQB_CellContentClick);
            // 
            // ID_REL
            // 
            this.ID_REL.HeaderText = "ID_REL";
            this.ID_REL.Name = "ID_REL";
            this.ID_REL.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Question";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Order
            // 
            this.Order.HeaderText = "Order";
            this.Order.Name = "Order";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Group";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Topic";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Remove";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(286, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnQBEdit);
            this.groupBox5.Controls.Add(this.cbQB);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(400, 550);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 53);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit";
            // 
            // btnQBEdit
            // 
            this.btnQBEdit.Location = new System.Drawing.Point(260, 16);
            this.btnQBEdit.Name = "btnQBEdit";
            this.btnQBEdit.Size = new System.Drawing.Size(75, 23);
            this.btnQBEdit.TabIndex = 24;
            this.btnQBEdit.Text = "Edit";
            this.btnQBEdit.UseVisualStyleBackColor = true;
            this.btnQBEdit.Click += new System.EventHandler(this.btnQBEdit_Click_1);
            // 
            // cbQB
            // 
            this.cbQB.FormattingEnabled = true;
            this.cbQB.Location = new System.Drawing.Point(136, 18);
            this.cbQB.Name = "cbQB";
            this.cbQB.Size = new System.Drawing.Size(100, 21);
            this.cbQB.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Question Bank";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNewQB);
            this.groupBox4.Controls.Add(this.txtQBRemarks);
            this.groupBox4.Controls.Add(this.txtQBName);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(13, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 95);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New";
            // 
            // btnNewQB
            // 
            this.btnNewQB.Location = new System.Drawing.Point(201, 66);
            this.btnNewQB.Name = "btnNewQB";
            this.btnNewQB.Size = new System.Drawing.Size(75, 23);
            this.btnNewQB.TabIndex = 36;
            this.btnNewQB.Text = "New";
            this.btnNewQB.UseVisualStyleBackColor = true;
            this.btnNewQB.Click += new System.EventHandler(this.btnNewQB_Click);
            // 
            // txtQBRemarks
            // 
            this.txtQBRemarks.Location = new System.Drawing.Point(261, 19);
            this.txtQBRemarks.Name = "txtQBRemarks";
            this.txtQBRemarks.Size = new System.Drawing.Size(100, 20);
            this.txtQBRemarks.TabIndex = 21;
            // 
            // txtQBName
            // 
            this.txtQBName.Location = new System.Drawing.Point(85, 19);
            this.txtQBName.Name = "txtQBName";
            this.txtQBName.Size = new System.Drawing.Size(100, 20);
            this.txtQBName.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Remarks";
            // 
            // frmQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 661);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuestionBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestionBank";
            this.Load += new System.EventHandler(this.frmQuestionBank_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableQuestions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQB)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.DataGridView dgvAvailableQuestions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtQBQuestions;
        private System.Windows.Forms.DataGridView dgvQB;
        private System.Windows.Forms.ComboBox cbAQTopictype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAQGroupType;
        private System.Windows.Forms.Label roupType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAQSetRelations;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_REL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnQBEdit;
        private System.Windows.Forms.ComboBox cbQB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtQBRemarks;
        private System.Windows.Forms.TextBox txtQBName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewQB;
    }
}