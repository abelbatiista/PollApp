using BusinessLogic.Services.ViewModels;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.AnswerService
{
    interface IAnswerService
    {

        public Task<bool> DeleteAnswer(int id);
        public Task<bool> DeleteAnswerByPollId(int id);
        public Task<bool> DeleteAnswerByQuestionId(int id);
        public Task<Answer> FindAnswer(int id);
        public Task<IEnumerable<Answer>> GetAllAnswers();
        public Task<IEnumerable<CAnswerViewModel>> GetAllAnswersByPollAndPersonId(int pollId, int personId);
        public Task<bool> InsertAnswer(Answer item);
        public Task<bool> UpdateAnswer(Answer item);

    }
}
