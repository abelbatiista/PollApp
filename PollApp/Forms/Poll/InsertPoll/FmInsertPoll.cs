using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services.QuestionService;
using BusinessLogic.Services.PollService;
using BusinessLogic.Services.PollService.PollWindowDesign;
using System.Threading.Tasks;

namespace PollApp.Forms.Poll.InsertPoll
{
    public partial class FmInsertPoll : Form
    {

        public CPollWindowDesignService _pollWindow;
        private readonly CQuestionService _questionService;
        public int _pollId;

        public FmInsertPoll()
        {
            InitializeComponent();
            _questionService = new CQuestionService();
        }

        #region Events

        private void FmInsertPoll_Load(object sender, EventArgs e)
        {
            GenerateTextBoxing();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnInsert_Click(object sender, EventArgs e)
        {
            await InsertQuestions();
        }

        #endregion

        #region "Private Methods"

        private void GenerateTextBoxing()
        {
            if (_pollWindow.QuestionsQuantity >= 1) TxtQuestion1.Visible = true;
            if (_pollWindow.QuestionsQuantity >= 2) TxtQuestion2.Visible = true;
            if (_pollWindow.QuestionsQuantity >= 3) TxtQuestion3.Visible = true;
            if (_pollWindow.QuestionsQuantity >= 4) TxtQuestion4.Visible = true;
            if (_pollWindow.QuestionsQuantity >= 5) TxtQuestion5.Visible = true;
        }

        private async Task InsertQuestions()
        {
            var validating = ValidatingTextBoxing();

            if (validating)
            {
                if (_pollWindow.QuestionsQuantity >= 1)
                {
                    Database.Models.Question question1 = new Database.Models.Question
                    {
                        Title = TxtQuestion1.Text,
                        PollId = _pollId
                    };

                    var response1 = await _questionService.InsertQuestion(question1);

                    if (response1)
                    {
                        MessageBox.Show("Se ha insertado la pregunta 1.", "Notificación");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error con la pregunta 1.", "Error");
                    }

                }
                if (_pollWindow.QuestionsQuantity >= 2)
                {
                    Database.Models.Question question2 = new Database.Models.Question
                    {
                        Title = TxtQuestion2.Text,
                        PollId = _pollId
                    };

                    var response2 = await _questionService.InsertQuestion(question2);

                    if (response2)
                    {
                        MessageBox.Show("Se ha insertado la pregunta 2.", "Notificación");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error con la pregunta 2.", "Error");
                    }
                }
                if (_pollWindow.QuestionsQuantity >= 3)
                {
                    Database.Models.Question question3 = new Database.Models.Question
                    {
                        Title = TxtQuestion3.Text,
                        PollId = _pollId
                    };

                    var response3 = await _questionService.InsertQuestion(question3);

                    if (response3)
                    {
                        MessageBox.Show("Se ha insertado la pregunta 3.", "Notificación");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error con la pregunta 3.", "Error");
                    }
                }
                if (_pollWindow.QuestionsQuantity >= 4)
                {
                    Database.Models.Question question4 = new Database.Models.Question
                    {
                        Title = TxtQuestion4.Text,
                        PollId = _pollId
                    };

                    var response4 = await _questionService.InsertQuestion(question4);

                    if (response4)
                    {
                        MessageBox.Show("Se ha insertado la pregunta 4.", "Notificación");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error con la pregunta 4.", "Error");
                    }
                }
                if (_pollWindow.QuestionsQuantity >= 5)
                {
                    Database.Models.Question question5 = new Database.Models.Question
                    {
                        Title = TxtQuestion5.Text,
                        PollId = _pollId
                    };

                    var response5 = await _questionService.InsertQuestion(question5);

                    if (response5)
                    {
                        MessageBox.Show("Se ha insertado la pregunta 5.", "Notificación");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error con la pregunta 5.", "Error");
                    }

                }

                this.Close();

            }
            else
            {
                MessageBox.Show("Llenar todos los campos.", "Advertencia");
            }
        }

        private bool ValidatingTextBoxing()
        {
            switch (_pollWindow.QuestionsQuantity)
            {
                case 1:
                    if (TxtQuestion1.Text.Length > 0) return true;
                    else return false;
                case 2:
                    if (TxtQuestion1.Text.Length > 0 && TxtQuestion2.Text.Length > 0) return true;
                    else return false;
                case 3:
                    if (TxtQuestion1.Text.Length > 0 && TxtQuestion2.Text.Length > 0 
                        && TxtQuestion3.Text.Length > 0) return true;
                    else return false;
                case 4:
                    if (TxtQuestion1.Text.Length > 0 && TxtQuestion2.Text.Length > 0 
                        && TxtQuestion3.Text.Length > 0 && TxtQuestion4.Text.Length > 0) return true;
                    else return false;
                case 5:
                    if (TxtQuestion1.Text.Length > 0 && TxtQuestion2.Text.Length > 0 
                        && TxtQuestion3.Text.Length > 0 && TxtQuestion4.Text.Length > 0 
                        && TxtQuestion5.Text.Length > 0) return true;
                    else return false;
                default: return false;
            }
        }

        #endregion
    }
}
