using BusinessLogic.Services.QuestionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;

namespace PollApp.Forms.Question.UpdateQuestion
{
    public partial class FmUpdateQuestion : Form
    {

        private readonly CQuestionService _questionService;
        private Database.Models.Question _updatingQuestion;

        public int _questionId;
        public int _pollId;

        public FmUpdateQuestion()
        {
            InitializeComponent();
            _questionService = new CQuestionService();
        }

        #region Events

        private async void FmUpdateQuestion_Load(object sender, EventArgs e)
        {
            await FindQuestion();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnUpdateQuestion_Click(object sender, EventArgs e)
        {
            await UpdateQuestion();
        }

        #endregion

        #region "Private Methods"

        private async Task FindQuestion()
        {
            _updatingQuestion = await _questionService.FindQuestion(_questionId);
            TxtQuestionTitle.Text = _updatingQuestion.Title;
        }

        private async Task UpdateQuestion()
        {
            if (TxtQuestionTitle.Text.Length > 0)
            {
                Database.Models.Question question = new Database.Models.Question
                {
                    Title = TxtQuestionTitle.Text,
                    QuestionId = _questionId,
                    PollId = _pollId
                };

                bool response = await _questionService.UpdateQuestion(question);

                if (response)
                {
                    MessageBox.Show("Actualizado con éxito.", "Notificación");
                }
                else
                {
                    MessageBox.Show("Error en la base de datos.", "Error");
                }

                this.Close();
                
            }
            else
            {
                MessageBox.Show("Llene el campo.", "Advertencia");
            }
        }

        #endregion
    }
}
