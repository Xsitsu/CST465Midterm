using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm
{
    public class QuestionBank
    {
        public IList<Question> Questions { get; set; }

        public List<TestQuestion> ToTestQuestions()
        {
            List<TestQuestion> questions = new List<TestQuestion>();
            foreach (Question q in Questions)
            {
                questions.Add(q.ToQuestion());
            }
            return questions;
        }
    }

    public class Question
    {
        public int id { get; set; }
        public string type { get; set; }
        public string question { get; set; }
        public IList<string> choices { get; set; }

        public TestQuestion ToQuestion()
        {
            if (type == "TrueFalseQuestion")
            {
                return new TrueFalseQuestion() { ID = id, Question = question };
            }
            else if (type == "ShortAnswerQuestion")
            {
                return new ShortAnswerQuestion() { ID = id, Question = question };
            }
            else if (type == "LongAnswerQuestion")
            {
                return new LongAnswerQuestion() { ID = id, Question = question };
            }
            else if (type == "MultipleChoiceQuestion")
            {
                return new MultipleChoiceQuestion() { ID = id, Question = question , Choices = choices};
            }
            else
            {
                return null;
            }
        }
    }
}
