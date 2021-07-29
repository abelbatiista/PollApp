using BusinessLogic.Services.QuestionService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollApp.Forms.Question.InsertQuestion
{
    public partial class FmInsertQuestion : Form
    {
        private readonly CQuestionService _questionService;
        public int _pollId;

        public FmInsertQuestion()
        {
            InitializeComponent();
            _questionService = new CQuestionService();
        }

        #region Events

        private async void BtnInsertar_Click(object sender, EventArgs e)
        {
            await InsertQuestion();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmInsertQuestion_Load(object sender, EventArgs e)
        {
            TxtQuestionTitle.Clear();
        }

        #endregion

        #region "Private Methods"

        private async Task InsertQuestion()
        {

            if(TxtQuestionTitle.Text.Length > 0)
            {
                Database.Models.Question question = new Database.Models.Question { Title = TxtQuestionTitle.Text, PollId = _pollId };

                bool response = await _questionService.InsertQuestion(question);

                if (response)
                {
                    MessageBox.Show("Insertado con éxito.", "Notificación");
                }
                else
                {
                    MessageBox.Show("Error en la base de datos.", "Error");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Llenar el campo.", "Advertencia");
            }

        }

        #endregion
    }
}
