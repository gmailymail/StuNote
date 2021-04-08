using DevExpress.XtraBars;
using Microsoft.AspNet.SignalR.Client;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuNote.Teacher
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyRequestService _surveyRequest;

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
            
            SurveyRequestBto survey = new()
            {
                Question = "Do you like MSc IT in ICBT?",
                Answer1 = "Yes",
                Answer2 = "No"
            };

            await _surveyRequest.SendAsync(survey);
        }

        private void elementSignedStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
