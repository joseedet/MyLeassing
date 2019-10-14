using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLeassing.Common.Models;

namespace MyLeassing.Desk
{
    public partial class frmLogin : Form
    {
        private readonly EmailRequest _request;
        private frmLogin _frmLogin;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(EmailRequest emailRequest)
        {
            InitializeComponent();
            _request = emailRequest;
            _frmLogin = this;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToLower()==_request.Email.ToLower()
                && (txtPassword.Text.ToLower()
                ==_request.Email.ToLower()))
            {
                MessageBox.Show("Funciona", "MyLeassing");
            }
            MessageBox.Show("Error", "MyLeassing");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _frmLogin.Close();
        }
    }
}
