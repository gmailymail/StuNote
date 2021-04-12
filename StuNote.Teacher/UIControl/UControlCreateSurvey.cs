using DevExpress.XtraEditors;
using StuNote.Domain;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuNote.Teacher.UIControl
{
    public partial class UControlCreateSurvey : DevExpress.XtraEditors.XtraUserControl
    {
        public UControlCreateSurvey()
        {
            InitializeComponent();
        }

        private void UControlCreateSurvey_Load(object sender, EventArgs e)
        {
        }

        private void BtnSubmitQuestion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mEditYNQuestionText.Text.Trim()))
            {
                SurveyRequestQuestionBto question = new()
                {
                    QuestionType = (int)QuestionTypes.YesNo,
                    Question = mEditYNQuestionText.Text.Trim(),
                    SelectedAnswerID = radioGroupYNQuestAnswer.SelectedIndex
                };
            }
            else
            {
                //TODO : Error Message for null values
                XtraMessageBox.Show("Enter question text.");
            }
        }
    }
}
