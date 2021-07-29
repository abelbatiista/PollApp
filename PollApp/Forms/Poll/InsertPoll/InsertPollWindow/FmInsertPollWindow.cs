using BusinessLogic.Services.PollService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Services.PollService.PollWindowDesign;
using Database.Models;
using System.Threading.Tasks;

namespace PollApp.Forms.Poll.InsertPoll.InsertPollWindow
{
    public partial class FmInsertPollWindow : Form
    {
        private readonly CPollService _pollService;
        private CPollWindowDesignService _pollWindow;
        public int _userId;
        public int _pollId;
        private Database.Models.Poll _lastPoll;

        public FmInsertPollWindow()
        {
            InitializeComponent();
            _pollService = new CPollService();
            _pollId = 0;
        }

        #region Events

        private void FmInsertPollWindow_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            await InsertPollWindow();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtQuestionsQuantity_TextChanged(object sender, EventArgs e)
        {
            ValidatingQuestionsQuantity();
        }

        #endregion

        #region "Private Methods"

        private void Clear()
        {
            TxtPollTitle.Clear();
            TxtQuestionsQuantity.Clear();
        }

        private async Task InsertPollWindow()
        {
            if (TxtPollTitle.Text.Length > 0 && TxtQuestionsQuantity.Text.Length > 0)
            {
                if (int.Parse(TxtQuestionsQuantity.Text) > 5 || int.Parse(TxtQuestionsQuantity.Text) < 1)
                {
                    MessageBox.Show("El máximo de preguntas es cinco, el mínimo es 1.", "Advertencia");
                }
                else
                {
                    _pollWindow = new CPollWindowDesignService
                    {
                        UserId = _userId,
                        PollTitle = TxtPollTitle.Text,
                        QuestionsQuantity = int.Parse(TxtQuestionsQuantity.Text)
                    };

                    Database.Models.Poll poll = new Database.Models.Poll
                    {
                        Title = TxtPollTitle.Text,
                        UserId = _userId
                    };

                    var response = await _pollService.InsertPoll(poll);

                    if (response)
                    {
                        var request = await _pollService.GetLastPoll();

                        if (request != null)
                        {
                            _lastPoll = request;
                            ShowInsertPoll();
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

                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Llenar todos los campos.", "Advertencia");
            }
        }

        private void ValidatingQuestionsQuantity()
        {
            if (!Int32.TryParse(TxtQuestionsQuantity.Text, out _))
            {
                MessageBox.Show("Escriba un número.", "Advertencia");
                Clear();
            }
            else { }
        }

        private void ShowInsertPoll()
        {

            FmInsertPoll question = new FmInsertPoll { _pollWindow = _pollWindow, _pollId =_lastPoll.PollId };
            this.Hide();
            question.ShowDialog();

        }

        #endregion




    }
}
