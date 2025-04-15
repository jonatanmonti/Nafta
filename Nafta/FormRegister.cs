using Nafta.Navigation;
using Nafta.Styles;
using System;
using System.Windows.Forms;
using BLL.Services;

namespace Nafta
{
    public partial class FormRegister : Form
    {
        private readonly IAuthNavigator _navigator;

        public FormRegister(IAuthNavigator navigator)
        {
            InitializeComponent();
            _navigator = navigator;

            CueBanner.Set(EmailRegisterText, "Email:");
            CueBanner.Set(FirstNameRegister, "First Name:");
            CueBanner.Set(LastNameRegister, "Last Name:");
            CueBanner.Set(PasswordRegisterText, "Password:");
            CueBanner.Set(RepeatPassText, "Repeat Password:");
            CueBanner.Set(CellRegisterText, "Phone:");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _navigator.ShowLogin();
            this.Close();
        }

        private void CloseApp_Click(object sender, EventArgs e) => Application.Exit();

        private void MiniApp_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (PasswordRegisterText.Text != RepeatPassText.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (PasswordRegisterText.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            var userService = new UserService();

            bool success = userService.RegisterUser(
                FirstNameRegister.Text.Trim(),
                LastNameRegister.Text.Trim(),
                EmailRegisterText.Text.Trim(),
                PasswordRegisterText.Text,
                CellRegisterText.Text.Trim(),
                out string resultMessage
            );

            MessageBox.Show(resultMessage);

            if (success)
            {
                var codeForm = new FormRegisterCode(EmailRegisterText.Text.Trim(), _navigator);
                codeForm.Show();
                this.Close();
            }
        }
    }
}
