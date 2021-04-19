using StuNote.Domain;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Teacher.UIControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StuNote.Teacher
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {        
        private readonly UControlCreateSurvey _uControlCreateSurvey;

        public FMain(
            UControlCreateSurvey uControlCreateSurvey)
        {
            InitializeComponent();
            _uControlCreateSurvey = uControlCreateSurvey;
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

        


    }
}
