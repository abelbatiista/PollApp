using BusinessLogic.Services.PollService;
using BusinessLogic.Services.QuestionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PollApp.Forms.Poll.InsertPoll;
using PollApp.Forms.Poll.UpdatePoll;
using PollApp.Forms.Poll.InsertPoll.InsertPollWindow;
using PollApp.Forms.Person_Answer.PolledPeople;
using PollApp.Forms.Person_Answer.PollingPeople.IntroducingPeople;
using BusinessLogic.Services.PersonService;
using BusinessLogic.Services.AnswerService;

namespace PollApp.Forms.Poll
{
    public partial class FmPoll : Form
    {
        private readonly CPollService _pollService;
        private readonly CQuestionService _questionService;
        private readonly CPersonService _personService;
        private readonly CAnswerService _answerService;

        public int _userId;
        public int _pollId;

        public FmPoll()
        {
            InitializeComponent();
            Clear();
            _pollService = new CPollService();
            _questionService = new CQuestionService();
            _personService = new CPersonService();
            _answerService = new CAnswerService();
            _pollId = 0;
        }

        #region Events

        private async void FmPoll_Load(object sender, EventArgs e)
        {
            Clear();
            await LoadPollsByUserId();
        }

        private void BtnInsertPoll_Click(object sender, EventArgs e)
        {
            ShowInsertPollForm();
        }

        private void BtnUpdatePoll_Click(object sender, EventArgs e)
        {
            ShowUpdateForm();
        }

        private async void BtnDeletePoll_Click(object sender, EventArgs e)
        {
            await DeletePoll();
        }

        private void BtnUnselectPoll_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnViewPoll_Click(object sender, EventArgs e)
        {
            ShowViewPoll();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            ShowApplyPoll();
        }

        private void DgvPoll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PollSelected(e);
        }

        #endregion

        #region "Private Methods"

        private async Task LoadPollsByUserId()
        {
            BindingSource source = new BindingSource { DataSource = await _pollService.GetAllPollsViewModelByUserId(_userId) };
            DgvPoll.DataSource = source;
            DgvPoll.ClearSelection();
        }

        private void Clear()
        {
            DgvPoll.ClearSelection();
            BtnApply.Enabled = false;
            BtnDeletePoll.Enabled = false;
            BtnUnselectPoll.Enabled = false;
            BtnViewPoll.Enabled = false;
            BtnUpdatePoll.Enabled = false;
        }

        private async void ShowInsertPollForm()
        {

            FmInsertPollWindow poll = new FmInsertPollWindow { _userId = _userId };
            this.Hide();
            poll.ShowDialog();
            this.Show();
            Clear();
            await LoadPollsByUserId();

        }

        private async void ShowUpdateForm()
        {

            FmUpdatePoll poll = new FmUpdatePoll { _pollId = _pollId };
            this.Hide();
            poll.ShowDialog();
            this.Show();
            Clear();
            await LoadPollsByUserId();

        }

        private async void ShowApplyPoll()
        {

            FmIntroducingPeople introducingPeople = new FmIntroducingPeople { _pollId = _pollId };
            this.Hide();
            introducingPeople.ShowDialog();
            this.Show();
            Clear();
            await LoadPollsByUserId();

        }

        private async void ShowViewPoll()
        {

            FmPolledPeople polledPeople = new FmPolledPeople { _pollId = _pollId };
            this.Hide();
            polledPeople.ShowDialog();
            this.Show();
            Clear();
            await LoadPollsByUserId();

        }

        private void PollSelected(DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                _pollId = Convert.ToInt32(DgvPoll.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnApply.Enabled = true;
                BtnDeletePoll.Enabled = true;
                BtnUnselectPoll.Enabled = true;
                BtnViewPoll.Enabled = true;
                BtnUpdatePoll.Enabled = true;
            }

        }

        private async Task DeletePoll()
        {

            if (_pollId == 0)
            {
                MessageBox.Show("Seleccione una encuesta.", "Notificación");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar esta encuesta?",
                    "Advertencia", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    bool request = await _answerService.DeleteAnswerByPollId(_pollId);

                    if (request)
                    {
                        bool request1 = await _questionService.DeleteQuestionsByPollId(_pollId);

                        if (request1)
                        {
                            bool request2 = await _personService.DeletePeopleByPollId(_pollId);

                            if (request2)
                            {
                                bool response = await _pollService.DeletePoll(_pollId);

                                if (response)
                                {
                                    MessageBox.Show("Eliminado con éxito.", "Notificación");
                                    await LoadPollsByUserId();
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error.", "Error");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error.", "Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error.", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error");
                    }
                }
                else { }

                Clear();
            }

        }

        //Para ver combobox, 59:00, encuentro de la semana.

        #endregion
    }
}
