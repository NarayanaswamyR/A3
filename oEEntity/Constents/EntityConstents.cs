using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oEEntity
{
    public static class EntityConstents
    {
        //Tables
        public const string TBL_GROUPTYPE = "GroupType";

        //Columns
        public const string COL_GROUPTYPE_ID = "ID";
        public const string COL_GROUPTYPE_CODE = "Code";
        public const string COL_GROUPTYPE_DESC = "Description";

        //Tables
        public const string TBL_TOPICTYPE = "TopicType";

        //Columns
        public const string COL_TOPICTYPE_ID = "ID";
        public const string COL_TOPICTYPE_CODE = "Code";
        public const string COL_TOPICTYPE_DESC = "Description";
        public const string COL_TOPICTYPE_GROUPTYPE = "Fk_GroupType";

        //Tables
        public const string TBL_QUESTIONMODE = "QuestionMode";

        //Columns
        public const string COL_QUESTIONMODE_ID = "ID";
        public const string COL_QUESTIONMODE_CODE = "Code";
        public const string COL_QUESTIONMODE_DESC = "Description";

        //Tables
        public const string TBL_QUESTIONS = "Questions";

        //Columns
        public const string COL_QUESTIONS_ID = "ID";
        public const string COL_QUESTIONS_QUESTION = "Question";
        public const string COL_QUESTIONS_LEVEL = "ComplexLevel";
        public const string COL_QUESTIONS_POINT = "Point";
        public const string COL_QUESTIONS_QUESTIONMODE = "Fk_QuestionMode";

        //Tables
        public const string TBL_QUESTIONS_REL = "QuestionRelation";

        //Columns
        public const string COL_QUESTIONS_REL_ID = "ID";
        public const string COL_QUESTIONS_REL_QUSID = "Fk_Que_ID";
        public const string COL_QUESTIONS_REL_GROUPTYPE = "Fk_GroupType";
        public const string COL_QUESTIONS_REL_TOPICTYPE = "Fk_TopicType";

        //Tables
        public const string TBL_ANSWERS = "Answers";

        //Columns
        public const string COL_ANSWERS_ID = "ID";
        public const string COL_ANSWERS_ANSWER = "Answer";
        public const string COL_ANSWERS_ORDER = "AnswerOrder";
        public const string COL_ANSWERS_VALUE = "Value";
        public const string COL_ANSWERS_QUESTION = "Fk_Question";

        //Tables
        public const string TBL_QUESTIONSBANK = "QuestionsBank";
        public const string TBL_QUESTIONSBANK_QUES = "QuestionBankQuestions"; 

        //Columns
        public const string COL_QUESTIONSBANK_ID = "ID";
        public const string COL_QUESTIONSBANK_EXAMNAME = "ExamName";
        public const string COL_QUESTIONSBANK_REMARKS = "Remarks";

        public const string COL_QUESTIONSBANK_QUES_ID = "ID";
        public const string COL_QUESTIONSBANK_QUES_REL_ID = "Fk_Question_Rel";
        public const string COL_QUESTIONSBANK_QUES_BANK_ID = "Fk_Question_Bank";
        public const string COL_QUESTIONSBANK_QUES_ORDER = "QuestionOrder";

        //Tables
        public const string TBL_PARTICIPANT = "Participant";

        //Columns
        public const string COL_PARTICIPANT_ID = "ID";
        public const string COL_PARTICIPANT_CODE = "Code";
        public const string COL_PARTICIPANT_NAME = "Name";
        public const string COL_PARTICIPANT_GENDER = "Gender";
        public const string COL_PARTICIPANT_EMAIL = "EMail";
        public const string COL_PARTICIPANT_REMARKS = "Remarks";
        public const string COL_PARTICIPANT_ACTIVE = "Active";

        //Tables
        public const string TBL_PARTICIPANTASSESMENT = "ParticipantAssesment";

        //Columns
        public const string COL_PARTICIPANTASSESMENT_ID = "ID";
        public const string COL_PARTICIPANTASSESMENT_QUESTIONBANK = "Fk_QuesBank";
        public const string COL_PARTICIPANTASSESMENT_PARTICIPANT = "Fk_Participant";
        public const string COL_PARTICIPANTASSESMENT_REMARKS = "Remarks";

        //Tables
        public const string TBL_PARTICIPANTANSWER = "ParticipantAnswer";

        //Columns
        public const string COL_PARTICIPANTANSWER_ID = "ID";
        public const string COL_PARTICIPANTANSWER_PARTICIPANTASSESMENT = "Fk_ParticipantAssesment";
        public const string COL_PARTICIPANTANSWER_QUESTION = "Fk_Question";
        public const string COL_PARTICIPANTANSWER_ANSWER = "Answer";
    }
}
