using oEEntity.Base;
using oEEntity.Model;
using oELib;
using System;
using System.Collections;
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
    public partial class frmQuestionBank : Form
    {
        public List<QuestionRelation> currentQuestionRelation = null;
        public List<QuestionRelation> selectedQuestionRelation = null;
        public QBQuestions qbQuestions = null;
        public Hashtable htQBOrder = null;
        public EntityOperationalState QbQuestionsEntityState = EntityOperationalState.None;
        public bool isQBQuestionChanged = false;
        public frmQuestionBank()
        {
            InitializeComponent();
        }

        private void frmQuestionBank_Load(object sender, EventArgs e)
        {
            QbQuestionsEntityState = EntityOperationalState.New;
            qbQuestions = new QBQuestions();
            currentQuestionRelation = new List<QuestionRelation>();
            selectedQuestionRelation = new List<QuestionRelation>();
            htQBOrder = new Hashtable();

            LoadData();
            LoadQBCombo();
            cbAQGroupType.SelectedIndex = 0;
            cbAQGroupType_SelectionChangeCommitted(null, null);
        }

        #region EVENTS
        private void btnAQSetRelations_Click(object sender, EventArgs e)
        {
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;
            MasterDataFunctions mDataFunc = null;
            SaveQuestionRelation saveQuestionRelation = null;
            List<QuestionRelation> questionRColl = null;

            try
            {
                topicTypeID = ((KeyValuePair<string, string>)cbAQTopictype.SelectedItem).Key;

                mDataFunc = new MasterDataFunctions();
                saveQuestionRelation = new SaveQuestionRelation();

                topicTypeID = ((KeyValuePair<string, string>)cbAQTopictype.SelectedItem).Key;

                mDataFunc = new MasterDataFunctions();
                questionRColl = mDataFunc.LoadQuestionsRelation(topicTypeID);
                ResetAllAQ();
                LoadQuestionsGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAvailableQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                List<string> questionIDs = null;
                string quesModeID = string.Empty;
                string questionID = string.Empty;
                MasterDataFunctions mDataFunc = null;
                QuestionRelation questionRelation = null;

                try
                {
                    mDataFunc = new MasterDataFunctions();
                    questionIDs = new List<string>();
                    questionID = dgvAvailableQuestions.Rows[e.RowIndex].Cells[0].Value.ToString();
                    questionIDs.Add(questionID);
                    questionRelation = currentQuestionRelation.Where(qr => qr.Questionn.ID == questionID).SingleOrDefault(); ;
                    selectedQuestionRelation.Add(questionRelation);
                    LoadQBQuestions(selectedQuestionRelation);
                    isQBQuestionChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //txtQuestionQV.Text = dgQuestions.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dgvQB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                List<string> questionIDs = null;
                string quesModeID = string.Empty;
                string questionID = string.Empty;
                MasterDataFunctions mDataFunc = null;
                QuestionRelation questionRelation = null;

                try
                {
                    mDataFunc = new MasterDataFunctions();
                    questionIDs = new List<string>();
                    questionID = dgvQB.Rows[e.RowIndex].Cells[1].Value.ToString();
                    questionIDs.Add(questionID);
                    questionRelation = currentQuestionRelation.Where(qr => qr.Questionn.ID == questionID).SingleOrDefault(); ;
                    selectedQuestionRelation.Remove(questionRelation);
                    dgvQB.Rows.RemoveAt(e.RowIndex);
                    htQBOrder.Clear();

                    for (int i = 0; i < dgvQB.Rows.Count - 1; i++)
                    {
                        htQBOrder.Add(dgvQB.Rows[i].Cells[0].Value, dgvQB.Rows[i].Cells[3].Value);
                    }
                    isQBQuestionChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //txtQuestionQV.Text = dgQuestions.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnQBEdit_Click(object sender, EventArgs e)
        {

        }

        private void cbAQGroupType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MasterDataFunctions mDataFunc = null;
            string groupType = string.Empty;
            List<TopicType> topicTypeColl = null;
            Dictionary<string, string> comboSource = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                groupType = ((KeyValuePair<string, string>)cbAQGroupType.SelectedItem).Key;
                topicTypeColl = mDataFunc.LoadTopic(groupType);

                comboSource = new Dictionary<string, string>();
                foreach (TopicType gt in topicTypeColl)
                {
                    comboSource.Add(gt.ID, gt.Code);
                }

                cbAQTopictype.DataSource = null;
                cbAQTopictype.Items.Clear();
                cbAQTopictype.DataSource = new BindingSource(comboSource, null);
                cbAQTopictype.DisplayMember = "Value";
                cbAQTopictype.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region METHODS
        private void ResetAll()
        {
            ResetAllQB();
            ResetAllAQ();
            txtQBName.Text = string.Empty;
            txtQBRemarks.Text = string.Empty;
            currentQuestionRelation = new List<QuestionRelation>();
            selectedQuestionRelation = new List<QuestionRelation>();
            qbQuestions = new QBQuestions();
            htQBOrder = new Hashtable();
            QbQuestionsEntityState = EntityOperationalState.None;
            isQBQuestionChanged = false;
        }
        private void ResetAllQB()
        {
            txtQBName.Text = string.Empty;
            txtQBRemarks.Text = string.Empty;
        }

        private void ResetAllAQ()
        {
            txtQuestion.Text = string.Empty;
            dgvAvailableQuestions.Rows.Clear();
            dgvAvailableQuestions.DataSource = null;
        }

        private void LoadQuestionsGrid()
        {
            List<QuestionRelation> questionRColl = null;
            MasterDataFunctions mDataFunc = null;
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;

            try
            {
                mDataFunc = new MasterDataFunctions();
                if (cbAQTopictype.SelectedItem != null)
                    topicTypeID = ((KeyValuePair<string, string>)cbAQTopictype.SelectedItem).Key;

                questionRColl = mDataFunc.LoadQuestionsRelation(topicTypeID);

                if (questionRColl != null)
                {
                    currentQuestionRelation = questionRColl;
                    dgvAvailableQuestions.Rows.Clear();
                    //loop all row in datatable
                    for (int i = 0; i < questionRColl.Count; i++)
                    {
                        //add a row int datagridview before fill
                        dgvAvailableQuestions.Rows.Add();
                        //fill the first cell value ot ith row of datagridview
                        dgvAvailableQuestions.Rows[i].Cells[0].Value = questionRColl[i].Questionn.ID;
                        dgvAvailableQuestions.Rows[i].Cells[1].Value = questionRColl[i].Questionn.Questionn;
                        dgvAvailableQuestions.Rows[i].Cells[2].Value = questionRColl[i].Questionn.Point;
                        dgvAvailableQuestions.Rows[i].Cells[3].Value = questionRColl[i].TopicType.GroupType.Code;
                        dgvAvailableQuestions.Rows[i].Cells[4].Value = questionRColl[i].TopicType.Code;

                        //here for combobx column (cast the column as datagridviewcombobox column)
                        DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvAvailableQuestions.Rows[i].Cells[5];
                        //then assign the value of cell                
                        cell.Value = "Add TO QB";
                        //see the top where we added the comboboxcolumn and define it's item, 
                        //so here value is on of the items of coboboxcolumn item.

                        //delete button cell value
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void LoadData()
        {
            List<GroupType> GroupTypColl = null;
            Dictionary<string, string> comboSource = null;

            MasterDataFunctions mDataFunc = new MasterDataFunctions();

            #region LOAD GROUP
            GroupTypColl = mDataFunc.LoadGroup();
            comboSource = new Dictionary<string, string>();
            foreach (GroupType gt in GroupTypColl)
            {
                comboSource.Add(gt.ID, gt.Code);
            }

            cbAQGroupType.DataSource = new BindingSource(comboSource, null);
            cbAQGroupType.DisplayMember = "Value";
            cbAQGroupType.ValueMember = "Key";

            #endregion
        }

        private void LoadQBQuestions(List<QuestionRelation> questionRelation)
        {
            MasterDataFunctions mDataFunc = null;
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;

            try
            {
                mDataFunc = new MasterDataFunctions();
                if (cbAQTopictype.SelectedItem != null)
                    topicTypeID = ((KeyValuePair<string, string>)cbAQTopictype.SelectedItem).Key;


                if (questionRelation != null)
                {
                    dgvQB.Rows.Clear();
                    //loop all row in datatable
                    for (int i = 0; i < questionRelation.Count; i++)
                    {
                        //add a row int datagridview before fill
                        dgvQB.Rows.Add();
                        //fill the first cell value ot ith row of datagridview
                        dgvQB.Rows[i].Cells[0].Value = questionRelation[i].ID;
                        dgvQB.Rows[i].Cells[1].Value = questionRelation[i].Questionn.ID;
                        dgvQB.Rows[i].Cells[2].Value = questionRelation[i].Questionn.Questionn;
                        if (htQBOrder.Contains(questionRelation[i].ID))
                            dgvQB.Rows[i].Cells[3].Value = htQBOrder[questionRelation[i].ID].ToString();
                        dgvQB.Rows[i].Cells[4].Value = questionRelation[i].TopicType.GroupType.Code;
                        dgvQB.Rows[i].Cells[5].Value = questionRelation[i].TopicType.Code;

                        //here for combobx column (cast the column as datagridviewcombobox column)
                        DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvQB.Rows[i].Cells[6];
                        //then assign the value of cell                
                        cell.Value = "Remove From QB";
                        //see the top where we added the comboboxcolumn and define it's item, 
                        //so here value is on of the items of coboboxcolumn item.

                        //delete button cell value
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        private void LoadQBCombo()
        {
            MasterDataFunctions mDataFunc = null;
            List<QuestionBank> qbColl = null;
            Dictionary<string, string> comboSource = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                qbColl = mDataFunc.LoadQuestionBank();

                if (qbColl != null)
                {
                    comboSource = new Dictionary<string, string>();

                    foreach (QuestionBank gt in qbColl)
                    {
                        comboSource.Add(gt.ID, gt.ExamName);
                    }

                    cbQB.DataSource = new BindingSource(comboSource, null);
                    cbQB.DisplayMember = "Value";
                    cbQB.ValueMember = "Key";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveQuestion saveQuestion = null;
            string quesModeID = string.Empty;
            string questionID = string.Empty;
            MasterDataFunctions mDataFunc = null;
            QBQuestions qbQuestions = null;
            List<QBQuestions> qbQuestionsColl = null;
            QBInfo qbInfo = null;
            string qbID = string.Empty;

            try
            {
                mDataFunc = new MasterDataFunctions();
                saveQuestion = new SaveQuestion();
                qbQuestionsColl = new List<QBQuestions>();
                qbID = ((KeyValuePair<string, string>)cbQB.SelectedItem).Key;

                htQBOrder.Clear();
                for (int i = 0; i < dgvQB.Rows.Count - 1; i++)
                {
                    htQBOrder.Add(dgvQB.Rows[i].Cells[0].Value, dgvQB.Rows[i].Cells[3].Value);
                }

                foreach (QuestionRelation qr in selectedQuestionRelation)
                {
                    qbQuestions = new QBQuestions();
                    qbQuestions.Question_Rel_ID = qr.ID;
                    qbQuestions.Order = htQBOrder[qr.ID].ToString();
                    qbQuestions.EntityState = QbQuestionsEntityState;
                    qbQuestionsColl.Add(qbQuestions);
                }

                qbInfo = new QBInfo();
                qbInfo.ID = string.IsNullOrWhiteSpace(qbID) ? string.Empty : qbID;
                qbInfo.QBName = txtQBName.Text;
                qbInfo.Remarks = txtQBRemarks.Text;
                qbInfo.QBQuestionsEntityState = isQBQuestionChanged ? EntityOperationalState.Update : EntityOperationalState.None;
                qbInfo.EntityState = QbQuestionsEntityState;
                qbInfo.QBQuestions = qbQuestionsColl;

                isQBQuestionChanged = false;

                mDataFunc.AddQuestionBank(qbInfo);
                MessageBox.Show("Question Bank saved.");
                ResetAll();
                LoadQBCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQBEdit_Click_1(object sender, EventArgs e)
        {
            MasterDataFunctions mDataFunc = null;
            List<QuestionBank> qbColl = null;
            Dictionary<string, string> comboSource = null;
            string qbID = string.Empty;

            try
            {
                ResetAll();
                QbQuestionsEntityState = EntityOperationalState.Update;
                isQBQuestionChanged = false;

                qbID = ((KeyValuePair<string, string>)cbQB.SelectedItem).Key;
                mDataFunc = new MasterDataFunctions();
                qbColl = mDataFunc.LoadQuestionBank(qbID);


                if (qbColl != null)
                {
                    txtQBName.Text = qbColl[0].ExamName;
                    txtQBRemarks.Text = qbColl[0].Remarks;

                    qbColl[0].Questions.ForEach(qb => htQBOrder.Add(qb.QuestionRelation.ID, qb.Order));
                    selectedQuestionRelation.AddRange(qbColl[0].Questions.Select(qbq => qbq.QuestionRelation));
                    LoadQBQuestions(selectedQuestionRelation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewQB_Click(object sender, EventArgs e)
        {
            QbQuestionsEntityState = EntityOperationalState.New;
            isQBQuestionChanged = false;
            ResetAll();
        }
    }
}
