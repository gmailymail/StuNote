using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuNote.Domain.Btos.Survey
{
    public class SurveyRequestQuestionBto
    {
        public string Question { get; set; }

        public int QuestionType { get; set; }

        public List<AnswerstringDetails> AnswerList { get; set; }

        public int SelectedAnswerID { get; set; }
    }

    public class AnswerstringDetails
    {
        public int AnswerId { get; set; }

        public string AnswerString { get; set; }
    }
}
