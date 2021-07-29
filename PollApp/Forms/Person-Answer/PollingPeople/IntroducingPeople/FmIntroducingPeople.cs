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
        private readonly CPersonService _personService;

        public int _pollId;
        public int _personId;

        public FmIntroducingPeople()
        {
            InitializeComponent();
            _personService = new CPersonService();
            _personId = 0;
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

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            await NextOperationAfterInsertPerson();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {
            TxtPersonName.Clear();
        }

        private async Task NextOperationAfterInsertPerson()
        {
            if(TxtPersonName.TextLength > 0)
            {
                Person person = new Person
                {
                    Name = TxtPersonName.Text,
                    PollId = _pollId
                };

                var response = await _personService.InsertPerson(person);

                if (response)
                {
                    MessageBox.Show("Insertado con éxito.", "Notificación");

                    var request = await _personService.GetLastPerson();

                    if(request != null)
                    {
                        _personId = request.PersonId;

                        if(_personId != 0)
                        {
                            ShowPollingPeopleForm();
                        }
                        else
                        {
                            MessageBox.Show("Error en la base de datos.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error en la base de datos.", "Error");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error en la base de datos.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Llenar el campo.", "Advertencia");
            }

            Clear();
        }

        private void ShowPollingPeopleForm()
        {

            FmPollingPeople pollingPeople = new FmPollingPeople { _pollId = _pollId, _personId = _personId };
            this.Hide();
            pollingPeople.ShowDialog();

        }

        #endregion
    }
}
