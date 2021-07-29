using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic.Services.AnswerService;
using BusinessLogic.Services.QuestionService;
using PollApp.Forms.Question.InsertQuestion;
using PollApp.Forms.Question.UpdateQuestion;

namespace PollApp.Forms.Poll.UpdatePoll
{
    public partial class FmUpdatePoll : Form
    {
        private readonly CQuestionService _questionService;
        private readonly CAnswerService _answerService;

        public int _pollId;
        public int _questionId;

        public FmUpdatePoll()
        {
            InitializeComponent();
            _questionService = new CQuestionService();
            _answerService = new CAnswerService();
            _questionId = 0;
            Clear();
        }

        #region Events

        private async void FmUpdatePoll_Load(object sender, EventArgs e)
        {
            await LoadQuestionsByPollId();
        }

        private void BtnInsertQuestion_Click(object sender, EventArgs e)
        {
            ShowInsertQuestionForm();
        }

        private void BtnUpdateQuestion_Click(object sender, EventArgs e)
        {
            ShowUpdateQuestinForm();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            await DeleteQuestion();
        }

        private void BtnUnselectQuestion_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QuestionSelected(e);
        }

        #endregion

        #region "Private Methods"

        private async Task LoadQuestionsByPollId()
        {
            BindingSource source = new BindingSource { DataSource = await _questionService.GetAllQuestionsViewModelByPollId(_pollId) };
            DgvQuestion.DataSource = source;
            DgvQuestion.ClearSelection();
        }

        private void Clear()
        {
            DgvQuestion.ClearSelection();
            BtnDelete.Enabled = false;
            BtnUpdateQuestion.Enabled = false;
            BtnUnselectQuestion.Enabled = false;;
        }

        private async void ShowInsertQuestionForm()
        {

            FmInsertQuestion question = new FmInsertQuestion { _pollId = _pollId};
            this.Hide();
            question.ShowDialog();
            this.Show();
            Clear();
            await LoadQuestionsByPollId();

        }

        private async void ShowUpdateQuestinForm()
        {

            FmUpdateQuestion question = new FmUpdateQuestion { _questionId = _questionId, _pollId = _pollId };
            this.Hide();
            question.ShowDialog();
            this.Show();
            Clear();
            await LoadQuestionsByPollId();

        }

        private void QuestionSelected(DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                _questionId = Convert.ToInt32(DgvQuestion.Rows[e.RowIndex].Cells[0].Value.ToString());
                BtnDelete.Enabled = true;
                BtnUpdateQuestion.Enabled = true;
                BtnUnselectQuestion.Enabled = true; ;
            }

        }

        private async Task DeleteQuestion()
        {

            if (_questionId == 0)
            {
                MessageBox.Show("Seleccione una pregunta.", "Notificación");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar esta pregunta?",
                    "Advertencia", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {
                    bool request = await _answerService.DeleteAnswerByQuestionId(_questionId);

                    if (request)
                    {
                        bool response = await _questionService.DeleteQuestion(_questionId);

                        if (response)
                        {
                            MessageBox.Show("Eliminado con éxito.", "Notificación");
                            await LoadQuestionsByPollId();
                            Clear();
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
            }

        }

        #endregion

    }
}
