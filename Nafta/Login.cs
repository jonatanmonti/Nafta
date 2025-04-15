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
using BLL.Services;


namespace Nafta
{
    public partial class Login : Form, IAuthNavigator
    {
        private Timer cleanupTimer;


        public Login()
        {
            InitializeComponent();
            StartCleanupTimer();
            CueBanner.Set(EmailLoginText, "Email");
            CueBanner.Set(PasswordLoginText, "Password");
        }

        private void StartCleanupTimer()
        {
            cleanupTimer = new Timer();
            cleanupTimer.Interval = 120000; // 10 minutos = 600,000 ms
            cleanupTimer.Tick += CleanupTimer_Tick;
            cleanupTimer.Start();
        }

        private void CleanupTimer_Tick(object sender, EventArgs e)
        {
            var cleanupService = new UserCleanupService();
            int removed = cleanupService.DeleteExpiredVerifications(TimeSpan.FromMinutes(2));

            if (removed > 0)
            {
                Console.WriteLine($"🧹 Se eliminaron {removed} usuarios no verificados.");
            }
        }


        public void ShowLogin() => this.Show();

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            var register = new FormRegister(this)
            {
                Owner = this
            };

            register.Show();
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
