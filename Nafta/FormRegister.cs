using Nafta.Navigation;
using Nafta.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CueBanner.Set(PasswordRegisterText, "Password:");
            CueBanner.Set(RepeatPassText, "Repeat Password:");
            CueBanner.Set(CellRegisterText, "Phone:");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            _navigator.ShowLogin();
            this.Close();
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
