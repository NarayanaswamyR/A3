using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oELib;

namespace oEEntity
{
    public class QuestionModeEntity : IQuestionElement
    {
        public string ID {get; set;}
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class GroupTypeEntity : IQuestionElement
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class TopicTypeEntity : IQuestionElement
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public TopicTypeEntity ParentTopicType { get; set; }
    }

    public class QuestionEntity : IQuestion
    {
        public string ID { get; set; }
        public IQuestionNature Mode { get; set; }
        public IQuestionNature Type { get; set; }
        public string QuestionText { get; set; }
        public int ComplexLevel { get; set; }
        public List<AnswerEntity> Answers { get; set; }
    }

    public class AnswerEntity
    {
        public string ID { get; set; }
        public string QuestionID { get; set; }
        public string AnswerText { get; set; }
        public string Valid { get; set; }
    }

    public class ExamEntity
    {
        public string ID { get; set; }
        public string SubjectID { get; set; }
        public string ExamName { get; set; }
        public List<QuestionEntity> Questions { get; set; }
        public string Remarks { get; set; }
    }

    public class QuestionsInExamEntity
    {
        public string ID { get; set; }
        public string SubjectID { get; set; }
        public string ExamName { get; set; }
        public string Remarks { get; set; }
    }

    public class ParticipantEntity
    {
        public string ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string EMail { get; set; }
        public string Remarks { get; set; }
    }

    public class ParticipantAnswersEntity
    {
        public string ID { get; set; }
        public string ParticipantID { get; set; }
        public string ExamID { get; set; }
        public string QuestionID { get; set; }
        public string Answer { get; set; }
    }

    public class ParticipantAssesmentEntity
    {
        public string ParticipantAnswersID { get; set; }
        public List<AnswerEntity> Answer { get; set; }
        public bool AnswerState { get; set; }
        public string Comments { get; set; }
    }
}
