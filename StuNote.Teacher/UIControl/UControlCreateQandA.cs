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

namespace StuNote.Teacher.UIControl
{
    public partial class UControlCreateQandA : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IQuestionRequestService _questionRequest;
        public UControlCreateQandA(IQuestionRequestService questionRequest)
        {
            InitializeComponent();
            _questionRequest = questionRequest;
        }

        private async void simpleBtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateControllers())
            {
                QuestionRequestBto question = new QuestionRequestBto()
                {
                    Question = memoEditQuestion.Text.Trim(),
                    Answer1 = memoEditAnswer1.Text.Trim(),
                    Answer2 = memoEditAnswer2.Text.Trim(),
                    Answer3 = memoEditAnswer3.Text.Trim(),
                    Answer4 = memoEditAnswer4.Text.Trim(),
                    CorrectAnswer = int.Parse(radioGroupCorrectAns.Properties.Items[radioGroupCorrectAns.SelectedIndex].Value.ToString())
                };

                await _questionRequest.SendAsync(question);
            }
        }

        private void simpleBtnClear_Click(object sender, EventArgs e)
        {
            ClearControllers();
        }

        private void ClearControllers()
        {
            memoEditQuestion.Text = "";
            memoEditAnswer1.Text = "";
            memoEditAnswer2.Text = "";
            memoEditAnswer3.Text = "";
            memoEditAnswer4.Text = "";
        }

        private bool ValidateControllers()
        {
            if (string.IsNullOrEmpty(memoEditQuestion.Text))
            {
                XtraMessageBox.Show("Question text cannot be null or empty.");
                return false;
            }
            else if (string.IsNullOrEmpty(memoEditAnswer1.Text) || string.IsNullOrEmpty(memoEditAnswer2.Text) || string.IsNullOrEmpty(memoEditAnswer3.Text) || string.IsNullOrEmpty(memoEditAnswer4.Text))
            {
                XtraMessageBox.Show("Answer texts cannot be null or empty.");
                return false;
            }
            else if (radioGroupCorrectAns.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Select a correct answer.");
                return false;
            }
            return true;
        }
    }
}
