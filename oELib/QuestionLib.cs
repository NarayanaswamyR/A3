using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oEEntity;

namespace oELib
{
    public abstract class QuestionNature : IQuestionNature
    {
        public abstract bool Create(IQuestionElement QuestElements);
    }

    public class ElementQuestionMode : QuestionNature
    {
        public override bool Create(IQuestionElement QuestMode)
        {
            bool isCreated = false;
            QuestionModeEntity l_QuestionMode = QuestMode as QuestionModeEntity;

            try
            {
            }
            catch
            {
                throw;
            }

            return isCreated;
        }
    }

    public class ElemetsTopicType : QuestionNature
    {
        public override bool Create(IQuestionElement QuestType)
        {
            bool isCreated = false;
            TopicTypeEntity l_QuestionType = QuestType as TopicTypeEntity;

            try
            {
            }
            catch
            {
                throw;
            }

            return isCreated;
        }
    }

    public class ElemetsGroupType : QuestionNature
    {
        public override bool Create(IQuestionElement QuestType)
        {
            bool isCreated = false;
            GroupTypeEntity l_QuestionType = QuestType as GroupTypeEntity;

            try
            {
            }
            catch
            {
                throw;
            }

            return isCreated;
        }
    }

    public class QuestionElementsHelper
    {
        private IQuestionElement l_QuestElement = null;
        private IQuestionNature l_QuestNature = null;

        public QuestionElementsHelper(IQuestionElement QuestElement)
        {
            if (QuestElement != null)
                l_QuestElement = QuestElement;
        }

        public void Create()
        {
            try
            {
                switch (l_QuestNature.GetType().ToString())
                {
                    case "QuestionModeEntity":
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                throw;
            }
        }

        private void CreateQuestion()
        {
            try
            {
            }
            catch
            {
                throw;
            }
        }

        private void CreateAnswer(string QuestionID)
        {
            try
            {
            }
            catch
            {
                throw;
            }
        }
    }

    public class CommonOperatoins
    {
    }
}
