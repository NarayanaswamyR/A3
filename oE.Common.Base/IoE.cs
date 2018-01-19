using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oELib
{
    public interface IQuestionNature
    {
        bool Create(IQuestionElement QuestInfo);
    }

    public interface IQuestionElement
    {
        string ID { get; set; }
    }

    public interface IQuestionMode
    {
        string QuestionModeID { get; set; }
        string Code { get; set; }
    }

    public interface IQuestionType
    {
        string QuestionTypeID { get; set; }
        string Code { get; set; }
    }

    public interface IQuestion
    {
        string ID { get; set; }
        IQuestionNature Mode { get; set; }
        IQuestionNature Type { get; set; }
    }

    public interface IAnswer
    {
        IQuestion Question { get; set; }
        void CreateAnswer();
        bool Valid { get; set; }
    }

    
}
