using BusinessLogic.Services.QuestionService;
using BusinessLogic.Services.AnswerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using Database.Models;
using BusinessLogic.Services.PersonService;

namespace PollApp.Forms.Person_Answer.PollingPeople
{
    public partial class FmPollingPeople : Form
    {
        private readonly CPersonService _personService;
        private readonly CQuestionService _questionService;
        private readonly CAnswerService _answerService;

        public int _pollId;
        public int _personId;
        public string _personName;

        private readonly Dictionary<string, TextBox> dictionary;

        private readonly List<string> questions;
        private readonly List<int> _questionsId;

        public FmPollingPeople()
        {
            InitializeComponent();
            _questionService = new CQuestionService();
            _answerService = new CAnswerService();
            _personService = new CPersonService();
            questions = new List<string>();
            _questionsId = new List<int>();
            dictionary = new Dictionary<string, TextBox>();
        }

        #region Events

        private async void FmPollingPeople_Load(object sender, EventArgs e)
        {
            Clear();
            await GetQuestionsByPollId();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnInsert_Click(object sender, EventArgs e)
        {
            await InsertUser();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {

        }

        private async Task GetQuestionsByPollId()
        {

            var response = await _questionService.GetQuestionsByPollId(_pollId);

            foreach(var i in response)
            {
                questions.Add(i.Title);
                _questionsId.Add(i.QuestionId);
            }

            GenerateTextBoxesAndLabelsAndTableLayout();

        }

        private void GenerateTextBoxesAndLabelsAndTableLayout()
        {

            TableLayoutPanel tableLayoutPanel5 = new TableLayoutPanel
            {
                ColumnCount = 1,
                //ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)),
                Dock = System.Windows.Forms.DockStyle.Fill,
                //Location = new Point(3, 3),
                Name = "tableLayoutPanel4",
                RowCount = questions.Count(),
                //Size = new System.Drawing.Size(484, 241),
                TabIndex = 1
            };

            float percentRows = 100 / questions.Count();

            for (int i = 1; i <= questions.Count(); i++)
            {
                tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, percentRows));
            }

            tableLayoutPanel4.Controls.Add(tableLayoutPanel5);

            int counter = 0;

            foreach (var i in questions)
            {
                counter++;

                dictionary[$"Question{counter}"] = new TextBox
                {
                    Name = $"Question{counter}",
                    TextAlign = HorizontalAlignment.Center,
                    PlaceholderText = i,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    Location = new Point(34, 57),
                    Size = new Size(250, 30),
                    TabIndex = counter
                };

                var _dictionaryValue = dictionary[$"Question{counter}"];

                tableLayoutPanel5.Controls.Add(_dictionaryValue);

            }
        }

        private async Task InsertAnswer()
        {

            for (int i = 0; i < questions.Count(); i++)
            {
                Answer answer = new Answer
                {
                    PollId = _pollId,
                    PersonId = _personId,

                };

                answer.QuestionId = _questionsId[i];
                answer.Title = dictionary[$"Question{i + 1}"].Text;

                var response = await _answerService.InsertAnswer(answer);

                if (response)
                {
                    MessageBox.Show($"Se han insertado correctamente la pregunta {i+1}.", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Error en la base de datos.", "Error");
                }
            }

            this.Close();
        }

        private async Task InsertUser()
        {
            var validating = ValidatingTextBoxes();

            if (validating)
            {
                Person person = new Person
                {
                    Name = _personName,
                    PollId = _pollId
                };

                var response = await _personService.InsertPerson(person);

                if (response)
                {
                    MessageBox.Show("Persona insertada con éxito.", "Notificación");

                    var request = await _personService.GetLastPerson();

                    if (request != null)
                    {
                        _personId = request.PersonId;

                        if (_personId != 0)
                        {
                            await InsertAnswer();
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
                MessageBox.Show("Llenar todos los campos.", "Advertencia");
            }

        }

        private bool ValidatingTextBoxes()
        {

            foreach (var _dictionary in dictionary)
            {
                if (string.IsNullOrEmpty(_dictionary.Value.Text))
                {
                    return false;
                }
            }

            return true;

        }

        #endregion
    }
}
