using StuNote.Domain;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;
using System.Windows.Forms;

namespace StuNote.Teacher
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyRequestService _surveyRequest;
        private readonly UControlCreateSurvey _uControlCreateSurvey;
        public SurveyRequestQuestionBto questionBto;

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
          
        }

        private void elementPublishSurveys_Click(object sender, EventArgs e)
        {           
            this.MainContainer.Controls.Add(_uControlCreateSurvey);
            _uControlCreateSurvey.Dock = DockStyle.Fill;
        }

        private void elementSignedStudents_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            //UControlCreateSurvey ucCreateSurv = new UControlCreateSurvey();
            //this.MainContainer.Controls.Add(ucCreateSurv);
        }
    }
}
