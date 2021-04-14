using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;

namespace StuNote.Student
{
    public partial class FormSurveyAnswer : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyResponseService _survey;

        /// <summary>
        /// SignalR receives its messages in a separate thread. Therefore,
        /// A delegate is necessary to update UI thread.
        /// </summary>
        /// <param name="survey"></param>
        private delegate void DelReceivedSurvey(SurveyRequestBto survey);
        /// <summary>
        /// To use delegate an instance must be created.
        /// </summary>
        DelReceivedSurvey _receivedSurvey;

        public FormSurveyAnswer(
            ISurveyResponseService survey)
        {
            InitializeComponent();
            _survey = survey;
            _receivedSurvey = HandleReceivedSurvey;
            _survey.SurveyReceived += survey_SurveyReceived;
        }

        private void survey_SurveyReceived(object sender, SurveyRequestBto e)
        {
            if (InvokeRequired)
                Invoke(_receivedSurvey, e);
            else
                HandleReceivedSurvey(e);
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            var answer = radioGroupStudentAnswer
                .Properties
                .Items[radioGroupStudentAnswer.SelectedIndex]
                .Description
                .Trim();

            Hide();

            await _survey.SendAsync(new()
            {
                Answer = answer
            });
        }

        #region Helper Methods

        /// <summary>
        /// This method is called to handle everytime a survey is received.
        /// Change this method to display a Form Control.
        /// </summary>
        /// <param name="survey"></param>
        private void HandleReceivedSurvey(SurveyRequestBto survey)
        {
            StuSurveyQuestion.Text = survey.Question;
            radioGroupStudentAnswer.Properties.Items[0].Description = survey.Answer1;
            radioGroupStudentAnswer.Properties.Items[1].Description = survey.Answer2;
        }
        #endregion Helper Methods
    }
}
