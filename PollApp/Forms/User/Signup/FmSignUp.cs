using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services.UserService;
using Database.Models;

namespace PollApp
{
    public partial class FmSignUp : Form
    {
        private readonly CUserService _userService; 

        public FmSignUp()
        {
            InitializeComponent();
            _userService = new CUserService();
            BtnSignUp.Enabled = false;
        }

        #region Events

        private void FmSignUp_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private async void BtnSignUp_Click(object sender, EventArgs e)
        {
            await InsertUser();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextBoxing();
        }

        private void TxtLastname_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextBoxing();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextBoxing();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextBoxing();
        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            ValidatingTextBoxing();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {

            TxtName.Clear();
            TxtLastname.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtConfirmPassword.Clear();

        }

        private async Task InsertUser()
        {

            SysUser user = new SysUser 
            { 
                Name = TxtName.Text,
                Lastname = TxtLastname.Text,
                Username = TxtUsername.Text.ToLower(),
                Password = TxtPassword.Text
            };

            bool validateUsername = await ValidateUsername();

            if (validateUsername)
            {
                if (TxtPassword.Text == TxtConfirmPassword.Text)
                {
                    bool response = await _userService.InsertUser(user);

                    if (response)
                    {
                        MessageBox.Show("Se ha insertado con éxito.", "Notificación");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error en la base de datos.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario existente.", "Error");
            }

            Clear();

        }

        private void ValidatingTextBoxing()
        {
            if(TxtName.Text.Length != 0 && TxtLastname.Text.Length != 0
                && TxtUsername.Text.Length != 0 && TxtPassword.Text.Length != 0
                && TxtConfirmPassword.Text.Length != 0)
            {
                BtnSignUp.Enabled = true;
            }
        }

        private async Task<bool> ValidateUsername()
        {
            return await _userService.UserValidationByUsername(TxtUsername.Text);
        }

        #endregion

    }
}
