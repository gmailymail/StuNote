using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;

namespace StuNote.Teacher
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyRequestService _surveyRequest;
        public SurveyRequestQuestionBto questionBto;

        public FMain(ISurveyRequestService surveyRequest)
        {
            InitializeComponent();
            _surveyRequest = surveyRequest;
            _surveyRequest.ResponseReceived += _surveyRequest_ResponseReceived;
        }

        /// <summary>
        /// Handle this event, everytime a student response to the survey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _surveyRequest_ResponseReceived(object sender, SurveyResponseBto e)
        {
           
        }

        private async void elementPublishSurveys_Click(object sender, EventArgs e)
        {
            //UControlCreateSurvey ucCreateSurv = new UControlCreateSurvey();
            //this.MainContainer.Controls.Add(ucCreateSurv);
            //ucCreateSurv.Dock = DockStyle.Fill;

            //SurveyRequestBto survey = new()
            //{
            //    Question = "Do you like MSc IT in ICBT?",
            //    Answer1 = "Yes",
            //    Answer2 = "No"
            //};

            //await _surveyRequest.SendAsync(survey);

            UControlCreateSurvey ucCreateSurv = new UControlCreateSurvey();
            this.MainContainer.Controls.Add(ucCreateSurv);
            ucCreateSurv.Dock = DockStyle.Fill;

            SurveyRequestQuestionBto question = new()
            {
                QuestionType = (int)QuestionTypes.YesNo,
                Question = "TestQuestion",
                SelectedAnswerID = 1
            };

            await _surveyRequest.SendAsync2(question);
        }

        private void elementSignedStudents_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            UControlCreateSurvey ucCreateSurv = new UControlCreateSurvey();
            this.MainContainer.Controls.Add(ucCreateSurv);
        }
    }
}
