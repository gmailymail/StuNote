using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StuNote.Teacher
{
    public partial class FMain2 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly UControlCreateSurvey _uControlCreateSurvey;
        private readonly UControlCreateQandA _uControlCreateQandA;
        private readonly IQuestionRequestService _questionRequest;
        private List<SurveyResponseBto> _studentResponses = new List<SurveyResponseBto>();

        public FMain2(
            ISurveyRequestService surveyRequest,
            UControlCreateSurvey uControlCreateSurvey, UControlCreateQandA uControlCreateQandA,
            IQuestionRequestService questionRequest)
        {
            InitializeComponent();
            _uControlCreateSurvey = uControlCreateSurvey;
            _uControlCreateQandA = uControlCreateQandA;
            _questionRequest = questionRequest;
            //_surveyRequest.ResponseReceived += _surveyRequest_ResponseReceived;

            questionRequest.AnswerReceived += (s, e) =>
            {

            };
        }


        private void elementPublishSurveys_Click(object sender, EventArgs e)
        {
            var controls = MainContainer.Controls.Find("UControlCreateSurvey", true);

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

        private void elementQuestionAnswers_Click(object sender, EventArgs e)
        {
            var controls = MainContainer.Controls.Find("UControlCreateQandA", true);

            if (controls.Count() is 0)
            {
                MainContainer.Controls.Add(_uControlCreateQandA);
                _uControlCreateSurvey.Dock = DockStyle.Fill;
            }

            MainContainer.Controls.SetChildIndex(_uControlCreateQandA, 0);
        }
    }
}
