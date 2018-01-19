using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oEEntity;
using oEEntity.Base;
using oEEntity.Model;

namespace oELib
{
    public class MasterDataFunctions
    {
        private oExEntity oeEntity = null;

        public void saveXML(oExEntity oeEntity)
        {
            oeEntity.WriteXml(@"D:\ranganathanns\Shared\New Folder\oE\oEXML.xml");
        }

        public void LoadXML()
        {
            oeEntity = new oExEntity();
            oeEntity.ReadXml(@"D:\ranganathanns\Shared\New Folder\oE\oEXML.xml");
        }

        #region GROUP
        public void AddGroup(GroupType GroupType)
        {
            DataTable dtGroupType = null;
            DataRow drNew = null;

            try
            {
                LoadXML();
                dtGroupType = oeEntity.Tables[EntityConstents.TBL_GROUPTYPE];
                drNew = dtGroupType.NewRow();
                drNew[EntityConstents.COL_GROUPTYPE_ID] = Guid.NewGuid().ToString();
                drNew[EntityConstents.COL_GROUPTYPE_CODE] = GroupType.Code;
                drNew[EntityConstents.COL_GROUPTYPE_DESC] = GroupType.Description;
                dtGroupType.Rows.Add(drNew);
                saveXML(oeEntity);
            }
            catch
            {
            }
        }
        public void SaveGroup(GroupType GroupType)
        {
            DataTable dtGroupType = null;
            DataRow drNew = null;

            try
            {

                LoadXML();
                dtGroupType = oeEntity.Tables[EntityConstents.TBL_GROUPTYPE];
                if (GroupType.EntityState == EntityOperationalState.New)
                {
                    drNew = dtGroupType.NewRow();
                    drNew[EntityConstents.COL_ANSWERS_ID] = Guid.NewGuid().ToString();
                    dtGroupType.Rows.Add(drNew);
                }
                else
                    drNew = dtGroupType.AsEnumerable().Where(ans => ans.Field<string>("ID") == GroupType.ID).SingleOrDefault();

                drNew[EntityConstents.COL_GROUPTYPE_CODE] = GroupType.Code;
                drNew[EntityConstents.COL_GROUPTYPE_DESC] = GroupType.Description;

                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }

        public List<GroupType> LoadGroup()
        {
            DataTable dtGroupType = null;
            List<GroupType> groupTypeColl = null;
            GroupType groupType = null;

            try
            {
                LoadXML();
                dtGroupType = oeEntity.Tables[EntityConstents.TBL_GROUPTYPE];
                groupTypeColl = new List<GroupType>();
                foreach (DataRow dr in dtGroupType.Rows)
                {
                    groupType = new GroupType();

                    groupType.ID = dr[EntityConstents.COL_GROUPTYPE_ID].ToString();
                    groupType.Code = dr[EntityConstents.COL_GROUPTYPE_CODE].ToString();
                    groupType.Description = dr[EntityConstents.COL_GROUPTYPE_DESC].ToString();

                    groupTypeColl.Add(groupType);
                }
            }
            catch
            {
            }

            return groupTypeColl;
        }
        #endregion

        #region TOPIC
        public void AddTopic(TopicType TopicType)
        {
            DataTable dtTopicType = null;
            DataRow drNew = null;

            try
            {
                LoadXML();
                dtTopicType = oeEntity.Tables[EntityConstents.TBL_TOPICTYPE];
                drNew = dtTopicType.NewRow();
                drNew[EntityConstents.COL_TOPICTYPE_ID] = Guid.NewGuid().ToString();
                drNew[EntityConstents.COL_TOPICTYPE_CODE] = TopicType.Code;
                drNew[EntityConstents.COL_TOPICTYPE_DESC] = TopicType.Description;
                drNew[EntityConstents.COL_TOPICTYPE_GROUPTYPE] = TopicType.GroupType.ID;
                dtTopicType.Rows.Add(drNew);
                saveXML(oeEntity);
            }
            catch
            {
            }
        }

        public void SaveTopic(TopicType topicType, string groupTypeID)
        {
            DataTable dtTopicType = null;
            DataRow drNew = null;

            try
            {

                LoadXML();
                dtTopicType = oeEntity.Tables[EntityConstents.TBL_TOPICTYPE];
                if (topicType.EntityState == EntityOperationalState.New)
                {
                    drNew = dtTopicType.NewRow();
                    drNew[EntityConstents.COL_ANSWERS_ID] = Guid.NewGuid().ToString();
                    dtTopicType.Rows.Add(drNew);
                }
                else
                    drNew = dtTopicType.AsEnumerable().Where(ans => ans.Field<string>("ID") == topicType.ID).SingleOrDefault();

                drNew[EntityConstents.COL_TOPICTYPE_CODE] = topicType.Code;
                drNew[EntityConstents.COL_TOPICTYPE_DESC] = topicType.Description;
                drNew[EntityConstents.COL_TOPICTYPE_GROUPTYPE] = groupTypeID;

                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }
        public List<TopicType> LoadTopic(string GroupID)
        {
            DataTable dtTopicType = null;
            List<TopicType> topicTypeColl = null;
            List<GroupType> groupType = null;
            List<DataRow> topicdr = null;
            TopicType topicType = null;

            try
            {
                LoadXML();
                dtTopicType = oeEntity.Tables[EntityConstents.TBL_TOPICTYPE];
                if (!string.IsNullOrWhiteSpace(GroupID))
                    topicdr = dtTopicType.AsEnumerable().Where(topic => topic.Field<string>("Fk_GroupType") == GroupID).ToList();
                else
                    topicdr = dtTopicType.AsEnumerable().Select(dr => dr).ToList();

                topicTypeColl = new List<TopicType>();
                groupType = LoadGroup();

                foreach (DataRow dr in topicdr)
                {
                    topicType = new TopicType();

                    topicType.ID = dr[EntityConstents.COL_TOPICTYPE_ID].ToString();
                    topicType.Code = dr[EntityConstents.COL_TOPICTYPE_CODE].ToString();
                    topicType.Description = dr[EntityConstents.COL_TOPICTYPE_DESC].ToString();
                    topicType.GroupType = groupType.Where(group => group.ID == dr[EntityConstents.COL_TOPICTYPE_GROUPTYPE].ToString()).SingleOrDefault();

                    topicTypeColl.Add(topicType);
                }
            }
            catch
            {
            }

            return topicTypeColl;
        }
        #endregion

        #region QUESTIONMODE
        public void AddQuestionMode(QuestionMode QuestionMode)
        {
            DataTable dtQuestionMode = null;
            DataRow drNew = null;

            try
            {
                LoadXML();
                dtQuestionMode = oeEntity.Tables[EntityConstents.TBL_QUESTIONMODE];
                drNew = dtQuestionMode.NewRow();
                drNew[EntityConstents.COL_QUESTIONMODE_ID] = Guid.NewGuid().ToString();
                drNew[EntityConstents.COL_QUESTIONMODE_CODE] = QuestionMode.Code;
                drNew[EntityConstents.COL_QUESTIONMODE_DESC] = QuestionMode.Description;
                dtQuestionMode.Rows.Add(drNew);
                saveXML(oeEntity);
            }
            catch
            {
            }
        }
        public void SaveQuestionMode(QuestionMode quesMode)
        {
            DataTable dtQuesMode = null;
            DataRow drNew = null;

            try
            {

                LoadXML();
                dtQuesMode = oeEntity.Tables[EntityConstents.TBL_TOPICTYPE];
                if (quesMode.EntityState == EntityOperationalState.New)
                {
                    drNew = dtQuesMode.NewRow();
                    drNew[EntityConstents.COL_ANSWERS_ID] = Guid.NewGuid().ToString();
                    dtQuesMode.Rows.Add(drNew);
                }
                else
                    drNew = dtQuesMode.AsEnumerable().Where(ans => ans.Field<string>("ID") == quesMode.ID).SingleOrDefault();

                drNew[EntityConstents.COL_QUESTIONMODE_CODE] = quesMode.Code;
                drNew[EntityConstents.COL_QUESTIONMODE_DESC] = quesMode.Description;

                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }
        public List<QuestionMode> LoadMode()
        {
            DataTable dtMode = null;
            List<QuestionMode> modeColl = null;
            QuestionMode mode = null;

            try
            {
                LoadXML();
                dtMode = oeEntity.Tables[EntityConstents.TBL_QUESTIONMODE];
                modeColl = new List<QuestionMode>();
                foreach (DataRow dr in dtMode.Rows)
                {
                    mode = new QuestionMode();

                    mode.ID = dr[EntityConstents.COL_QUESTIONMODE_ID].ToString();
                    mode.Code = dr[EntityConstents.COL_QUESTIONMODE_CODE].ToString();
                    mode.Description = dr[EntityConstents.COL_QUESTIONMODE_DESC].ToString();

                    modeColl.Add(mode);
                }
            }
            catch
            {
            }

            return modeColl;
        }
        #endregion

        #region QUESTION NEW
        public string SaveQuestion(oEEntiti SaveQuestion)
        {
            DataTable dtQuestion = null;
            DataRow drNew = null;
            SaveQuestion saveQuestion = null;
            string questionID = string.Empty;

            try
            {
                saveQuestion = SaveQuestion as SaveQuestion;
                LoadXML();
                dtQuestion = oeEntity.Tables[EntityConstents.TBL_QUESTIONS];

                if (saveQuestion.EntityState == EntityOperationalState.New)
                {
                    drNew = dtQuestion.NewRow();
                    questionID = Guid.NewGuid().ToString();
                    drNew[EntityConstents.COL_QUESTIONS_ID] = questionID;
                    dtQuestion.Rows.Add(drNew);
                }
                else
                {
                    questionID = saveQuestion.ID;
                    drNew = dtQuestion.AsEnumerable().Where(ans => ans.Field<string>("ID") == saveQuestion.ID).SingleOrDefault();
                }

                drNew[EntityConstents.COL_QUESTIONS_QUESTION] = saveQuestion.Questionn;
                drNew[EntityConstents.COL_QUESTIONS_LEVEL] = saveQuestion.ComplexLevel;
                drNew[EntityConstents.COL_QUESTIONS_POINT] = saveQuestion.Point;
                drNew[EntityConstents.COL_QUESTIONS_QUESTIONMODE] = saveQuestion.QuestionModeID;

                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
            return questionID;
        }

        public void SaveQuestionRelation(oEEntiti SaveQuestionR)
        {
            DataTable dtQuestionR = null;
            DataRow drNew = null;
            SaveQuestionRelation saveQuestionR = null;

            try
            {
                LoadXML();
                saveQuestionR = SaveQuestionR as SaveQuestionRelation;
                dtQuestionR = oeEntity.Tables[EntityConstents.TBL_QUESTIONS_REL];

                if (saveQuestionR.EntityState == EntityOperationalState.New)
                {
                    drNew = dtQuestionR.NewRow();
                    dtQuestionR.Rows.Add(drNew);
                    drNew[EntityConstents.COL_QUESTIONS_REL_ID] = Guid.NewGuid().ToString();
                }
                else
                    drNew = dtQuestionR.AsEnumerable().Where(ans => ans.Field<string>("ID") == saveQuestionR.ID).SingleOrDefault();

                //drNew[EntityConstents.COL_QUESTIONS_REL_GROUPTYPE] = saveQuestionR.GroupTypeID;
                drNew[EntityConstents.COL_QUESTIONS_REL_TOPICTYPE] = saveQuestionR.TopicTypeID;
                drNew[EntityConstents.COL_QUESTIONS_REL_QUSID] = saveQuestionR.QuestionID;

                saveXML(oeEntity);
            }
            catch
            {
            }
        }

        public List<QuestionRelation> LoadQuestionsRelation(string TopicID)
        {
            DataTable dtQuestionsR = null;
            List<DataRow> drQuestionR = null;
            QuestionRelation questionR = null;
            List<QuestionRelation> questionRColl = null;
            List<Question> questionColl= null;
            List<GroupType> GroupTypeColl = null;
            List<TopicType> topicTypeColl = null;
            List<QuestionMode> quesModeColl = null;
            string groupID = string.Empty;
            string topicID = string.Empty;

            try
            {
                LoadXML();
                GroupTypeColl = LoadGroup();
                topicTypeColl = LoadTopic(string.Empty);
                quesModeColl = LoadMode();
                questionRColl = new List<QuestionRelation>();

                dtQuestionsR = oeEntity.Tables[EntityConstents.TBL_QUESTIONS_REL];

                drQuestionR = dtQuestionsR.AsEnumerable().Where(qr => qr.Field<string>("Fk_TopicType") == TopicID).ToList();

                List<string> questionIDs = drQuestionR.AsEnumerable().Select(qr => qr.Field<string>("Fk_Que_ID")).ToList();
                questionColl = LoadQuestion(questionIDs);

                foreach (DataRow dr in drQuestionR)
                {
                    //groupID = dr[EntityConstents.COL_QUESTIONS_REL_GROUPTYPE].ToString();
                    topicID = dr[EntityConstents.COL_QUESTIONS_REL_TOPICTYPE].ToString();

                    questionR = new QuestionRelation();
                    questionR.ID = dr[EntityConstents.COL_QUESTIONS_REL_ID].ToString();
                    questionR.Questionn = questionColl.Where(que => que.ID == dr[EntityConstents.COL_QUESTIONS_REL_QUSID].ToString()).SingleOrDefault();
                   // questionR.GroupType = GroupTypeColl.Where(gc => gc.ID == groupID).SingleOrDefault();
                    questionR.TopicType = topicTypeColl.Where(gc => gc.ID == topicID).SingleOrDefault();
                    questionRColl.Add(questionR);
                }
            }
            catch
            {
                throw;
            }
            return questionRColl;
        }
        #endregion

        #region QUESTION
        private void AddQuestionRelation(oEEntiti QuestionRelation)
        {
            DataTable dtQuestionRelation = null;
            DataRow drNew = null;
            QuestionRelation QuestionR = null;

            try
            {
                LoadXML();
                dtQuestionRelation = oeEntity.Tables[EntityConstents.TBL_QUESTIONS_REL];
                QuestionR = QuestionRelation as QuestionRelation;

                if (QuestionR.EntityState != EntityOperationalState.None)
                {
                    if (QuestionR.EntityState == EntityOperationalState.New)
                    {
                        drNew = dtQuestionRelation.NewRow();
                        dtQuestionRelation.Rows.Add(drNew);
                        drNew[EntityConstents.COL_QUESTIONS_ID] = Guid.NewGuid().ToString();
                    }
                    else
                        drNew = dtQuestionRelation.AsEnumerable().Where(ans => ans.Field<string>("ID") == QuestionR.ID).SingleOrDefault();

                    //drNew[EntityConstents.COL_QUESTIONS_REL_GROUPTYPE] = QuestionR.GroupType.ID;
                    drNew[EntityConstents.COL_QUESTIONS_REL_TOPICTYPE] = QuestionR.TopicType.ID;
                    drNew[EntityConstents.COL_QUESTIONS_REL_QUSID] = QuestionR.Questionn.ID;

                    saveXML(oeEntity);
                }
            }
            catch
            {
                throw;
            }
        }

        public void AddQuestion(oEEntiti QuestionRelationEntity)
        {
            DataTable dtQuestion = null;
            DataRow drNew = null;
            Question Question = null;
            QuestionRelation QuestionR = null;

            try
            {
                QuestionR = QuestionRelationEntity as QuestionRelation;
                Question = QuestionR.Questionn;

                if (QuestionR.EntityState != EntityOperationalState.None)
                    AddQuestionRelation(QuestionR);

                if (Question.EntityState != EntityOperationalState.None)
                {
                    LoadXML();
                    dtQuestion = oeEntity.Tables[EntityConstents.TBL_QUESTIONS];

                    if (Question.EntityState == EntityOperationalState.New)
                    {
                        drNew = dtQuestion.NewRow();
                        dtQuestion.Rows.Add(drNew);
                        drNew[EntityConstents.COL_QUESTIONS_ID] = Guid.NewGuid().ToString();
                    }
                    else
                        drNew = dtQuestion.AsEnumerable().Where(ans => ans.Field<string>("ID") == Question.ID).SingleOrDefault();

                    drNew[EntityConstents.COL_QUESTIONS_QUESTION] = Question.Questionn;
                    drNew[EntityConstents.COL_QUESTIONS_LEVEL] = Question.ComplexLevel;
                    drNew[EntityConstents.COL_QUESTIONS_POINT] = Question.Point;
                    drNew[EntityConstents.COL_QUESTIONS_QUESTIONMODE] = Question.QuestionMode.ID;

                    saveXML(oeEntity);
                }
            }
            catch
            {
            }
        }

        public List<Question> LoadQuestion()
        {
            DataTable dtQuestions = null;
            List<TopicType> topicTypeColl = null;
            List<QuestionMode> quesModeColl = null;

            List<Question> questionColl = null;
            Question question = null;
            string quesModeID = string.Empty;
            string topicTypeID = string.Empty;

            try
            {
                LoadXML();
                dtQuestions = oeEntity.Tables[EntityConstents.TBL_QUESTIONS];
                topicTypeColl = LoadTopic(string.Empty);
                quesModeColl = LoadMode();

                questionColl = new List<Question>();
                foreach (DataRow dr in dtQuestions.Rows)
                {
                    question = new Question();

                    question.ID = dr[EntityConstents.COL_QUESTIONS_ID].ToString();
                    question.Questionn = dr[EntityConstents.COL_QUESTIONS_QUESTION].ToString();
                    question.ComplexLevel = dr[EntityConstents.COL_QUESTIONS_LEVEL].ToString();
                    question.Point = dr[EntityConstents.COL_QUESTIONS_POINT].ToString();
                    quesModeID = dr[EntityConstents.COL_QUESTIONS_QUESTIONMODE].ToString();
                    //topicTypeID = dr[EntityConstents.COL_QUESTIONS_TOPICTYPE].ToString();
                    //question.TopicType = topicTypeColl.Where(tt => tt.ID == topicTypeID).FirstOrDefault();
                    question.QuestionMode = quesModeColl.Where(qm => qm.ID == quesModeID).FirstOrDefault();

                    questionColl.Add(question);
                }
            }
            catch
            {
            }

            return questionColl;
        }

        public List<Question> LoadQuestion(List<string> questionIDs)
        {
            DataTable dtQuestions = null;
            List<TopicType> topicTypeColl = null;
            List<QuestionMode> quesModeColl = null;

            List<Question> questionColl = null;
            Question question = null;
            string quesModeID = string.Empty;
            string topicTypeID = string.Empty;
            List<DataRow> drs = null;

            try
            {
                LoadXML();
                dtQuestions = oeEntity.Tables[EntityConstents.TBL_QUESTIONS];
                topicTypeColl = LoadTopic(string.Empty);
                quesModeColl = LoadMode();

                drs = dtQuestions.AsEnumerable().Where(que => questionIDs.Contains(que.Field<string>("ID"))).ToList();
                questionColl = new List<Question>();
                foreach (DataRow dr in drs)
                {
                    question = new Question();

                    question.ID = dr[EntityConstents.COL_QUESTIONS_ID].ToString();
                    question.Questionn = dr[EntityConstents.COL_QUESTIONS_QUESTION].ToString();
                    question.ComplexLevel = dr[EntityConstents.COL_QUESTIONS_LEVEL].ToString();
                    question.Point = dr[EntityConstents.COL_QUESTIONS_POINT].ToString();
                    quesModeID = dr[EntityConstents.COL_QUESTIONS_QUESTIONMODE].ToString();
                    //topicTypeID = dr[EntityConstents.COL_QUESTIONS_TOPICTYPE].ToString();
                    //question.TopicType = topicTypeColl.Where(tt => tt.ID == topicTypeID).FirstOrDefault();
                    question.QuestionMode = quesModeColl.Where(qm => qm.ID == quesModeID).FirstOrDefault();

                    questionColl.Add(question);
                }
            }
            catch
            {
            }

            return questionColl;
        }
        #endregion

        #region ANSWER
        public void AddAnswers(oEEntiti AnswerEntity, string QuestionID)
        {
            DataTable dtAnswer = null;
            DataRow drNew = null;
            Answer Answer = null;

            try
            {
                Answer = AnswerEntity as Answer;

                LoadXML();
                dtAnswer = oeEntity.Tables[EntityConstents.TBL_ANSWERS];
                if (Answer.EntityState == EntityOperationalState.New)
                {
                    drNew = dtAnswer.NewRow();
                    drNew[EntityConstents.COL_ANSWERS_ID] = Guid.NewGuid().ToString();
                    dtAnswer.Rows.Add(drNew);
                }
                else
                    drNew = dtAnswer.AsEnumerable().Where(ans => ans.Field<string>("ID") == Answer.ID).SingleOrDefault();
                
                drNew[EntityConstents.COL_ANSWERS_ANSWER] = Answer.Answerr;
                drNew[EntityConstents.COL_ANSWERS_QUESTION] = QuestionID;
                drNew[EntityConstents.COL_ANSWERS_VALUE] = Answer.Value;
 
                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }

        public void SaveAnswers(oEEntiti SaveAnswers)
        {
            DataTable dtAnswer = null;
            DataRow drNew = null;
            SaveAnswers Answer = null;

            try
            {
                Answer = SaveAnswers as SaveAnswers;

                LoadXML();
                dtAnswer = oeEntity.Tables[EntityConstents.TBL_ANSWERS];
                if (Answer.EntityState == EntityOperationalState.New)
                {
                    drNew = dtAnswer.NewRow();
                    drNew[EntityConstents.COL_ANSWERS_ID] = Guid.NewGuid().ToString();
                    dtAnswer.Rows.Add(drNew);
                }
                else
                    drNew = dtAnswer.AsEnumerable().Where(ans => ans.Field<string>("ID") == Answer.ID).SingleOrDefault();

                drNew[EntityConstents.COL_ANSWERS_ANSWER] = Answer.Answerr;
                drNew[EntityConstents.COL_ANSWERS_QUESTION] = Answer.QuestionID;
                drNew[EntityConstents.COL_ANSWERS_ORDER] = Answer.AnswerOrder;
                drNew[EntityConstents.COL_ANSWERS_VALUE] = Answer.Value;

                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }

        public List<Answer> LoadAnswers()
        {
            DataTable dtAnswer = null;
            List<Answer> answerColl = null;
            Answer answer = null;

            try
            {
                LoadXML();
                dtAnswer = oeEntity.Tables[EntityConstents.TBL_ANSWERS];
                answerColl = new List<Answer>();
                foreach (DataRow dr in dtAnswer.Rows)
                {
                    answer = new Answer();

                    answer.ID = dr[EntityConstents.COL_ANSWERS_ID].ToString();
                    answer.Answerr = dr[EntityConstents.COL_ANSWERS_ANSWER].ToString();
                    answer.Value = dr[EntityConstents.COL_ANSWERS_VALUE].ToString();

                    answerColl.Add(answer);
                }
            }
            catch
            {
            }

            return answerColl;
        }

        public List<Answer> LoadAnswersByQuestion(List<string> questionIDs)
        {
            DataTable dtAnswer = null;
            List<Answer> answerColl = null;
            List<DataRow> drColl = null;
            Answer answer = null;

            try
            {
                LoadXML();
                dtAnswer = oeEntity.Tables[EntityConstents.TBL_ANSWERS];
                drColl = dtAnswer.AsEnumerable().Where(ans => questionIDs.Contains(ans.Field<string>("Fk_Question"))).ToList();
                answerColl = new List<Answer>();

                foreach (DataRow dr in drColl)
                {
                    answer = new Answer();

                    answer.ID = dr[EntityConstents.COL_ANSWERS_ID].ToString();
                    answer.Answerr = dr[EntityConstents.COL_ANSWERS_ANSWER].ToString();
                    answer.AnswerOrder = dr[EntityConstents.COL_ANSWERS_ORDER].ToString();
                    answer.Value = dr[EntityConstents.COL_ANSWERS_VALUE].ToString();

                    answerColl.Add(answer);
                }
            }
            catch
            {
            }

            return answerColl;
        }

        public List<Answer> LoadAnswersByID(List<string> answerIDs)
        {
            DataTable dtAnswer = null;
            List<Answer> answerColl = null;
            List<DataRow> drColl = null;
            Answer answer = null;

            try
            {
                LoadXML();
                dtAnswer = oeEntity.Tables[EntityConstents.TBL_ANSWERS];
                drColl = dtAnswer.AsEnumerable().Where(ans => answerIDs.Contains(ans.Field<string>("ID"))).ToList();
                answerColl = new List<Answer>();

                foreach (DataRow dr in drColl)
                {
                    answer = new Answer();

                    answer.ID = dr[EntityConstents.COL_ANSWERS_ID].ToString();
                    answer.Answerr = dr[EntityConstents.COL_ANSWERS_ANSWER].ToString();
                    answer.AnswerOrder = dr[EntityConstents.COL_ANSWERS_ORDER].ToString();
                    answer.Value = dr[EntityConstents.COL_ANSWERS_VALUE].ToString();

                    answerColl.Add(answer);
                }
            }
            catch
            {
            }

            return answerColl;
        }
        #endregion

        #region QUESTIONBANK
        public void AddQuestionBank(oEEntiti Qbinfo)
        {
            DataTable dtQuestionBank = null;
            DataTable dtQBQuestions = null;
            DataRow drNewQB = null;
            DataRow drNewQBRel = null;
            List<DataRow> drNewQBRelColl = null;
            QBInfo qbinfo = null;
            string qbID = string.Empty;

            try
            {
                qbinfo = Qbinfo as QBInfo;

                LoadXML();
                dtQuestionBank = oeEntity.Tables[EntityConstents.TBL_QUESTIONSBANK];
                dtQBQuestions = oeEntity.Tables[EntityConstents.TBL_QUESTIONSBANK_QUES];

                if (qbinfo.EntityState == EntityOperationalState.New)
                {
                    drNewQB = dtQuestionBank.NewRow();
                    drNewQB[EntityConstents.COL_QUESTIONSBANK_ID] = Guid.NewGuid().ToString();
                }
                else
                {
                    drNewQB = dtQuestionBank.AsEnumerable().Where(ans => ans.Field<string>("ID") == qbinfo.ID).SingleOrDefault();
                }

                qbID = drNewQB[EntityConstents.COL_QUESTIONSBANK_ID].ToString();
                drNewQB[EntityConstents.COL_QUESTIONSBANK_EXAMNAME] = qbinfo.QBName;
                drNewQB[EntityConstents.COL_QUESTIONSBANK_REMARKS] = qbinfo.Remarks;

                if (qbinfo.EntityState == EntityOperationalState.New)
                    dtQuestionBank.Rows.Add(drNewQB);

                if (qbinfo.QBQuestionsEntityState == EntityOperationalState.New || qbinfo.QBQuestionsEntityState == EntityOperationalState.Update)
                {
                    if (qbinfo.QBQuestionsEntityState == EntityOperationalState.Update)
                    {
                        drNewQBRelColl = dtQBQuestions.AsEnumerable().Where(ans => ans.Field<string>("Fk_Question_Bank") == qbID).ToList();
                        if (drNewQBRelColl != null && drNewQBRelColl.Count > 0)
                        {
                            for (int cnt = drNewQBRelColl.Count-1; cnt >= 0; cnt--)
                            {
                                dtQBQuestions.Rows.Remove(drNewQBRelColl[cnt]);
                            }
                        }
                    }

                    foreach (QBQuestions qbq in qbinfo.QBQuestions)
                    {
                        drNewQBRel = dtQBQuestions.NewRow();
                        drNewQBRel[EntityConstents.COL_QUESTIONSBANK_QUES_ID] = Guid.NewGuid().ToString();
                        drNewQBRel[EntityConstents.COL_QUESTIONSBANK_QUES_REL_ID] = qbq.Question_Rel_ID;
                        drNewQBRel[EntityConstents.COL_QUESTIONSBANK_QUES_BANK_ID] = qbID;
                        drNewQBRel[EntityConstents.COL_QUESTIONSBANK_QUES_ORDER] = qbq.Order;
                        dtQBQuestions.Rows.Add(drNewQBRel);
                    }
                }
                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }

        public List<ParticipantAssesment> LoadParticipentAssement(string ParticipentID)
        {
            DataTable dtQuestionBank = null;
            DataTable dtParticipentAssesment = null;
            DataTable dtParticipent = null;
            List<ParticipantAssesment> paColl = null;

            try
            {
                LoadXML();
                dtQuestionBank = oeEntity.Tables[EntityConstents.TBL_QUESTIONSBANK];
                dtParticipentAssesment = oeEntity.Tables[EntityConstents.TBL_PARTICIPANTASSESMENT];
                dtParticipent = oeEntity.Tables[EntityConstents.TBL_PARTICIPANT];

                paColl = (from pa in dtParticipentAssesment.AsEnumerable()
                          where pa.Field<string>("Fk_Participant") == ParticipentID
                          select new ParticipantAssesment
                          {
                              ID = pa.Field<string>("ID"),
                              QuestionBank = (from qb in dtQuestionBank.AsEnumerable()
                                              where qb.Field<string>("ID") == pa.Field<string>("Fk_QuesBank")
                                              select new QuestionBank
                                              {
                                                  ID = qb.Field<string>("ID"),
                                                  ExamName = qb.Field<string>("ExamName"),
                                                  Remarks = qb.Field<string>("Remarks"),
                                              }).FirstOrDefault(),
                              Participant = (from parti in dtParticipent.AsEnumerable()
                                             where parti.Field<string>("ID") == ParticipentID
                                             select new Participant
                                             {
                                                 ID = parti.Field<string>("ID"),
                                                 Code = parti.Field<string>("Code"),
                                                 Name = parti.Field<string>("Name"),
                                                 Gender = parti.Field<string>("Gender"),
                                                 Email = parti.Field<string>("Email"),
                                                 Active = parti.Field<string>("Active") == "True" ? true : false,
                                                 Remarks = parti.Field<string>("Remarks"),
                                             }).FirstOrDefault(),
                          }).ToList();
            }
            catch
            {
                throw;
            }

            return paColl;
        }

        public List<QuestionBank> LoadQuestionBank()
        {
            DataTable dtQuestionBank = null;
            List<QuestionBank> qbColl = null;

            try
            {
                LoadXML();
                dtQuestionBank = oeEntity.Tables[EntityConstents.TBL_QUESTIONSBANK];
                qbColl = (from qb in dtQuestionBank.AsEnumerable()
                select new QuestionBank {
                    ID =
                                 qb.Field<string>("ID"),
                    ExamName =
                                 qb.Field<string>("ExamName"),
                    Remarks =
                                 qb.Field<string>("Remarks"),
                }).ToList();
            }
            catch
            {
                throw;
            }

            return qbColl;
        }
        public List<QuestionBank> LoadQuestionBank(string QbID)
        {
            DataTable dtQuestionBank = null;
            DataTable dtQBQuestions = null;
            DataTable dtQuestionRel = null;
            DataTable dtGroupType = null;
            DataTable dtTopicType = null;
            DataTable dtQuestion = null;
            DataTable dtQuestionMode = null;
            DataTable dtAnswer = null;

            string questionBankID = string.Empty;
            string questionID = string.Empty;
            string ExamName = string.Empty;
            string Remarks = string.Empty;

            List<string> qbIdColl = null;
            List<DataRow> drs = null;
            List<QuestionBank> qbColl = null;

            try
            {
                LoadXML();
                dtQuestionBank = oeEntity.Tables[EntityConstents.TBL_QUESTIONSBANK];
                dtQBQuestions = oeEntity.Tables[EntityConstents.TBL_QUESTIONSBANK_QUES];
                dtQuestionRel = oeEntity.Tables[EntityConstents.TBL_QUESTIONS_REL];
                dtGroupType = oeEntity.Tables[EntityConstents.TBL_GROUPTYPE];
                dtTopicType = oeEntity.Tables[EntityConstents.TBL_TOPICTYPE];
                dtQuestion = oeEntity.Tables[EntityConstents.TBL_QUESTIONS];
                dtQuestionMode = oeEntity.Tables[EntityConstents.TBL_QUESTIONMODE];
                dtAnswer = oeEntity.Tables[EntityConstents.TBL_ANSWERS];

                qbIdColl = new List<string>();


                if (dtQuestionBank != null && dtQuestionBank.Rows.Count > 0)
                {
                    qbColl =
                        (from qb in dtQuestionBank.AsEnumerable()
                         where qb.Field<string>("ID") == QbID
                         select new QuestionBank
                         {
                             ID =
                                 qb.Field<string>("ID"),
                             ExamName =
                                 qb.Field<string>("ExamName"),
                             Remarks =
                                 qb.Field<string>("Remarks"),
                             Questions = (from qbqq in dtQBQuestions.AsEnumerable()
                                          where qbqq.Field<string>("Fk_Question_Bank") == qb.Field<string>("ID")
                                          select new QuestionBankQuestions
                                          {
                                              ID = qbqq.Field<string>("ID"),
                                              Order = qbqq.Field<string>("QuestionOrder"),
                                              QuestionRelation = (from qr in dtQuestionRel.AsEnumerable()
                                                                  where qr.Field<string>("ID") == qbqq.Field<string>("Fk_Question_Rel")
                                                                  select new QuestionRelation
                                                                  {
                                                                      ID = qr.Field<string>("ID"),
                                                                      TopicType = (from tt in dtTopicType.AsEnumerable()
                                                                                   where tt.Field<string>("ID") == qr.Field<string>("Fk_TopicType")
                                                                                   select new TopicType
                                                                                   {
                                                                                       ID = tt.Field<string>("ID"),
                                                                                       Code = tt.Field<string>("CODE"),
                                                                                       Description = tt.Field<string>("Description"),
                                                                                       GroupType = (from gt in dtGroupType.AsEnumerable()
                                                                                                    where gt.Field<string>("ID") == tt.Field<string>("Fk_GroupType")
                                                                                                    select new GroupType
                                                                                                    {
                                                                                                        ID = gt.Field<string>("ID"),
                                                                                                        Code = tt.Field<string>("Code"),
                                                                                                        Description = tt.Field<string>("Description")
                                                                                                    }).SingleOrDefault()
                                                                                   }).FirstOrDefault(),
                                                                      Questionn = (from que in dtQuestion.AsEnumerable()
                                                                                   where que.Field<string>("ID") == qr.Field<string>("Fk_Que_ID")
                                                                                   select new Question
                                                                                   {
                                                                                       ID = que.Field<string>("ID"),
                                                                                       ComplexLevel = que.Field<string>("ComplexLevel"),
                                                                                       Point = que.Field<string>("Point"),
                                                                                       Questionn = que.Field<string>("Question"),
                                                                                       QuestionMode = (from qm in dtQuestion.AsEnumerable()
                                                                                                       where qm.Field<string>("ID") == que.Field<string>("Fk_QuestionMode")
                                                                                                       select new QuestionMode
                                                                                                       {
                                                                                                           ID = qm.Field<string>("ID"),
                                                                                                           Code = qm.Field<string>("Code"),
                                                                                                           Description = qm.Field<string>("Description"),
                                                                                                       }).FirstOrDefault(),
                                                                                       Answers = (from ans in dtAnswer.AsEnumerable()
                                                                                                  where ans.Field<string>("Fk_Question") == que.Field<string>("ID")
                                                                                                  select new Answer
                                                                                                  {
                                                                                                      ID = ans.Field<string>("ID"),
                                                                                                      AnswerOrder = ans.Field<string>("AnswerOrder"),
                                                                                                      Answerr = ans.Field<string>("Answer"),
                                                                                                      Value = ans.Field<string>("Value"),
                                                                                                  }).ToList()
                                                                                   }).FirstOrDefault()
                                                                  }).FirstOrDefault()
                                          }).ToList()
                         }).ToList();
                    int i = 10;
                    //IEnumerable<QuestionBank> qbEnumerable = ii.Select(qb => qb).FirstOrDefault();
                    //qbColl = qbEnumerable.ToList();
                }
            }
            catch
            {
                throw;
            }

            return qbColl;
        }
        #endregion

        #region PARTICIPANT
        public void AddParticipant(oEEntiti Participant)
        {
            DataTable dtParticipant = null;
            DataTable dtParticipantAssesment = null;
            DataRow drNew = null;
            DataRow drNewPartiAss = null;
            List<DataRow> drParticepentColl = null;
            //Participant participant = null;
            ParticeipentInfo particeipentInfo = null;
            string participentID = string.Empty;

            try
            {
                particeipentInfo = Participant as ParticeipentInfo;
                LoadXML();
                dtParticipant = oeEntity.Tables[EntityConstents.TBL_PARTICIPANT];
                dtParticipantAssesment = oeEntity.Tables[EntityConstents.TBL_PARTICIPANTASSESMENT];

                if (particeipentInfo.EntityState == EntityOperationalState.New)
                {
                    drNew = dtParticipant.NewRow();
                    participentID = Guid.NewGuid().ToString();
                    drNew[EntityConstents.COL_PARTICIPANT_ID] = participentID;
                    dtParticipant.Rows.Add(drNew);
                }
                else
                {
                    participentID = particeipentInfo.ID;
                    drNew = dtParticipant.AsEnumerable().Where(ans => ans.Field<string>("ID") == particeipentInfo.ID).SingleOrDefault();
                }

                drNew[EntityConstents.COL_PARTICIPANT_CODE] = particeipentInfo.Code;
                drNew[EntityConstents.COL_PARTICIPANT_NAME] = particeipentInfo.Name;
                drNew[EntityConstents.COL_PARTICIPANT_ACTIVE] = particeipentInfo.Active;
                drNew[EntityConstents.COL_PARTICIPANT_EMAIL] = particeipentInfo.Email;
                drNew[EntityConstents.COL_PARTICIPANT_GENDER] = particeipentInfo.Gender;
                drNew[EntityConstents.COL_PARTICIPANT_REMARKS] = particeipentInfo.Remarks;

                if (particeipentInfo.ParticeipentAssesmentEntityState == EntityOperationalState.New || particeipentInfo.ParticeipentAssesmentEntityState == EntityOperationalState.Update)
                {
                    if (particeipentInfo.ParticeipentAssesmentEntityState == EntityOperationalState.Update)
                    {
                        drParticepentColl = dtParticipantAssesment.AsEnumerable().Where(partiass => partiass.Field<string>("Fk_Participant") == participentID).ToList();
                        if (drParticepentColl != null && drParticepentColl.Count > 0)
                        {
                            for (int cnt = drParticepentColl.Count; cnt >= 0; cnt--)
                            {
                                dtParticipantAssesment.Rows.Remove(drParticepentColl[cnt]);
                            }
                        }
                    }

                    foreach (string qbID in particeipentInfo.QBIds)
                    {
                        drNewPartiAss = dtParticipantAssesment.NewRow();
                        drNewPartiAss[EntityConstents.COL_PARTICIPANTASSESMENT_ID] = Guid.NewGuid().ToString();
                        drNewPartiAss[EntityConstents.COL_PARTICIPANTASSESMENT_QUESTIONBANK] = qbID;
                        drNewPartiAss[EntityConstents.COL_PARTICIPANTASSESMENT_PARTICIPANT] = participentID;
                        dtParticipantAssesment.Rows.Add(drNewPartiAss);
                    }
                }

                saveXML(oeEntity);
            }
            catch
            {
                throw;
            }
        }

        public List<Participant> LoadParticipents()
        {
            DataTable dtPArticipent = null;
            List<Participant> participentColl = null;
            Participant participant = null;

            try
            {
                LoadXML();
                dtPArticipent = oeEntity.Tables[EntityConstents.TBL_PARTICIPANT];
                participentColl = new List<Participant>();
                foreach (DataRow dr in dtPArticipent.Rows)
                {
                    participant = new Participant();

                    participant.ID = dr[EntityConstents.COL_PARTICIPANT_ID].ToString();
                    participant.Code = dr[EntityConstents.COL_PARTICIPANT_CODE].ToString();
                    participant.Name = dr[EntityConstents.COL_PARTICIPANT_NAME].ToString();

                    participentColl.Add(participant);
                }
            }
            catch
            {
            }

            return participentColl;
        }
        #endregion

        #region PARTICIPANTASSESMENT
        public void AddParticipantAssesment(ParticipantAssesment ParticipantAssesment)
        {
            DataTable dtParticipantAssesment = null;
            DataRow drNew = null;

            try
            {
                LoadXML();
                dtParticipantAssesment = oeEntity.Tables[EntityConstents.TBL_PARTICIPANTASSESMENT];
                drNew = dtParticipantAssesment.NewRow();
                drNew[EntityConstents.COL_PARTICIPANTASSESMENT_ID] = Guid.NewGuid().ToString();
                drNew[EntityConstents.COL_PARTICIPANTASSESMENT_PARTICIPANT] = ParticipantAssesment.Participant;
                drNew[EntityConstents.COL_PARTICIPANTASSESMENT_QUESTIONBANK] = ParticipantAssesment.QuestionBank;
                drNew[EntityConstents.COL_PARTICIPANTASSESMENT_REMARKS] = ParticipantAssesment.Remarks;

                dtParticipantAssesment.Rows.Add(drNew);
                saveXML(oeEntity);
            }
            catch
            {
            }
        }
        #endregion

        #region PARTICIPANTANSWER
        public void AddParticipantAnswer(ParticipantAnswer ParticipantAnswer)
        {
            DataTable dtParticipantAnswer = null;
            DataRow drNew = null;

            try
            {
                LoadXML();
                dtParticipantAnswer = oeEntity.Tables[EntityConstents.TBL_PARTICIPANTANSWER];
                drNew = dtParticipantAnswer.NewRow();
                drNew[EntityConstents.COL_PARTICIPANTANSWER_ID] = Guid.NewGuid().ToString();
                drNew[EntityConstents.COL_PARTICIPANTANSWER_ANSWER] = ParticipantAnswer.Answer;
                drNew[EntityConstents.COL_PARTICIPANTANSWER_PARTICIPANTASSESMENT] = ParticipantAnswer.ParticipantAssesment;
                //drNew[EntityConstents.COL_PARTICIPANTANSWER_QUESTION] = ParticipantAnswer.Question;

                dtParticipantAnswer.Rows.Add(drNew);
                saveXML(oeEntity);
            }
            catch
            {
            }
        }
        #endregion
    }
}
