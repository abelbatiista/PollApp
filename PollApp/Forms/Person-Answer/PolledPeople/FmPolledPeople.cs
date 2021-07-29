using BusinessLogic.Services.PersonService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PollApp.Forms.Person_Answer.PolledPeople.ShowQuestionAnswer;

namespace PollApp.Forms.Person_Answer.PolledPeople
{
    public partial class FmPolledPeople : Form
    {
        private readonly CPersonService _personService;

        public int _pollId;
        public int _personId;

        public FmPolledPeople()
        {
            InitializeComponent();
            _personService = new CPersonService();
            _personId = 0;
        }

        #region Events

        private async void FmPolledPeople_Load(object sender, EventArgs e)
        {
            Clear();
            await LoadPolledPeopleByPollId();
        }

        private void DgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PollSelected(e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Private Methods"

        private async Task LoadPolledPeopleByPollId()
        {
            BindingSource source = new BindingSource { DataSource = await _personService.GetAllPeopleViewModelByPollId(_pollId) };
            DgvPeople.DataSource = source;
            Clear();
        }

        private void PollSelected(DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                _personId = Convert.ToInt32(DgvPeople.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            ShowQuestionAnswer();

        }

        private void ShowQuestionAnswer()
        {

            FmShowQuestionAnswer poll = new FmShowQuestionAnswer { _personId = _personId, _pullId = _pollId };
            this.Hide();
            poll.ShowDialog();
            this.Show();
            Clear();

        }

        private void Clear()
        {
            DgvPeople.ClearSelection();
        }

        #endregion
    }
}
