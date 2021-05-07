
namespace StuNote.Teacher
{
    partial class FMain2
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
            this.MainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementSignedStudents = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementPublishSurveys = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.elementQuestionAnswers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(390, 59);
            this.MainContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.Size = new System.Drawing.Size(646, 632);
            this.MainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 59);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(390, 632);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.elementSignedStudents,
            this.elementPublishSurveys,
            this.elementQuestionAnswers});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Menu";
            // 
            // elementSignedStudents
            // 
            this.elementSignedStudents.Name = "elementSignedStudents";
            this.elementSignedStudents.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementSignedStudents.Text = "Signed Students";
            this.elementSignedStudents.Visible = false;
            this.elementSignedStudents.Click += new System.EventHandler(this.elementSignedStudents_Click);
            // 
            // elementPublishSurveys
            // 
            this.elementPublishSurveys.Name = "elementPublishSurveys";
            this.elementPublishSurveys.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementPublishSurveys.Text = "Publish Surveys";
            this.elementPublishSurveys.Click += new System.EventHandler(this.elementPublishSurveys_Click);
            // 
            // elementQuestionAnswers
            // 
            this.elementQuestionAnswers.Name = "elementQuestionAnswers";
            this.elementQuestionAnswers.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.elementQuestionAnswers.Text = "Question and Answers";
            this.elementQuestionAnswers.Click += new System.EventHandler(this.elementQuestionAnswers_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1036, 59);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // FMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 691);
            this.ControlContainer = this.MainContainer;
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FMain2";
            this.NavigationControl = this.accordionControl1;
            this.Text = "FMain2";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementSignedStudents;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementPublishSurveys;
        private DevExpress.XtraBars.Navigation.AccordionControlElement elementQuestionAnswers;
    }
}