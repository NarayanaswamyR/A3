namespace WindowsFormsApplication1.Forms
{
    partial class frmQuestions
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
            this.btnAddNewRelations = new System.Windows.Forms.Button();
            this.btnSetRelation = new System.Windows.Forms.Button();
            this.cbTopicType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGroupType = new System.Windows.Forms.ComboBox();
            this.roupType = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbQuestionMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbComplexlevel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtQuestionQV = new System.Windows.Forms.RichTextBox();
            this.dgQuestions = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddAnswer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewRelations);
            this.groupBox1.Controls.Add(this.btnSetRelation);
            this.groupBox1.Controls.Add(this.cbTopicType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGroupType);
            this.groupBox1.Controls.Add(this.roupType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relation";
            // 
            // btnAddNewRelations
            // 
            this.btnAddNewRelations.Location = new System.Drawing.Point(652, 20);
            this.btnAddNewRelations.Name = "btnAddNewRelations";
            this.btnAddNewRelations.Size = new System.Drawing.Size(111, 23);
            this.btnAddNewRelations.TabIndex = 20;
            this.btnAddNewRelations.Text = "New Relations";
            this.btnAddNewRelations.UseVisualStyleBackColor = true;
            this.btnAddNewRelations.Click += new System.EventHandler(this.btnAddNewRelations_Click);
            // 
            // btnSetRelation
            // 
            this.btnSetRelation.Location = new System.Drawing.Point(497, 20);
            this.btnSetRelation.Name = "btnSetRelation";
            this.btnSetRelation.Size = new System.Drawing.Size(75, 23);
            this.btnSetRelation.TabIndex = 19;
            this.btnSetRelation.Text = "Set";
            this.btnSetRelation.UseVisualStyleBackColor = true;
            this.btnSetRelation.Click += new System.EventHandler(this.btnSetRelation_Click);
            // 
            // cbTopicType
            // 
            this.cbTopicType.FormattingEnabled = true;
            this.cbTopicType.Location = new System.Drawing.Point(356, 20);
            this.cbTopicType.Name = "cbTopicType";
            this.cbTopicType.Size = new System.Drawing.Size(100, 21);
            this.cbTopicType.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Topic Type";
            // 
            // cbGroupType
            // 
            this.cbGroupType.FormattingEnabled = true;
            this.cbGroupType.Location = new System.Drawing.Point(123, 19);
            this.cbGroupType.Name = "cbGroupType";
            this.cbGroupType.Size = new System.Drawing.Size(100, 21);
            this.cbGroupType.TabIndex = 10;
            this.cbGroupType.SelectionChangeCommitted += new System.EventHandler(this.cbGroupType_SelectionChangeCommitted);
            // 
            // roupType
            // 
            this.roupType.AutoSize = true;
            this.roupType.Location = new System.Drawing.Point(20, 22);
            this.roupType.Name = "roupType";
            this.roupType.Size = new System.Drawing.Size(63, 13);
            this.roupType.TabIndex = 9;
            this.roupType.Text = "Group Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuestion);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.txtPoint);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbQuestionMode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbComplexlevel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(123, 15);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(640, 50);
            this.txtQuestion.TabIndex = 21;
            this.txtQuestion.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(688, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(594, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(497, 105);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(123, 105);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(100, 20);
            this.txtPoint.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Question";
            // 
            // cbQuestionMode
            // 
            this.cbQuestionMode.FormattingEnabled = true;
            this.cbQuestionMode.Location = new System.Drawing.Point(356, 110);
            this.cbQuestionMode.Name = "cbQuestionMode";
            this.cbQuestionMode.Size = new System.Drawing.Size(100, 21);
            this.cbQuestionMode.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Question Mode";
            // 
            // cbComplexlevel
            // 
            this.cbComplexlevel.FormattingEnabled = true;
            this.cbComplexlevel.Location = new System.Drawing.Point(356, 78);
            this.cbComplexlevel.Name = "cbComplexlevel";
            this.cbComplexlevel.Size = new System.Drawing.Size(100, 21);
            this.cbComplexlevel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Complex Level";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtQuestionQV);
            this.groupBox3.Controls.Add(this.dgQuestions);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 237);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Questions";
            // 
            // txtQuestionQV
            // 
            this.txtQuestionQV.Location = new System.Drawing.Point(23, 19);
            this.txtQuestionQV.Name = "txtQuestionQV";
            this.txtQuestionQV.Size = new System.Drawing.Size(740, 34);
            this.txtQuestionQV.TabIndex = 1;
            this.txtQuestionQV.Text = "";
            // 
            // dgQuestions
            // 
            this.dgQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Question,
            this.Point,
            this.Group,
            this.Topic,
            this.AddAnswer});
            this.dgQuestions.Location = new System.Drawing.Point(6, 70);
            this.dgQuestions.Name = "dgQuestions";
            this.dgQuestions.Size = new System.Drawing.Size(787, 150);
            this.dgQuestions.TabIndex = 0;
            this.dgQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQuestions_CellContentClick);
            this.dgQuestions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQuestions_CellDoubleClick);
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
            this.Question.Width = 220;
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
            // AddAnswer
            // 
            this.AddAnswer.HeaderText = "Answer";
            this.AddAnswer.Name = "AddAnswer";
            // 
            // frmQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuestions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuestions";
            this.Load += new System.EventHandler(this.frmQuestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTopicType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGroupType;
        private System.Windows.Forms.Label roupType;
        private System.Windows.Forms.ComboBox cbComplexlevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbQuestionMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgQuestions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox txtQuestionQV;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private System.Windows.Forms.Button btnSetRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewButtonColumn AddAnswer;
        private System.Windows.Forms.Button btnAddNewRelations;
    }
}