
namespace StuNote.Teacher.UIControl
{
    partial class UControlCreateSurvey
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SimpleContextButton simpleContextButton1 = new DevExpress.Utils.SimpleContextButton();
            this.gBoxSurveyQuestion = new System.Windows.Forms.GroupBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.mEditYNQuestionText = new DevExpress.XtraEditors.MemoEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.lblConSelectQuestion = new DevExpress.XtraEditors.LabelControl();
            this.BtnSubmitQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroupYNQuestAnswer = new DevExpress.XtraEditors.RadioGroup();
            this.lblConSelectAnswer = new DevExpress.XtraEditors.LabelControl();
            this.gBoxSurveyQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEditYNQuestionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupYNQuestAnswer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxSurveyQuestion
            // 
            this.gBoxSurveyQuestion.Controls.Add(this.lblConSelectAnswer);
            this.gBoxSurveyQuestion.Controls.Add(this.radioGroupYNQuestAnswer);
            this.gBoxSurveyQuestion.Controls.Add(this.lblConSelectQuestion);
            this.gBoxSurveyQuestion.Controls.Add(this.dropDownButton1);
            this.gBoxSurveyQuestion.Controls.Add(this.comboBoxEdit1);
            this.gBoxSurveyQuestion.Controls.Add(this.mEditYNQuestionText);
            this.gBoxSurveyQuestion.Location = new System.Drawing.Point(4, 8);
            this.gBoxSurveyQuestion.Name = "gBoxSurveyQuestion";
            this.gBoxSurveyQuestion.Size = new System.Drawing.Size(582, 351);
            this.gBoxSurveyQuestion.TabIndex = 0;
            this.gBoxSurveyQuestion.TabStop = false;
            this.gBoxSurveyQuestion.Text = "Build Survey Question";
            // 
            // mEditYNQuestionText
            // 
            this.mEditYNQuestionText.Location = new System.Drawing.Point(22, 118);
            this.mEditYNQuestionText.Name = "mEditYNQuestionText";
            this.mEditYNQuestionText.Size = new System.Drawing.Size(541, 88);
            this.mEditYNQuestionText.TabIndex = 1;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "Yes/No Question";
            this.comboBoxEdit1.Enabled = false;
            this.comboBoxEdit1.Location = new System.Drawing.Point(178, 49);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            simpleContextButton1.AlignmentOptions.Panel = DevExpress.Utils.ContextItemPanel.Center;
            simpleContextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            simpleContextButton1.Caption = "Yes No";
            simpleContextButton1.Id = new System.Guid("2377ad4d-0131-4a02-bdd0-8ca792bf4feb");
            simpleContextButton1.ImageOptionsCollection.ItemNormal.UseDefaultImage = true;
            simpleContextButton1.Name = "simpleContxtBtnYesNo";
            this.comboBoxEdit1.Properties.ContextButtons.Add(simpleContextButton1);
            this.comboBoxEdit1.Size = new System.Drawing.Size(372, 50);
            this.comboBoxEdit1.TabIndex = 2;
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(395, 366);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(8, 8);
            this.dropDownButton1.TabIndex = 3;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // lblConSelectQuestion
            // 
            this.lblConSelectQuestion.Location = new System.Drawing.Point(22, 64);
            this.lblConSelectQuestion.Name = "lblConSelectQuestion";
            this.lblConSelectQuestion.Size = new System.Drawing.Size(109, 19);
            this.lblConSelectQuestion.TabIndex = 4;
            this.lblConSelectQuestion.Text = "Select Question";
            // 
            // BtnSubmitQuestion
            // 
            this.BtnSubmitQuestion.Location = new System.Drawing.Point(13, 390);
            this.BtnSubmitQuestion.Name = "BtnSubmitQuestion";
            this.BtnSubmitQuestion.Size = new System.Drawing.Size(172, 63);
            this.BtnSubmitQuestion.TabIndex = 1;
            this.BtnSubmitQuestion.Text = "Submit";
            this.BtnSubmitQuestion.Click += new System.EventHandler(this.BtnSubmitQuestion_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(353, 381);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(8, 8);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // radioGroupYNQuestAnswer
            // 
            this.radioGroupYNQuestAnswer.EditValue = ((byte)(1));
            this.radioGroupYNQuestAnswer.Location = new System.Drawing.Point(159, 219);
            this.radioGroupYNQuestAnswer.Name = "radioGroupYNQuestAnswer";
            this.radioGroupYNQuestAnswer.Properties.Columns = 1;
            this.radioGroupYNQuestAnswer.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroupYNQuestAnswer.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(0)), "No"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((byte)(1)), "Yes")});
            this.radioGroupYNQuestAnswer.Size = new System.Drawing.Size(210, 119);
            this.radioGroupYNQuestAnswer.TabIndex = 3;
            // 
            // lblConSelectAnswer
            // 
            this.lblConSelectAnswer.Location = new System.Drawing.Point(32, 270);
            this.lblConSelectAnswer.Name = "lblConSelectAnswer";
            this.lblConSelectAnswer.Size = new System.Drawing.Size(99, 19);
            this.lblConSelectAnswer.TabIndex = 5;
            this.lblConSelectAnswer.Text = "Select Answer";
            // 
            // UControlCreateSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnSubmitQuestion);
            this.Controls.Add(this.gBoxSurveyQuestion);
            this.Name = "UControlCreateSurvey";
            this.Size = new System.Drawing.Size(604, 467);
            this.Load += new System.EventHandler(this.UControlCreateSurvey_Load);
            this.gBoxSurveyQuestion.ResumeLayout(false);
            this.gBoxSurveyQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEditYNQuestionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupYNQuestAnswer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSurveyQuestion;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.MemoEdit mEditYNQuestionText;
        private DevExpress.XtraEditors.LabelControl lblConSelectQuestion;
        private DevExpress.XtraEditors.SimpleButton BtnSubmitQuestion;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.RadioGroup radioGroupYNQuestAnswer;
        private DevExpress.XtraEditors.LabelControl lblConSelectAnswer;
    }
}
