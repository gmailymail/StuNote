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

        List<QuestionResponseBto> QuestionAnswerList = new List<QuestionResponseBto>();
        public UControlCreateQandA(IQuestionRequestService questionRequest)
        {
            InitializeComponent();
            _questionRequest = questionRequest;
            _questionRequest.AnswerReceived += _questionRequest_AnswerReceived;
        }

        private void _questionRequest_AnswerReceived(object sender, QuestionResponseBto e)
        {
            QuestionResponseBto questResponse = new QuestionResponseBto()
            {
                SelectedAnswer = e.SelectedAnswer,
                StudentId = e.StudentId
            };
            QuestionAnswerList.Add(questResponse);

            if (InvokeRequired)
                Invoke((Action)delegate ()
                {
                    updateQuestionAnswerDashBoard(QuestionAnswerList);
                });
            else
                updateQuestionAnswerDashBoard(QuestionAnswerList);

        }

        private async void simpleBtnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateControllers())
            {
                ClearAnswers();
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
            ClearAnswers();
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

        private void updateQuestionAnswerDashBoard(List<QuestionResponseBto> QuestionAnswerList)
        {
            try {
                if (QuestionAnswerList.Count > 0)
                { 
                    int Answer1Count = QuestionAnswerList.Count(x => x.SelectedAnswer == 0);
                    int Answer2Count = QuestionAnswerList.Count(x => x.SelectedAnswer == 1);
                    int Answer3Count = QuestionAnswerList.Count(x => x.SelectedAnswer == 2);
                    int Answer4Count = QuestionAnswerList.Count(x => x.SelectedAnswer == 3);

                    txtEditAnswer1Count.Text = Answer1Count.ToString();
                    txtEditAnswer2Count.Text = Answer2Count.ToString();
                    txtEditAnswer3Count.Text = Answer3Count.ToString();
                    txtEditAnswer4Count.Text = Answer4Count.ToString();

                    List<string> answerStringList = new List<string>();
                    foreach (QuestionResponseBto response in QuestionAnswerList)
                    {
                        string isCorrect = int.Parse(radioGroupCorrectAns.Properties.Items[radioGroupCorrectAns.SelectedIndex].Value.ToString()) == response.SelectedAnswer ? "Correct" : "Wrong"; 
                        string tempLine = "Student :" + response.StudentId + ", Answer :" + response.SelectedAnswer + ", " + isCorrect;
                        answerStringList.Add(tempLine);
                    }
                    lBoxConAnswer.DataSource = answerStringList;
                }
            }
            catch (Exception ex) { }
        }

        private void ClearAnswers()
        {
            txtEditAnswer1Count.Text = "";
            txtEditAnswer2Count.Text = "";
            txtEditAnswer3Count.Text = "";
            txtEditAnswer4Count.Text = "";
            lBoxConAnswer.Items.Clear();
            QuestionAnswerList.Clear();
        }
    }
}
