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
    public partial class frmMemberQB : Form
    {
        public EntityOperationalState ParticipentQBEntityState = EntityOperationalState.None;
        public Dictionary<string, string> listboxSourcePartiQB = null;
        public ParticeipentInfo eidtedParticipentInfo = null;
        public Dictionary<string, string> selectedQBIDValue = null;
        public frmMemberQB()
        {
            InitializeComponent();
        }

        private void frmMemberQB_Load(object sender, EventArgs e)
        {
            listboxSourcePartiQB = new Dictionary<string, string>();
            eidtedParticipentInfo = new ParticeipentInfo();
            selectedQBIDValue = new Dictionary<string, string>();
            eidtedParticipentInfo.ParticeipentAssesmentEntityState = EntityOperationalState.None;
            eidtedParticipentInfo.EntityState = EntityOperationalState.New;
            LoadAllQB();
            LoadParticipentCombo();
        }

        #region EVENTS
        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetAll();
            ParticipentQBEntityState = EntityOperationalState.New;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string selQBID = string.Empty;
            List<string> selQBIDColl = null;
            MasterDataFunctions mDataFunc = null;

            try
            {
                selQBIDColl = new List<string>();
                eidtedParticipentInfo.Code = txtPartiCode.Text;
                eidtedParticipentInfo.Name = txtPartiName.Text;
                eidtedParticipentInfo.Gender = rbFemale.Checked ? "F" : "M";
                eidtedParticipentInfo.Email = txtEmail.Text;
                eidtedParticipentInfo.Remarks = txtRemarks.Text;
                eidtedParticipentInfo.Active = chkParticipentActive.Checked;

                foreach(var lstItem in lstSelectedQB.Items)
                {
                    selQBID = ((KeyValuePair<string, string>)lstItem).Key;
                    selQBIDColl.Add(selQBID);
                }
                eidtedParticipentInfo.QBIds = selQBIDColl;

                mDataFunc.AddParticipant(eidtedParticipentInfo);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region METHODS
        private void LoadParticipentCombo()
        {
            MasterDataFunctions mDataFunc = null;
            List<Participant> participentColl = null;
            Dictionary<string, string> listboxSource = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                participentColl = mDataFunc.LoadParticipents();

                if (participentColl != null)
                {
                    cbParticipent.DataSource = null;
                    listboxSource = new Dictionary<string, string>();

                    foreach (Participant gt in participentColl)
                    {
                        listboxSource.Add(gt.ID, gt.Code);
                    }

                    cbParticipent.DataSource = new BindingSource(listboxSource, null);
                    cbParticipent.DisplayMember = "Value";
                    cbParticipent.ValueMember = "Key";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ResetAll()
        {
            txtPartiCode.Text = string.Empty;
            txtPartiName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtRemarks.Text = string.Empty;

            cbParticipent.DataSource = null;
            lstAvailableQB.DataSource = null;
            lstSelectedQB.DataSource = null;
            ParticipentQBEntityState = EntityOperationalState.New;
            eidtedParticipentInfo = new ParticeipentInfo();
        }

        private void LoadAllQB()
        {
            MasterDataFunctions mDataFunc = null;
            List<QuestionBank> qbColl = null;
            Dictionary<string, string> listboxSource = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                qbColl = mDataFunc.LoadQuestionBank();

                if (qbColl != null)
                {
                    listboxSource = new Dictionary<string, string>();

                    foreach (QuestionBank gt in qbColl)
                    {
                        listboxSource.Add(gt.ID, gt.ExamName);
                    }

                    lstAvailableQB.DataSource = new BindingSource(listboxSource, null);
                    lstAvailableQB.DisplayMember = "Value";
                    lstAvailableQB.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadPartiQB(string ParticiID)
        {
            MasterDataFunctions mDataFunc = null;
            List<QuestionBank> qbColl = null;
            List<ParticipantAssesment> paColl = null;
            Dictionary<string, string> listboxSource = null;

            try
            {
                mDataFunc = new MasterDataFunctions();
                paColl = mDataFunc.LoadParticipentAssement(ParticiID);

                if (paColl != null)
                {
                    listboxSourcePartiQB = new Dictionary<string, string>();

                    txtPartiCode.Text = paColl[0].Participant.Code;
                    txtPartiName.Text = paColl[0].Participant.Name;
                    txtEmail.Text = paColl[0].Participant.Email;
                    txtRemarks.Text = paColl[0].Participant.Remarks;

                    rbMale.Checked = paColl[0].Participant.Gender == "M" ? true : false;
                    rbFemale.Checked = paColl[0].Participant.Gender == "F" ? true : false;
                    chkParticipentActive.Checked = paColl[0].Participant.Active;

                    cbParticipent.Items.Clear();
                    listboxSource = new Dictionary<string, string>();

                    foreach (ParticipantAssesment pa in paColl)
                    {
                        listboxSource.Add(pa.QuestionBank.ID, pa.QuestionBank.ExamName);
                        if (!selectedQBIDValue.ContainsKey(pa.QuestionBank.ID))
                            selectedQBIDValue.Add(pa.QuestionBank.ID, pa.QuestionBank.ExamName);
                    }

                    lstSelectedQB.DataSource = new BindingSource(listboxSource, null);
                    lstSelectedQB.DisplayMember = "Value";
                    lstSelectedQB.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnEditPartici_Click(object sender, EventArgs e)
        {
            string ParticiID = string.Empty;

            try
            {
                ParticiID = ((KeyValuePair<string, string>)cbParticipent.SelectedItem).Key;
                ResetAll();
                LoadPartiQB(ParticiID);
                LoadAllQB();
                LoadParticipentCombo();
                ParticipentQBEntityState = EntityOperationalState.Update;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddPatici_Click(object sender, EventArgs e)
        {
            string qbID = string.Empty;
            string qbValue = string.Empty;
            Dictionary<string, string> listboxSource = null;

            try
            {
                eidtedParticipentInfo.ParticeipentAssesmentEntityState = EntityOperationalState.Update;

                if (lstAvailableQB.SelectedItem != null)
                {
                    foreach (var lstItem in lstAvailableQB.Items)
                    {
                        qbID = ((KeyValuePair<string, string>)lstItem).Key;
                        qbValue = ((KeyValuePair<string, string>)lstItem).Value;

                        if (!selectedQBIDValue.ContainsKey(qbID))
                        {
                            selectedQBIDValue.Add(qbID, qbValue);
                        }
                    }

                    lstSelectedQB.DataSource = null;

                    listboxSource = new Dictionary<string, string>();

                    foreach (string gt in selectedQBIDValue.Keys)
                    {
                        listboxSource.Add(gt, selectedQBIDValue[gt]);
                    }

                    lstSelectedQB.DataSource = new BindingSource(listboxSource, null);
                    lstSelectedQB.DisplayMember = "Value";
                    lstSelectedQB.ValueMember = "Key";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btbnRemovePartici_Click(object sender, EventArgs e)
        {
            string qbID = string.Empty;
            string qbValue = string.Empty;
            Dictionary<string, string> listboxSource = null;

            try
            {
                eidtedParticipentInfo.ParticeipentAssesmentEntityState = EntityOperationalState.Update;

                if (lstSelectedQB.SelectedItem != null)
                {
                    for(int cnt=0;cnt < lstSelectedQB.SelectedItems.Count;cnt++)
                    {
                        qbID = ((KeyValuePair<string, string>)lstSelectedQB.SelectedItems[cnt]).Key;
                        qbValue = ((KeyValuePair<string, string>)lstAvailableQB.Items[cnt]).Value;

                        if (selectedQBIDValue.ContainsKey(qbID))
                            selectedQBIDValue.Remove(qbID);
                    }

                   // lstSelectedQB.Items.Clear();
                    lstSelectedQB.DataSource = null;

                    if (selectedQBIDValue != null && selectedQBIDValue.Count > 0)
                    {
                        listboxSource = new Dictionary<string, string>();

                        foreach (string gt in selectedQBIDValue.Keys)
                        {
                            listboxSource.Add(gt, selectedQBIDValue[gt]);
                        }

                        lstSelectedQB.DataSource = new BindingSource(listboxSource, null);
                        lstSelectedQB.DisplayMember = "Value";
                        lstSelectedQB.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
