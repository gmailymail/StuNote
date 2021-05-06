using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuNote.Student
{
    public partial class FormLoginStudent : DevExpress.XtraEditors.XtraForm
    {
        public FormLoginStudent()
        {
            InitializeComponent();
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string userName = textEditUName.Text.Trim();
            string password = textEditPassword.Text.Trim();

            if (!string.IsNullOrEmpty(userName))
            {
                Program.Username = userName;
            }
             
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            textEditUName.Text = "";
            textEditPassword.Text = "";
        }
    }
}