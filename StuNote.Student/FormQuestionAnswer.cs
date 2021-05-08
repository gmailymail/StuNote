using DevExpress.XtraEditors;
using StuNote.Domain.Btos.Question;
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
    public partial class FormQuestionAnswer : DevExpress.XtraEditors.XtraForm
    {
        private readonly IQuestionResponseService _question;
        public FormQuestionAnswer(IQuestionResponseService questionResponse)
        {
            InitializeComponent();
            _question = questionResponse;

            _question.QuestionReceived += async (s, e) =>
            {
                if (InvokeRequired)
                    Invoke((Action)delegate ()
                    {
                        HandleReceivedQuestion(e);
                    });
                else
                    HandleReceivedQuestion(e);
            };
        }

        private void HandleReceivedQuestion(QuestionRequestBto question)
        {
            memoEditStuQuestion.Text = question.Question;
            radioGroupStuAnswerSection.Properties.Items[0].Description = question.Answer1;
            radioGroupStuAnswerSection.Properties.Items[1].Description = question.Answer2;
            radioGroupStuAnswerSection.Properties.Items[2].Description = question.Answer3;
            radioGroupStuAnswerSection.Properties.Items[3].Description = question.Answer4;
        }

        private async void simpBtnQuestAnsSubmit_Click(object sender, EventArgs e)
        {
            if (radioGroupStuAnswerSection.SelectedIndex != -1)
            {
                var answer = int.Parse(radioGroupStuAnswerSection.Properties.Items[radioGroupStuAnswerSection.SelectedIndex].Value.ToString());
                Hide();
                await _question.SendAsync(new()
                {
                    SelectedAnswer = answer,
                    StudentId = Program.Username
                });
            }
            else {
                XtraMessageBox.Show("Please select answer before submit.");
            }
        }
    }
}