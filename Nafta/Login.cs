using Nafta.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nafta.Navigation;
using Nafta.Styles;

namespace Nafta
{
    public partial class Login : Form, IAuthNavigator
    {
        public Login()
        {
            InitializeComponent();
            CueBanner.Set(EmailLoginText, "Email");
            CueBanner.Set(PasswordLoginText, "Password");
        }

        public void ShowLogin() => this.Show();

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            var Register = new FormRegister(this)
            {
                Owner = this,
            };

            Register.Show();
            this.Hide();
        }

        private void labelForgot_Click(object sender, EventArgs e)
        {

            var forgot = new ForgotPasswordForm(this)
            {
                Owner = this,
            };

            forgot.Show();
            this.Hide();

        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
