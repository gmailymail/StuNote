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

namespace StuNote.Student
{
    public partial class FormSurveyAnswer : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly ISurveyResponseService _survey;

        public FormSurveyAnswer(ISurveyResponseService survey)
        {
            InitializeComponent();
            _survey = survey;
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            await _survey.SendAsync(new()
            {
                Answer = radioGroupStudentAnswer.Properties.Items[radioGroupStudentAnswer.SelectedIndex].Description.Trim()
            }); ;
            this.Hide();
        }
    }
}
