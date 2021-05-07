
namespace StuNote.Student
{
    partial class FormQuestionAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.memoEditStuQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.lControlStuQuestion = new DevExpress.XtraEditors.LabelControl();
            this.labelControlStuSelectAnswer = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupStuAnswerSection = new DevExpress.XtraEditors.RadioGroup();
            this.simpBtnQuestAnsSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditStuQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStuAnswerSection.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEditStuQuestion
            // 
            this.memoEditStuQuestion.Enabled = false;
            this.memoEditStuQuestion.Location = new System.Drawing.Point(234, 37);
            this.memoEditStuQuestion.Name = "memoEditStuQuestion";
            this.memoEditStuQuestion.Size = new System.Drawing.Size(314, 75);
            this.memoEditStuQuestion.TabIndex = 0;
            // 
            // lControlStuQuestion
            // 
            this.lControlStuQuestion.Location = new System.Drawing.Point(77, 67);
            this.lControlStuQuestion.Name = "lControlStuQuestion";
            this.lControlStuQuestion.Size = new System.Drawing.Size(63, 19);
            this.lControlStuQuestion.TabIndex = 1;
            this.lControlStuQuestion.Text = "Question";
            // 
            // labelControlStuSelectAnswer
            // 
            this.labelControlStuSelectAnswer.Location = new System.Drawing.Point(77, 177);
            this.labelControlStuSelectAnswer.Name = "labelControlStuSelectAnswer";
            this.labelControlStuSelectAnswer.Size = new System.Drawing.Size(65, 19);
            this.labelControlStuSelectAnswer.TabIndex = 2;
            this.labelControlStuSelectAnswer.Text = "Answers ";
            // 
            // radioGroupStuAnswerSection
            // 
            this.radioGroupStuAnswerSection.Location = new System.Drawing.Point(234, 158);
            this.radioGroupStuAnswerSection.Name = "radioGroupStuAnswerSection";
            this.radioGroupStuAnswerSection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Answer1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Answer2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Answer3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Answer4")});
            this.radioGroupStuAnswerSection.Size = new System.Drawing.Size(344, 181);
            this.radioGroupStuAnswerSection.TabIndex = 3;
            // 
            // simpBtnQuestAnsSubmit
            // 
            this.simpBtnQuestAnsSubmit.Location = new System.Drawing.Point(234, 376);
            this.simpBtnQuestAnsSubmit.Name = "simpBtnQuestAnsSubmit";
            this.simpBtnQuestAnsSubmit.Size = new System.Drawing.Size(349, 56);
            this.simpBtnQuestAnsSubmit.TabIndex = 4;
            this.simpBtnQuestAnsSubmit.Text = "Submit";
            this.simpBtnQuestAnsSubmit.Click += new System.EventHandler(this.simpBtnQuestAnsSubmit_Click);
            // 
            // FormQuestionAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 438);
            this.Controls.Add(this.simpBtnQuestAnsSubmit);
            this.Controls.Add(this.radioGroupStuAnswerSection);
            this.Controls.Add(this.labelControlStuSelectAnswer);
            this.Controls.Add(this.lControlStuQuestion);
            this.Controls.Add(this.memoEditStuQuestion);
            this.Name = "FormQuestionAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StuNote 21 - QuestionAnswer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.memoEditStuQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStuAnswerSection.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditStuQuestion;
        private DevExpress.XtraEditors.LabelControl lControlStuQuestion;
        private DevExpress.XtraEditors.LabelControl labelControlStuSelectAnswer;
        private DevExpress.XtraEditors.RadioGroup radioGroupStuAnswerSection;
        private DevExpress.XtraEditors.SimpleButton simpBtnQuestAnsSubmit;
    }
}