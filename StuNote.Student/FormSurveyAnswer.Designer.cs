
namespace StuNote.Student
{
    partial class FormSurveyAnswer
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
            this.components = new System.ComponentModel.Container();
            this.buttonSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupStudentAnswer = new DevExpress.XtraEditors.RadioGroup();
            this.StuSurveyQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.radioGroupStudentAnsweritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StuSurveyQuestionitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonSubmititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FormSurveyAnswerlayoutControl1ConvertedLayout)).BeginInit();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnsweritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestionitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubmititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.buttonSubmit.Appearance.Options.UseBackColor = true;
            this.buttonSubmit.Location = new System.Drawing.Point(12, 215);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(509, 32);
            this.buttonSubmit.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormSurveyAnswerlayoutControl1ConvertedLayout
            // 
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.radioGroupStudentAnswer);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.StuSurveyQuestion);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.buttonSubmit);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Margin = new System.Windows.Forms.Padding(2);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Name = "FormSurveyAnswerlayoutControl1ConvertedLayout";
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(533, 292);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // radioGroupStudentAnswer
            // 
            this.radioGroupStudentAnswer.AutoSizeInLayoutControl = true;
            this.radioGroupStudentAnswer.EditValue = "<Null>";
            this.radioGroupStudentAnswer.Location = new System.Drawing.Point(58, 115);
            this.radioGroupStudentAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.radioGroupStudentAnswer.Name = "radioGroupStudentAnswer";
            this.radioGroupStudentAnswer.Properties.Columns = 1;
            this.radioGroupStudentAnswer.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Answer1", "Answer1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Answer2", "Answer2")});
            this.radioGroupStudentAnswer.Size = new System.Drawing.Size(463, 86);
            this.radioGroupStudentAnswer.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.radioGroupStudentAnswer.TabIndex = 5;
            // 
            // StuSurveyQuestion
            // 
            this.StuSurveyQuestion.Enabled = false;
            this.StuSurveyQuestion.Location = new System.Drawing.Point(58, 12);
            this.StuSurveyQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.StuSurveyQuestion.Name = "StuSurveyQuestion";
            this.StuSurveyQuestion.Size = new System.Drawing.Size(463, 89);
            this.StuSurveyQuestion.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.StuSurveyQuestion.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.radioGroupStudentAnsweritem,
            this.StuSurveyQuestionitem,
            this.buttonSubmititem,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(533, 292);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // radioGroupStudentAnsweritem
            // 
            this.radioGroupStudentAnsweritem.Control = this.radioGroupStudentAnswer;
            this.radioGroupStudentAnsweritem.Location = new System.Drawing.Point(0, 103);
            this.radioGroupStudentAnsweritem.Name = "radioGroupStudentAnsweritem";
            this.radioGroupStudentAnsweritem.Size = new System.Drawing.Size(513, 90);
            this.radioGroupStudentAnsweritem.Text = "Answer";
            this.radioGroupStudentAnsweritem.TextLocation = DevExpress.Utils.Locations.Left;
            this.radioGroupStudentAnsweritem.TextSize = new System.Drawing.Size(43, 13);
            // 
            // StuSurveyQuestionitem
            // 
            this.StuSurveyQuestionitem.Control = this.StuSurveyQuestion;
            this.StuSurveyQuestionitem.Location = new System.Drawing.Point(0, 0);
            this.StuSurveyQuestionitem.Name = "StuSurveyQuestionitem";
            this.StuSurveyQuestionitem.Size = new System.Drawing.Size(513, 93);
            this.StuSurveyQuestionitem.Text = "Question";
            this.StuSurveyQuestionitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.StuSurveyQuestionitem.TextSize = new System.Drawing.Size(43, 13);
            // 
            // buttonSubmititem
            // 
            this.buttonSubmititem.Control = this.buttonSubmit;
            this.buttonSubmititem.Location = new System.Drawing.Point(0, 203);
            this.buttonSubmititem.Name = "buttonSubmititem";
            this.buttonSubmititem.Size = new System.Drawing.Size(513, 36);
            this.buttonSubmititem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonSubmititem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 93);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(513, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 193);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(513, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 239);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(513, 33);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormSurveyAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.FormSurveyAnswerlayoutControl1ConvertedLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSurveyAnswer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Answer Survey";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.FormSurveyAnswerlayoutControl1ConvertedLayout)).EndInit();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnsweritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestionitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubmititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton buttonSubmit;
        public DevExpress.XtraEditors.MemoEdit StuSurveyQuestion;
        public DevExpress.XtraEditors.RadioGroup radioGroupStudentAnswer;
        private DevExpress.XtraLayout.LayoutControl FormSurveyAnswerlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem radioGroupStudentAnsweritem;
        private DevExpress.XtraLayout.LayoutControlItem StuSurveyQuestionitem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControlItem buttonSubmititem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}