using BusinessLogic.Services.PersonService;
using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollApp.Forms.Person_Answer.PollingPeople.IntroducingPeople
{
    public partial class FmIntroducingPeople : Form
    {
        
        public int _pollId;
        public int _personId;
        public string _personName;

        public FmIntroducingPeople()
        {
            InitializeComponent();
            _personId = 0;
            _personName = "";
        }

        #region Events

        private void FmIntroducingPeople_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            NextOperationAfterInsertPerson();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {
            TxtPersonName.Clear();
        }

        private void NextOperationAfterInsertPerson()
        {
            if(TxtPersonName.TextLength > 0)
            {
                _personName = TxtPersonName.Text;
                MessageBox.Show("Presiona 'enter' para continuar.", "Notificacion");
                ShowPollingPeopleForm();
            }
            else
            {
                MessageBox.Show("Llenar el campo.", "Advertencia");
            }

            Clear();
        }

        private void ShowPollingPeopleForm()
        {

            FmPollingPeople pollingPeople = new FmPollingPeople { _pollId = _pollId, _personId = _personId, _personName = _personName };
            this.Hide();
            pollingPeople.ShowDialog();

        }

        #endregion
    }
}
