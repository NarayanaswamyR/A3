using oEEntity.Base;
using oEEntity.Model;
using oELib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Forms
{
    public partial class frmAnswers : Form
    {
        public EntityOperationalState AnswerOperatonState = EntityOperationalState.None;
        public Answer EditedAnswer = null;
        public Question question = null;

        public frmAnswers()
        {
            InitializeComponent();
        }

        public frmAnswers(Question Question)
        {
            question = Question;
            InitializeComponent();
        }

        #region EVENTS

        private void frmAnswers_Load(object sender, EventArgs e)
        {
            AnswerOperatonState = EntityOperationalState.New;
            LoadAnswers();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAnswers saveAnswer = null;
            MasterDataFunctions mDataFunc = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                saveAnswer = new SaveAnswers();

                if (EditedAnswer != null)
                    saveAnswer.ID = EditedAnswer.ID;

                saveAnswer.Answerr = txtAnswer.Text;
                saveAnswer.AnswerOrder = txtAnswerOrder.Text;
                saveAnswer.Value = txtAnsweValue.Text;
                saveAnswer.QuestionID = question.ID;
                saveAnswer.EntityState = AnswerOperatonState;

                mDataFunc.SaveAnswers(saveAnswer);

                ResetAll();
                LoadAnswers();
                EditedAnswer = null;
                MessageBox.Show("Answer saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAnswers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Answer> answerColl = null;
            List<string> answerIDs = null;
            MasterDataFunctions mDataFunc = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                answerIDs = new List<string>();
                answerIDs.Add(dgvAnswers.Rows[e.RowIndex].Cells[0].Value.ToString());
                answerColl = mDataFunc.LoadAnswersByID(answerIDs);
                EditedAnswer = answerColl[0];

                txtAnswer.Text = dgvAnswers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAnswerOrder.Text = dgvAnswers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAnsweValue.Text = dgvAnswers.Rows[e.RowIndex].Cells[3].Value.ToString();
                AnswerOperatonState = EntityOperationalState.Update;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region METHODS
        private void ResetAll()
        {
            txtAnswer.Text = string.Empty;
            txtAnswerOrder.Text = string.Empty;
           // txtQuestion.Text = string.Empty;
            AnswerOperatonState = EntityOperationalState.New;
            EditedAnswer = null;
        }
        private void LoadAnswers()
        {
            List<Answer> answersColl = null;
            List<string> questionIDs = null;
            MasterDataFunctions mDataFunc = null;
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;

            try
            {
                mDataFunc = new MasterDataFunctions();
                questionIDs = new List<string>();
                questionIDs.Add(question.ID);
                txtQuestion.Text = question.Questionn;
                answersColl = mDataFunc.LoadAnswersByQuestion(questionIDs);

                if (answersColl != null)
                {
                    dgvAnswers.Rows.Clear();
                    //loop all row in datatable
                    for (int i = 0; i < answersColl.Count; i++)
                    {
                        //add a row int datagridview before fill
                        dgvAnswers.Rows.Add();
                        //fill the first cell value ot ith row of datagridview
                        dgvAnswers.Rows[i].Cells[0].Value = answersColl[i].ID;
                        dgvAnswers.Rows[i].Cells[1].Value = answersColl[i].Answerr;
                        dgvAnswers.Rows[i].Cells[2].Value = answersColl[i].AnswerOrder;
                        dgvAnswers.Rows[i].Cells[3].Value = answersColl[i].Value;
                    }
                }
            }
            catch
            {
                throw;
            }
        }


        #endregion

    }
}
