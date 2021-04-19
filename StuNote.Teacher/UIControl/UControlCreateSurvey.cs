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
        private List<SurveyStudentResponseBto> _studentResponses = new List<SurveyStudentResponseBto>();
        private delegate void DelUpdateUI(SurveyStudentResponseBto oneResponse);

        DelUpdateUI _delUpdateUI;

        public UControlCreateSurvey(ISurveyRequestService surveyRequestService)
        {
            InitializeComponent();
            _surveyRequest = surveyRequestService;
            _surveyRequest.ResponseReceived += SurveyRequest_ResponseReceived;
            _delUpdateUI = updateAnswerDashBoard;
        }

        /// <summary>
        /// Handle this event, everytime a student response to the survey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurveyRequest_ResponseReceived(object sender, SurveyResponseBto e)
        {
            SurveyStudentResponseBto oneResponse = new SurveyStudentResponseBto()
            {
                Answer = e.Answer.Trim()
            };
            if (InvokeRequired)
                Invoke(_delUpdateUI, oneResponse);
            else
                updateAnswerDashBoard(oneResponse);
        }

        private void UControlCreateSurvey_Load(object sender, EventArgs e)
        {
        }

        private async void BtnSubmitQuestion_Click(object sender, EventArgs e)
        {
            ResetControllers();
            if (!string.IsNullOrEmpty(mEditYNQuestionText.Text.Trim()) || string.IsNullOrEmpty(textEditAnswer1.Text.Trim()) || string.IsNullOrEmpty(textEditAnswer2.Text.Trim()))
            {
                SurveyRequestBto survey = new()
                {
                    Question = mEditYNQuestionText.Text.Trim(),
                    Answer1 = textEditAnswer1.Text.Trim(),
                    Answer2 = textEditAnswer2.Text.Trim()
                };
                responseControl1.Text = survey.Answer1;
                responseControl2.Text = survey.Answer2;
                await _surveyRequest.SendAsync(survey);
            }
            else
            {
                //TODO : Error Message for null values
                XtraMessageBox.Show("Enter question text and two answers.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            mEditYNQuestionText.Text = "";
            textEditAnswer1.Text = "";
            textEditAnswer2.Text = "";

            ResetControllers();
        }

        private void updateAnswerDashBoard(SurveyStudentResponseBto oneResponse)
        {
            _studentResponses.Add(oneResponse);
            int totalResponses = _studentResponses.Count;
            int answerOneCount = _studentResponses.Count(x => x.Answer == textEditAnswer1.Text.Trim());
            int answerTwoCount = _studentResponses.Count(x => x.Answer == textEditAnswer2.Text.Trim());
            double answerOnePercentage = (answerOneCount * 100f / totalResponses);
            double answerTwoPercentage = (answerTwoCount * 100f / totalResponses);
            responseText1.Text = "Response count : " + answerOneCount.ToString() + " out of " + totalResponses.ToString() + ". ( Percentage :" + Math.Round(answerOnePercentage, 2).ToString() + "% )";
            responseText2.Text = "Response count : " + answerTwoCount.ToString() + " out of " + totalResponses.ToString() + ". ( Percentage :" + Math.Round(answerTwoPercentage, 2).ToString() + "% )";
        }

        private void ResetControllers()
        {
            _studentResponses.Clear(); //Clear previous object list for new question distribution
            responseControl1.Text = "Answer1";
            responseControl2.Text = "Answer2";

            responseText1.Text = "Pending";
            responseText2.Text = "Pending";
        }


    }
}
