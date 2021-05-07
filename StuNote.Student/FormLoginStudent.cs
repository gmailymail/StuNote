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
        private readonly FMain1 _fMain1;
        public FormLoginStudent(FMain1 fMain1)
        {
            InitializeComponent();
            _fMain1 = fMain1;
        }

        private void simpleButtonOK_Click(object sender, EventArgs e)
        {
            string userName = textEditUName.Text.Trim();
            string password = textEditPassword.Text.Trim();

            if (!string.IsNullOrEmpty(userName))
            {
                Program.Username = userName;
                Hide();
                if (_fMain1.Visible is false)
                    //this.Close();
                    _fMain1.ShowDialog(this);
            }
            else
            {
                XtraMessageBox.Show("User name or password cannot be empty.");
            }
             
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            textEditUName.Text = "";
            textEditPassword.Text = "";
        }
    }
}