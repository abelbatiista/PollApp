using BusinessLogic.Services.AnswerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollApp.Forms.Person_Answer.PolledPeople.ShowQuestionAnswer
{
    public partial class FmShowQuestionAnswer : Form
    {
        private readonly CAnswerService _answerService;

        public int _personId;
        public int _pullId;

        public FmShowQuestionAnswer()
        {
            InitializeComponent();
            _answerService = new CAnswerService();
        }

        #region Events

        private async void FmShowQuestionAnswer_Load(object sender, EventArgs e)
        {
            Clear();
            await LoadAnswersByPollAndPersonId();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {
            DgvQuestionAnswer.ClearSelection();
        }

        private async Task LoadAnswersByPollAndPersonId()
        {
            BindingSource source = new BindingSource { DataSource = await _answerService.GetAllAnswersByPollAndPersonId(_pullId, _personId) };
            DgvQuestionAnswer.DataSource = source;
            DgvQuestionAnswer.ClearSelection();
        }

        #endregion
    }
}
