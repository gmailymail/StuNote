
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
            this.radioGroupStuAnswerSection = new DevExpress.XtraEditors.RadioGroup();
            this.simpBtnQuestAnsSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.FormQuestionAnswerlayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.radioGroupStuAnswerSectionitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.memoEditStuQuestionitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpBtnQuestAnsSubmititem = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditStuQuestion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStuAnswerSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormQuestionAnswerlayoutControl1ConvertedLayout)).BeginInit();
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStuAnswerSectionitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditStuQuestionitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpBtnQuestAnsSubmititem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // memoEditStuQuestion
            // 
            this.memoEditStuQuestion.Enabled = false;
            this.memoEditStuQuestion.Location = new System.Drawing.Point(89, 12);
            this.memoEditStuQuestion.Name = "memoEditStuQuestion";
            this.memoEditStuQuestion.Size = new System.Drawing.Size(822, 207);
            this.memoEditStuQuestion.StyleController = this.FormQuestionAnswerlayoutControl1ConvertedLayout;
            this.memoEditStuQuestion.TabIndex = 0;
            // 
            // radioGroupStuAnswerSection
            // 
            this.radioGroupStuAnswerSection.Location = new System.Drawing.Point(89, 223);
            this.radioGroupStuAnswerSection.Name = "radioGroupStuAnswerSection";
            this.radioGroupStuAnswerSection.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Answer1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Answer2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Answer3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Answer4")});
            this.radioGroupStuAnswerSection.Size = new System.Drawing.Size(822, 166);
            this.radioGroupStuAnswerSection.StyleController = this.FormQuestionAnswerlayoutControl1ConvertedLayout;
            this.radioGroupStuAnswerSection.TabIndex = 3;
            // 
            // simpBtnQuestAnsSubmit
            // 
            this.simpBtnQuestAnsSubmit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.simpBtnQuestAnsSubmit.Appearance.Options.UseBackColor = true;
            this.simpBtnQuestAnsSubmit.Location = new System.Drawing.Point(12, 403);
            this.simpBtnQuestAnsSubmit.Name = "simpBtnQuestAnsSubmit";
            this.simpBtnQuestAnsSubmit.Size = new System.Drawing.Size(899, 47);
            this.simpBtnQuestAnsSubmit.StyleController = this.FormQuestionAnswerlayoutControl1ConvertedLayout;
            this.simpBtnQuestAnsSubmit.TabIndex = 4;
            this.simpBtnQuestAnsSubmit.Text = "Submit";
            this.simpBtnQuestAnsSubmit.Click += new System.EventHandler(this.simpBtnQuestAnsSubmit_Click);
            // 
            // FormQuestionAnswerlayoutControl1ConvertedLayout
            // 
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Controls.Add(this.radioGroupStuAnswerSection);
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Controls.Add(this.memoEditStuQuestion);
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Controls.Add(this.simpBtnQuestAnsSubmit);
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Name = "FormQuestionAnswerlayoutControl1ConvertedLayout";
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.Size = new System.Drawing.Size(923, 472);
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.radioGroupStuAnswerSectionitem,
            this.memoEditStuQuestionitem,
            this.simpBtnQuestAnsSubmititem,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(923, 472);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // radioGroupStuAnswerSectionitem
            // 
            this.radioGroupStuAnswerSectionitem.Control = this.radioGroupStuAnswerSection;
            this.radioGroupStuAnswerSectionitem.Location = new System.Drawing.Point(0, 211);
            this.radioGroupStuAnswerSectionitem.Name = "radioGroupStuAnswerSectionitem";
            this.radioGroupStuAnswerSectionitem.Size = new System.Drawing.Size(903, 170);
            this.radioGroupStuAnswerSectionitem.Text = "Answers ";
            this.radioGroupStuAnswerSectionitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.radioGroupStuAnswerSectionitem.TextSize = new System.Drawing.Size(65, 19);
            // 
            // memoEditStuQuestionitem
            // 
            this.memoEditStuQuestionitem.Control = this.memoEditStuQuestion;
            this.memoEditStuQuestionitem.Location = new System.Drawing.Point(0, 0);
            this.memoEditStuQuestionitem.Name = "memoEditStuQuestionitem";
            this.memoEditStuQuestionitem.Size = new System.Drawing.Size(903, 211);
            this.memoEditStuQuestionitem.Text = "Question";
            this.memoEditStuQuestionitem.TextLocation = DevExpress.Utils.Locations.Left;
            this.memoEditStuQuestionitem.TextSize = new System.Drawing.Size(65, 19);
            // 
            // simpBtnQuestAnsSubmititem
            // 
            this.simpBtnQuestAnsSubmititem.Control = this.simpBtnQuestAnsSubmit;
            this.simpBtnQuestAnsSubmititem.Location = new System.Drawing.Point(0, 391);
            this.simpBtnQuestAnsSubmititem.Name = "simpBtnQuestAnsSubmititem";
            this.simpBtnQuestAnsSubmititem.Size = new System.Drawing.Size(903, 51);
            this.simpBtnQuestAnsSubmititem.TextSize = new System.Drawing.Size(0, 0);
            this.simpBtnQuestAnsSubmititem.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 381);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(903, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 442);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(903, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormQuestionAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 472);
            this.Controls.Add(this.FormQuestionAnswerlayoutControl1ConvertedLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuestionAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StuNote 21 - QuestionAnswer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.memoEditStuQuestion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStuAnswerSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormQuestionAnswerlayoutControl1ConvertedLayout)).EndInit();
            this.FormQuestionAnswerlayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupStuAnswerSectionitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditStuQuestionitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpBtnQuestAnsSubmititem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit memoEditStuQuestion;
        private DevExpress.XtraEditors.RadioGroup radioGroupStuAnswerSection;
        private DevExpress.XtraEditors.SimpleButton simpBtnQuestAnsSubmit;
        private DevExpress.XtraLayout.LayoutControl FormQuestionAnswerlayoutControl1ConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem radioGroupStuAnswerSectionitem;
        private DevExpress.XtraLayout.LayoutControlItem memoEditStuQuestionitem;
        private DevExpress.XtraLayout.LayoutControlItem simpBtnQuestAnsSubmititem;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}