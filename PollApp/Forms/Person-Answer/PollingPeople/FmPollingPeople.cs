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

namespace PollApp.Forms.Person_Answer.PollingPeople
{
    public partial class FmPollingPeople : Form
    {

        private readonly CQuestionService _questionService;
        private readonly CAnswerService _answerService;

        public int _pollId;
        public int _personId;

        private readonly List<string> questions;

        public FmPollingPeople()
        {
            InitializeComponent();
            _questionService = new CQuestionService();
            _answerService = new CAnswerService();
            questions = new List<string>();
        }

        #region Events

        private async void FmPollingPeople_Load(object sender, EventArgs e)
        {
            await GetQuestionsByPollId();
            Clear();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

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
            }

            GenerateTextBoxesAndLabels();

        }

        private void GenerateTextBoxesAndLabels()
        {
            int counter = 0;

            foreach(var i in questions)
            {
                counter++;

                TextBox Txt = new TextBox();
            }
        }

        #endregion
    }
}
