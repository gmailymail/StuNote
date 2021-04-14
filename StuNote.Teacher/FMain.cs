using StuNote.Domain;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StuNote.Teacher
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyRequestService _surveyRequest;
        private readonly UControlCreateSurvey _uControlCreateSurvey;
        private List<SurveyStudentResponseBto> _studentResponses = new List<SurveyStudentResponseBto>();

        public FMain(
            ISurveyRequestService surveyRequest,
            UControlCreateSurvey uControlCreateSurvey)
        {
            InitializeComponent();
            _surveyRequest = surveyRequest;
            _uControlCreateSurvey = uControlCreateSurvey;
            _surveyRequest.ResponseReceived += _surveyRequest_ResponseReceived;
        }

        /// <summary>
        /// Handle this event, everytime a student response to the survey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _surveyRequest_ResponseReceived(object sender, SurveyResponseBto e)
        {
            SurveyStudentResponseBto oneResponse = new SurveyStudentResponseBto() {
                Answer = e.Answer.Trim()
            };
            _studentResponses.Add(oneResponse);
        }

        private void elementPublishSurveys_Click(object sender, EventArgs e)
        {           
            this.MainContainer.Controls.Add(_uControlCreateSurvey);
            _uControlCreateSurvey.Dock = DockStyle.Fill;
        }

        private void elementSignedStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
