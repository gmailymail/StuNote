
namespace StuNote.Student.UIControl
{
    partial class UControlAnswerSurvey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmitAnswer = new DevExpress.XtraEditors.SimpleButton();
            this.gBoxSurveyQuestionAnswer = new System.Windows.Forms.GroupBox();
            this.lblConSelectAnswer = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupYNQuestAnswer = new DevExpress.XtraEditors.RadioGroup();
            this.lblQuestionType = new DevExpress.XtraEditors.LabelControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.mEditYNQuestionText = new DevExpress.XtraEditors.MemoEdit();
            this.lblQuestionTypeDetail = new DevExpress.XtraEditors.LabelControl();
            this.gBoxSurveyQuestionAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupYNQuestAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEditYNQuestionText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(352, 393);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(8, 8);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // BtnSubmitAnswer
            // 
            this.BtnSubmitAnswer.Location = new System.Drawing.Point(342, 229);
            this.BtnSubmitAnswer.Name = "BtnSubmitAnswer";
            this.BtnSubmitAnswer.Size = new System.Drawing.Size(172, 63);
            this.BtnSubmitAnswer.TabIndex = 4;
            this.BtnSubmitAnswer.Text = "Answer";
            // 
            // gBoxSurveyQuestionAnswer
            // 
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.lblQuestionTypeDetail);
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.lblConSelectAnswer);
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.BtnSubmitAnswer);
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.radioGroupYNQuestAnswer);
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.lblQuestionType);
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.dropDownButton1);
            this.gBoxSurveyQuestionAnswer.Controls.Add(this.mEditYNQuestionText);
            this.gBoxSurveyQuestionAnswer.Location = new System.Drawing.Point(10, 10);
            this.gBoxSurveyQuestionAnswer.Name = "gBoxSurveyQuestionAnswer";
            this.gBoxSurveyQuestionAnswer.Size = new System.Drawing.Size(582, 351);
            this.gBoxSurveyQuestionAnswer.TabIndex = 3;
            this.gBoxSurveyQuestionAnswer.TabStop = false;
            this.gBoxSurveyQuestionAnswer.Text = "Build Survey Question";
            // 
            // lblConSelectAnswer
            // 
            this.lblConSelectAnswer.Location = new System.Drawing.Point(31, 250);
            this.lblConSelectAnswer.Name = "lblConSelectAnswer";
            this.lblConSelectAnswer.Size = new System.Drawing.Size(99, 19);
            this.lblConSelectAnswer.TabIndex = 5;
            this.lblConSelectAnswer.Text = "Select Answer";
            // 
            // radioGroupYNQuestAnswer
            // 
            this.radioGroupYNQuestAnswer.Location = new System.Drawing.Point(179, 207);
            this.radioGroupYNQuestAnswer.Name = "radioGroupYNQuestAnswer";
            this.radioGroupYNQuestAnswer.Properties.Columns = 1;
            this.radioGroupYNQuestAnswer.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroupYNQuestAnswer.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), "No"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "Yes")});
            this.radioGroupYNQuestAnswer.Size = new System.Drawing.Size(141, 119);
            this.radioGroupYNQuestAnswer.TabIndex = 3;
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.Location = new System.Drawing.Point(74, 39);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(114, 19);
            this.lblQuestionType.TabIndex = 4;
            this.lblQuestionType.Text = "Question Type :";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(395, 366);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(8, 8);
            this.dropDownButton1.TabIndex = 3;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // mEditYNQuestionText
            // 
            this.mEditYNQuestionText.Enabled = false;
            this.mEditYNQuestionText.Location = new System.Drawing.Point(17, 78);
            this.mEditYNQuestionText.Name = "mEditYNQuestionText";
            this.mEditYNQuestionText.Size = new System.Drawing.Size(542, 109);
            this.mEditYNQuestionText.TabIndex = 1;
            // 
            // lblQuestionTypeDetail
            // 
            this.lblQuestionTypeDetail.Location = new System.Drawing.Point(215, 39);
            this.lblQuestionTypeDetail.Name = "lblQuestionTypeDetail";
            this.lblQuestionTypeDetail.Size = new System.Drawing.Size(138, 19);
            this.lblQuestionTypeDetail.TabIndex = 6;
            this.lblQuestionTypeDetail.Text = "QuestionTypeDetail";
            // 
            // UControlAnswerSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gBoxSurveyQuestionAnswer);
            this.Name = "UControlAnswerSurvey";
            this.Size = new System.Drawing.Size(601, 369);
            this.gBoxSurveyQuestionAnswer.ResumeLayout(false);
            this.gBoxSurveyQuestionAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupYNQuestAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEditYNQuestionText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnSubmitAnswer;
        private System.Windows.Forms.GroupBox gBoxSurveyQuestionAnswer;
        private DevExpress.XtraEditors.LabelControl lblConSelectAnswer;
        private DevExpress.XtraEditors.RadioGroup radioGroupYNQuestAnswer;
        private DevExpress.XtraEditors.LabelControl lblQuestionType;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.MemoEdit mEditYNQuestionText;
        private DevExpress.XtraEditors.LabelControl lblQuestionTypeDetail;
    }
}
