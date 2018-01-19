using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oEEntity.Base;

namespace oEEntity.Model
{
    public abstract class oEEntiti : IoEBase
    {
        public EntityOperationalState EntityState { get; set; }
    }

    public class GroupType : oEEntiti
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class TopicType : oEEntiti
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public GroupType GroupType { get; set; }
    }

    public class QuestionMode : oEEntiti
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class Question : oEEntiti
    {
        public string ID { get; set; }
        public string Questionn { get; set; }
        public string ComplexLevel { get; set; }
        public string Point { get; set; }
        public QuestionMode QuestionMode { get; set; }
        public List<Answer> Answers { get; set; }
    }

    public class QuestionRelation : oEEntiti
    {
        public string ID { get; set; }
        public Question Questionn { get; set; }
        public TopicType TopicType { get; set; }
    }

    public class QuestionBank : oEEntiti
    {
        public string ID { get; set; }
        public string ExamName { get; set; }
        public string Remarks { get; set; }
        public List<QuestionBankQuestions> Questions { get; set; }
    }

    public class QuestionBankQuestions : oEEntiti
    {
        public string ID { get; set; }
        public QuestionRelation QuestionRelation { get; set; }
        public QuestionBank QuestionBank { get; set; }

        public string Order { get; set; }
    }

    public class Answer : oEEntiti
    {
        public string ID { get; set; }
        public string Answerr { get; set; }
        public string AnswerOrder { get; set; }
        public string Value { get; set; }
    }

    public class Participant : oEEntiti
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public bool Active { get; set; }
    }

    public class ParticipantAssesment : oEEntiti
    {
        public string ID { get; set; }
        public QuestionBank QuestionBank { get; set; }
        public Participant Participant { get; set; }
        public string Remarks { get; set; }
    }

    public class ParticipantAnswer : oEEntiti
    {
        public string ID { get; set; }
        public ParticipantAssesment ParticipantAssesment { get; set; }
        public QuestionRelation QuestionR { get; set; }
        public string Answer { get; set; }
        public string Value { get; set; }
    }

}
