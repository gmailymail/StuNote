using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using System;

namespace StuNote.Student
{
    public partial class FormSurveyAnswer : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyResponseService _survey;

        public FormSurveyAnswer(ISurveyResponseService survey)
        {
            InitializeComponent();

            _survey = survey;

            _survey.SurveyReceived += (o, e) =>
            {
                if (InvokeRequired)
                    Invoke((Action)delegate ()
                    {
                        HandleReceivedSurvey(e);
                    });
                else
                    HandleReceivedSurvey(e);
            };
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
