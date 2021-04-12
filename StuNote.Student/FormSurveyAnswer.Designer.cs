
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
            this.StuSurveyQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.radioGroupStudentAnswer = new DevExpress.XtraEditors.RadioGroup();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.radioGroupStudentAnsweritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StuSurveyQuestionitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonSubmititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormSurveyAnswerlayoutControl1ConvertedLayout)).BeginInit();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnsweritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestionitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubmititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 344);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(776, 47);
            this.buttonSubmit.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // StuSurveyQuestion
            // 
            this.StuSurveyQuestion.Enabled = false;
            this.StuSurveyQuestion.Location = new System.Drawing.Point(87, 12);
            this.StuSurveyQuestion.Name = "StuSurveyQuestion";
            this.StuSurveyQuestion.Size = new System.Drawing.Size(701, 196);
            this.StuSurveyQuestion.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.StuSurveyQuestion.TabIndex = 3;
            // 
            // radioGroupStudentAnswer
            // 
            this.radioGroupStudentAnswer.AutoSizeInLayoutControl = true;
            this.radioGroupStudentAnswer.Location = new System.Drawing.Point(87, 212);
            this.radioGroupStudentAnswer.Name = "radioGroupStudentAnswer";
            this.radioGroupStudentAnswer.Properties.Columns = 1;
            this.radioGroupStudentAnswer.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Answer1", true, null, "RadioBtnStudentAnswer1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Answer2", true, null, "RadioBtnStudentAnswer2")});
            this.radioGroupStudentAnswer.Size = new System.Drawing.Size(701, 128);
            this.radioGroupStudentAnswer.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.radioGroupStudentAnswer.TabIndex = 5;
            // 
            // FormSurveyAnswerlayoutControl1ConvertedLayout
            // 
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.dataLayoutControl1);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.radioGroupStudentAnswer);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.StuSurveyQuestion);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Controls.Add(this.buttonSubmit);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Name = "FormSurveyAnswerlayoutControl1ConvertedLayout";
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(800, 427);
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.radioGroupStudentAnsweritem,
            this.StuSurveyQuestionitem,
            this.buttonSubmititem,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 427);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // radioGroupStudentAnsweritem
            // 
            this.radioGroupStudentAnsweritem.Control = this.radioGroupStudentAnswer;
            this.radioGroupStudentAnsweritem.Location = new System.Drawing.Point(0, 200);
            this.radioGroupStudentAnsweritem.Name = "radioGroupStudentAnsweritem";
            this.radioGroupStudentAnsweritem.Size = new System.Drawing.Size(780, 132);
            this.radioGroupStudentAnsweritem.Text = "Answer";
            this.radioGroupStudentAnsweritem.TextLocation = DevExpress.Utils.Locations.Left;
            this.radioGroupStudentAnsweritem.TextSize = new System.Drawing.Size(63, 19);
            // 
            // StuSurveyQuestionitem
            // 
            this.StuSurveyQuestionitem.Control = this.StuSurveyQuestion;
            this.StuSurveyQuestionitem.Location = new System.Drawing.Point(0, 0);
            this.StuSurveyQuestionitem.Name = "StuSurveyQuestionitem";
            this.StuSurveyQuestionitem.Size = new System.Drawing.Size(780, 200);
            this.StuSurveyQuestionitem.Text = "Question";
            this.StuSurveyQuestionitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.StuSurveyQuestionitem.TextSize = new System.Drawing.Size(63, 19);
            // 
            // buttonSubmititem
            // 
            this.buttonSubmititem.Control = this.buttonSubmit;
            this.buttonSubmititem.Location = new System.Drawing.Point(0, 332);
            this.buttonSubmititem.Name = "buttonSubmititem";
            this.buttonSubmititem.Size = new System.Drawing.Size(780, 51);
            this.buttonSubmititem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonSubmititem.TextVisible = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 395);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(776, 20);
            this.dataLayoutControl1.TabIndex = 6;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 383);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(776, 20);
            this.Root.TextVisible = false;
            // 
            // FormSurveyAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.FormSurveyAnswerlayoutControl1ConvertedLayout);
            this.Name = "FormSurveyAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Answer Survey";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormSurveyAnswerlayoutControl1ConvertedLayout)).EndInit();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnsweritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestionitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubmititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem buttonSubmititem;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}