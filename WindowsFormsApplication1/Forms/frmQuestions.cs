using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oEEntity.Base;
using oEEntity.Model;
using oELib;

namespace WindowsFormsApplication1.Forms
{
    public partial class frmQuestions : Form
    {

        public EntityOperationalState QuestionOperatonState = EntityOperationalState.None;
        public EntityOperationalState AnswerOperatonState = EntityOperationalState.None;
        public Question EditedQuestion = null;

        public frmQuestions()
        {
            InitializeComponent();
        }

        #region METHODS
        private void LoadData()
        {
            List<GroupType> GroupTypColl = null;
            List<TopicType> TopicTypeColl = null;
            List<QuestionMode> QuesModeColl = null;
            Dictionary<string, string> comboSource = null;

            MasterDataFunctions mDataFunc = new MasterDataFunctions();

            #region LOAD GROUP
            GroupTypColl = mDataFunc.LoadGroup();
            comboSource = new Dictionary<string, string>();
            foreach (GroupType gt in GroupTypColl)
            {
                comboSource.Add(gt.ID, gt.Code);
            }

            cbGroupType.DataSource = new BindingSource(comboSource, null);
            cbGroupType.DisplayMember = "Value";
            cbGroupType.ValueMember = "Key";
            #endregion

            #region LOADTOPIC
            /*TopicTypeColl = mDataFunc.LoadTopic();
            comboSource = new Dictionary<string, string>();
            foreach (TopicType gt in TopicTypeColl)
            {
                comboSource.Add(gt.ID, gt.Code);
            }

            cbTopicType.DataSource = new BindingSource(comboSource, null);
            cbTopicType.DisplayMember = "Value";
            cbTopicType.ValueMember = "Key";*/
            #endregion

            #region MODE
            comboSource = new Dictionary<string, string>();
            QuesModeColl = mDataFunc.LoadMode();
            comboSource = new Dictionary<string, string>();
            foreach (QuestionMode gm in QuesModeColl)
            {
                comboSource.Add(gm.ID, gm.Code);
            }

            cbQuestionMode.DataSource = new BindingSource(comboSource, null);
            cbQuestionMode.DisplayMember = "Value";
            cbQuestionMode.ValueMember = "Key";
            #endregion

            #region COMPLEXLEVEL
            cbComplexlevel.Items.Add("1");
            cbComplexlevel.Items.Add("2");
            cbComplexlevel.Items.Add("3");
            cbComplexlevel.Items.Add("4");
            cbComplexlevel.Items.Add("5");
            #endregion
        }
        private void LoadQuestionsGrid()
        {
            List <QuestionRelation> questionRColl = null;
            MasterDataFunctions mDataFunc = null;
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;

            try
            {
                mDataFunc = new MasterDataFunctions();
                if(cbGroupType.SelectedItem != null)
                    groupTypeID = ((KeyValuePair<string, string>)cbGroupType.SelectedItem).Key;
                if (cbTopicType.SelectedItem != null)
                    topicTypeID = ((KeyValuePair<string, string>)cbTopicType.SelectedItem).Key;

                questionRColl = mDataFunc.LoadQuestionsRelation(topicTypeID);

                if (questionRColl != null)
                {
                    dgQuestions.Rows.Clear();
                    //loop all row in datatable
                    for (int i = 0; i < questionRColl.Count; i++)
                    {
                        //add a row int datagridview before fill
                        dgQuestions.Rows.Add();
                        //fill the first cell value ot ith row of datagridview
                        dgQuestions.Rows[i].Cells[0].Value = questionRColl[i].Questionn.ID;
                        dgQuestions.Rows[i].Cells[1].Value = questionRColl[i].Questionn.Questionn;
                        dgQuestions.Rows[i].Cells[2].Value = questionRColl[i].Questionn.Point;
                        dgQuestions.Rows[i].Cells[3].Value = questionRColl[i].TopicType.GroupType.Code;
                        dgQuestions.Rows[i].Cells[4].Value = questionRColl[i].TopicType.Code;

                        //here for combobx column (cast the column as datagridviewcombobox column)
                        DataGridViewButtonCell cell = (DataGridViewButtonCell)dgQuestions.Rows[i].Cells[5];
                        //then assign the value of cell                
                        cell.Value = "Answers";
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
        private void SaveQuestionRelation(string questionID)
        {
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;
            MasterDataFunctions mDataFunc = null;
            SaveQuestionRelation saveQuestionRelation = null;

            try
            {
                groupTypeID = ((KeyValuePair<string, string>)cbGroupType.SelectedItem).Key;
                topicTypeID = ((KeyValuePair<string, string>)cbTopicType.SelectedItem).Key;

                mDataFunc = new MasterDataFunctions();
                saveQuestionRelation = new SaveQuestionRelation();

                saveQuestionRelation.QuestionID = questionID;
                saveQuestionRelation.GroupTypeID = groupTypeID;
                saveQuestionRelation.TopicTypeID = topicTypeID;
                saveQuestionRelation.EntityState = QuestionOperatonState;

                mDataFunc.SaveQuestionRelation(saveQuestionRelation);
            }
            catch
            {
                throw;
            }
        }
        private void ResetAll()
        {
            txtQuestion.Text = string.Empty;
            txtPoint.Text = string.Empty;
            cbComplexlevel.SelectedIndex = 0;
            cbQuestionMode.SelectedIndex = 0;
            txtQuestionQV.Text = string.Empty;
            dgQuestions.Rows.Clear();
            EditedQuestion = null;
        }
        private void QuestionRelationChanged(string GroupTypID, string TopicTypID)
        {
            List<QuestionRelation> questionRColl = null;
            MasterDataFunctions mDataFunc = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                questionRColl = mDataFunc.LoadQuestionsRelation(TopicTypID);
                ResetAll();
                LoadQuestionsGrid();
            }
            catch { throw; }
        }
        #endregion

        #region EVENTS
        private void frmQuestions_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadQuestionsGrid();
            cbGroupType.SelectedIndex = 0;
            cbGroupType_SelectionChangeCommitted(null, null);
            QuestionOperatonState = EntityOperationalState.New;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtQuestion.Text = string.Empty;
            txtPoint.Text = string.Empty;
            cbComplexlevel.SelectedIndex = 0;
            cbQuestionMode.SelectedIndex = 0;

            QuestionOperatonState = EntityOperationalState.New;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveQuestion saveQuestion = null;
            string quesModeID = string.Empty;
            string questionID = string.Empty;
            MasterDataFunctions mDataFunc = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                saveQuestion = new SaveQuestion();
                quesModeID = ((KeyValuePair<string, string>)cbQuestionMode.SelectedItem).Key;

                if (EditedQuestion != null)
                    saveQuestion.ID = EditedQuestion.ID;

                saveQuestion.QuestionModeID = quesModeID;
                saveQuestion.Questionn = txtQuestion.Text;
                saveQuestion.ComplexLevel = cbComplexlevel.Text;
                saveQuestion.Point = txtPoint.Text;
                saveQuestion.EntityState = QuestionOperatonState;

                questionID = mDataFunc.SaveQuestion(saveQuestion);

                if(QuestionOperatonState == EntityOperationalState.New)
                   SaveQuestionRelation(questionID);

                ResetAll();
                LoadQuestionsGrid();
                EditedQuestion = null;

                MessageBox.Show("Question saved.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSetRelation_Click(object sender, EventArgs e)
        {
            string groupTypeID = string.Empty;
            string topicTypeID = string.Empty;
            MasterDataFunctions mDataFunc = null;
            SaveQuestionRelation saveQuestionRelation = null;

            try
            {
                groupTypeID = ((KeyValuePair<string, string>)cbGroupType.SelectedItem).Key;
                topicTypeID = ((KeyValuePair<string, string>)cbTopicType.SelectedItem).Key;

                mDataFunc = new MasterDataFunctions();
                saveQuestionRelation = new SaveQuestionRelation();
                QuestionRelationChanged(groupTypeID, topicTypeID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                List<Question> questionColl = null;
                List<string> questionIDs = null;
                string quesModeID = string.Empty;
                string questionID = string.Empty;
                MasterDataFunctions mDataFunc = null;

                try
                {
                    mDataFunc = new MasterDataFunctions();
                    questionIDs = new List<string>();
                    questionIDs.Add(dgQuestions.Rows[e.RowIndex].Cells[0].Value.ToString());
                    questionColl = mDataFunc.LoadQuestion(questionIDs);
                    frmAnswers answer = new frmAnswers(questionColl[0]);
                    answer.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                txtQuestionQV.Text = dgQuestions.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void dgQuestions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Question> questionColl = null;
            List<string> questionIDs = null;
            string quesModeID = string.Empty;
            string questionID = string.Empty;
            MasterDataFunctions mDataFunc = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                questionIDs = new List<string>();
                questionIDs.Add(dgQuestions.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionColl = mDataFunc.LoadQuestion(questionIDs);
                EditedQuestion = questionColl[0];
                txtQuestion.Text = dgQuestions.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPoint.Text = dgQuestions.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbComplexlevel.Text = dgQuestions.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbQuestionMode.Text = dgQuestions.Rows[e.RowIndex].Cells[4].Value.ToString();

                QuestionOperatonState = EntityOperationalState.Update;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnAddNewRelations_Click(object sender, EventArgs e)
        {
            frmMasterData masterData = new frmMasterData();
            masterData.ShowDialog();
        }

        private void cbGroupType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MasterDataFunctions mDataFunc = null;
            string groupType = string.Empty;
            List<TopicType> topicTypeColl = null;
            Dictionary<string, string> comboSource = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                groupType = ((KeyValuePair<string, string>)cbGroupType.SelectedItem).Key;
                topicTypeColl = mDataFunc.LoadTopic(groupType);

                comboSource = new Dictionary<string, string>();
                foreach (TopicType gt in topicTypeColl)
                {
                    comboSource.Add(gt.ID, gt.Code);
                }

                cbTopicType.DataSource = null;
                cbTopicType.Items.Clear();
                cbTopicType.DataSource = new BindingSource(comboSource, null);
                cbTopicType.DisplayMember = "Value";
                cbTopicType.ValueMember = "Key";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

