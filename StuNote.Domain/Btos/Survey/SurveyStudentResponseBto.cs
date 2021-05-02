using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuNote.Domain.Btos.Survey
{
    public class SurveyStudentResponseBto
    {
        public int StudentId { get; set; }
        public string Answer { get; set; }

        public DateTime AnsweredTime { get; set; }
    }
}
