
namespace StuNote.Student
{
    partial class FormLoginStudent
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
            this.lblControlUserName = new DevExpress.XtraEditors.LabelControl();
            this.textEditUName = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblControlPassword = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlUserName
            // 
            this.lblControlUserName.Location = new System.Drawing.Point(19, 28);
            this.lblControlUserName.Name = "lblControlUserName";
            this.lblControlUserName.Size = new System.Drawing.Size(78, 19);
            this.lblControlUserName.TabIndex = 0;
            this.lblControlUserName.Text = "User Name";
            // 
            // textEditUName
            // 
            this.textEditUName.Location = new System.Drawing.Point(116, 12);
            this.textEditUName.Name = "textEditUName";
            this.textEditUName.Size = new System.Drawing.Size(227, 52);
            this.textEditUName.TabIndex = 1;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(116, 76);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(232, 52);
            this.textEditPassword.TabIndex = 2;
            // 
            // lblControlPassword
            // 
            this.lblControlPassword.Location = new System.Drawing.Point(19, 92);
            this.lblControlPassword.Name = "lblControlPassword";
            this.lblControlPassword.Size = new System.Drawing.Size(67, 19);
            this.lblControlPassword.TabIndex = 3;
            this.lblControlPassword.Text = "Password";
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Location = new System.Drawing.Point(30, 147);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(145, 57);
            this.simpleButtonOK.TabIndex = 4;
            this.simpleButtonOK.Text = "OK";
            this.simpleButtonOK.Click += new System.EventHandler(this.simpleButtonOK_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Location = new System.Drawing.Point(198, 147);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(145, 57);
            this.simpleButtonCancel.TabIndex = 5;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // FormLoginStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 215);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonOK);
            this.Controls.Add(this.lblControlPassword);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditUName);
            this.Controls.Add(this.lblControlUserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginStudent";
            this.Text = "FormLoginStudent";
            ((System.ComponentModel.ISupportInitialize)(this.textEditUName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblControlUserName;
        private DevExpress.XtraEditors.TextEdit textEditUName;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl lblControlPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
    }
}