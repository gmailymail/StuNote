using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StuNote.Teacher
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyRequestService _surveyRequest;
        private readonly UControlCreateSurvey _uControlCreateSurvey;
        private readonly IQuestionRequestService _questionRequest;
        private List<SurveyResponseBto> _studentResponses = new List<SurveyResponseBto>();

        public FMain(
            ISurveyRequestService surveyRequest,
            UControlCreateSurvey uControlCreateSurvey,
            IQuestionRequestService questionRequest)
        {
            InitializeComponent();
            _surveyRequest = surveyRequest;
            _uControlCreateSurvey = uControlCreateSurvey;
            _questionRequest = questionRequest;
            _surveyRequest.ResponseReceived += _surveyRequest_ResponseReceived;
            
            questionRequest.AnswerReceived += (s, e) =>
            {

            };
        }

        /// <summary>
        /// Handle this event, everytime a student response to the survey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _surveyRequest_ResponseReceived(object sender, SurveyResponseBto e)
        {
            SurveyResponseBto oneResponse = new SurveyResponseBto() {
                Answer = e.Answer.Trim()
            };
            _studentResponses.Add(oneResponse);
        }

        private void elementPublishSurveys_Click(object sender, EventArgs e)
        {
            var controls = MainContainer.Controls.Find("UControlCreateSurvey",true);

            if (controls.Count() is 0)
            {
                MainContainer.Controls.Add(_uControlCreateSurvey);
                _uControlCreateSurvey.Dock = DockStyle.Fill;
            }
                
            MainContainer.Controls.SetChildIndex(_uControlCreateSurvey, 0);            
        }

        private void elementSignedStudents_Click(object sender, EventArgs e)
        {

        }

        private async void elementQuestionAnswers_Click(object sender, EventArgs e)
        {
            await _questionRequest.SendAsync(new Domain.Btos.Question.QuestionRequestBto
            {
                Question = "What is 2 + 2",
                Answer1 = "6",
                Answer2 = "3",
                Answer3 = "4",
                Answer4 = "8",
                CorrectAnswer = 2
            });
        }
    }
}
