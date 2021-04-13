
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.radioGroupStudentAnswer = new DevExpress.XtraEditors.RadioGroup();
            this.StuSurveyQuestion = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.radioGroupStudentAnsweritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.StuSurveyQuestionitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.buttonSubmititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.FormSurveyAnswerlayoutControl1ConvertedLayout)).BeginInit();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnsweritem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestionitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSubmititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 334);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(776, 47);
            this.buttonSubmit.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 395);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(776, 20);
            this.dataLayoutControl1.TabIndex = 6;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(776, 20);
            this.Root.TextVisible = false;
            // 
            // radioGroupStudentAnswer
            // 
            this.radioGroupStudentAnswer.AutoSizeInLayoutControl = true;
            this.radioGroupStudentAnswer.EditValue = "<Null>";
            this.radioGroupStudentAnswer.Location = new System.Drawing.Point(87, 192);
            this.radioGroupStudentAnswer.Name = "radioGroupStudentAnswer";
            this.radioGroupStudentAnswer.Properties.Columns = 1;
            this.radioGroupStudentAnswer.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Answer1", true, null, "RadioBtnStudentAnswer1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Answer2", true, null, "RadioBtnStudentAnswer2")});
            this.radioGroupStudentAnswer.Size = new System.Drawing.Size(701, 128);
            this.radioGroupStudentAnswer.StyleController = this.FormSurveyAnswerlayoutControl1ConvertedLayout;
            this.radioGroupStudentAnswer.TabIndex = 5;
            // 
            // StuSurveyQuestion
            // 
            this.StuSurveyQuestion.Enabled = false;
            this.StuSurveyQuestion.Location = new System.Drawing.Point(87, 12);
            this.StuSurveyQuestion.Name = "StuSurveyQuestion";
            this.StuSurveyQuestion.Size = new System.Drawing.Size(701, 166);
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
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(800, 427);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // radioGroupStudentAnsweritem
            // 
            this.radioGroupStudentAnsweritem.Control = this.radioGroupStudentAnswer;
            this.radioGroupStudentAnsweritem.Location = new System.Drawing.Point(0, 180);
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
            this.StuSurveyQuestionitem.Size = new System.Drawing.Size(780, 170);
            this.StuSurveyQuestionitem.Text = "Question";
            this.StuSurveyQuestionitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.StuSurveyQuestionitem.TextSize = new System.Drawing.Size(63, 19);
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
            // buttonSubmititem
            // 
            this.buttonSubmititem.Control = this.buttonSubmit;
            this.buttonSubmititem.Location = new System.Drawing.Point(0, 322);
            this.buttonSubmititem.Name = "buttonSubmititem";
            this.buttonSubmititem.Size = new System.Drawing.Size(780, 51);
            this.buttonSubmititem.TextSize = new System.Drawing.Size(0, 0);
            this.buttonSubmititem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 170);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 312);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(780, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 373);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(780, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.FormSurveyAnswerlayoutControl1ConvertedLayout)).EndInit();
            this.FormSurveyAnswerlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStudentAnsweritem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StuSurveyQuestionitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem buttonSubmititem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}