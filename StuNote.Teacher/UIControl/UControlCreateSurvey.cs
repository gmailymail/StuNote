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
        private readonly ISurveyRequestService _surveyRequest;

        public UControlCreateSurvey(ISurveyRequestService surveyRequestService)
        {
            InitializeComponent();
            _surveyRequest = surveyRequestService;
        }

        private void UControlCreateSurvey_Load(object sender, EventArgs e)
        {
        }

        private async void BtnSubmitQuestion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mEditYNQuestionText.Text.Trim()) || string.IsNullOrEmpty(textEditAnswer1.Text.Trim()) || string.IsNullOrEmpty(textEditAnswer2.Text.Trim()))
            {
                SurveyRequestBto survey = new()
                {
                    Question = mEditYNQuestionText.Text.Trim(),
                    Answer1 = textEditAnswer1.Text.Trim(),
                    Answer2 = textEditAnswer2.Text.Trim()
                };
                await _surveyRequest.SendAsync(survey);
            }
            else
            {
                //TODO : Error Message for null values
                XtraMessageBox.Show("Enter question text and two answers.");
            }
        }
    }
}
