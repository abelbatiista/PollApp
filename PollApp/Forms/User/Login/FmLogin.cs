using BusinessLogic.Services.UserService;
using PollApp.Forms.Poll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollApp
{
    public partial class FmLogin : Form
    {
        public int _userId;

        private readonly CUserService _userService;

        public FmLogin()
        {
            InitializeComponent();
            _userService = new CUserService();
        }

        #region Events

        private void FmLogin_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            ShowSignUpForm();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            await LogIn();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {

            TxtUsername.Clear();
            TxtPassword.Clear();

        }

        private void ShowSignUpForm()
        {

            FmSignUp signUp = new FmSignUp();
            this.Hide();
            signUp.ShowDialog();
            this.Show();

        }

        private void ShowPollForm()
        {

            FmPoll poll = new FmPoll { _userId = _userId };
            this.Hide();
            poll.ShowDialog();
            this.Show();

        }

        private async Task LogIn()
        {

            _userId = await _userService.FindUserByUsernamePassword(TxtUsername.Text, TxtPassword.Text);

            if (_userId != 0)
            {
                MessageBox.Show("Datos correctos.", "Notificación");
                ShowPollForm();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta.", "Error");
            }

            Clear();

        }

        #endregion

    }
}
