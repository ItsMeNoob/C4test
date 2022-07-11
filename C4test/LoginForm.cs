using C4test.Classes;
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

namespace C4test
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        Query L = new Query();
        MainView mainV = new MainView();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (L.LoginSuccessful(txtUsername.Text, txtPassword.Text))
            {
                mainV.Show();
                this.Hide();
               
            }
            else
            {
                WrongUserPassContainer.ContentVisible = true;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void OkBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                OkBtn.PerformClick();
            }
        }
    }
}