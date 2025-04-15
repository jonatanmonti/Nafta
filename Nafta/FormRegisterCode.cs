using BLL.Services;
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

namespace Nafta
{
    public partial class FormRegisterCode : Form
    {
        private readonly string _email;
        private readonly IAuthNavigator _navigator;

        public FormRegisterCode(string email, IAuthNavigator navigator)
        {
            InitializeComponent();
            _email = email;
            _navigator = navigator;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            var userService = new UserService();

            if (userService.VerifyEmailCode(_email, CodeRegisterText.Text.Trim(), out string msg))
            {
                MessageBox.Show(msg);
                _navigator.ShowLogin();
                this.Close();
            }
            else
            {
                MessageBox.Show(msg);
            }
        }
    }
}