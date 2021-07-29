using BusinessLogic.Services.ViewModels;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.QuestionService
{
    interface IQuestionService
    {

        public Task<bool> DeleteQuestion(int id);
        public Task<bool> DeleteQuestionsByPollId(int id);
        public Task<Question> FindQuestion(int id);
        public Task<IEnumerable<Question>> GetAllQuestions();
        public Task<IEnumerable<CQuestionViewModel>> GetAllQuestionsViewModelByPollId(int pollId);
        public Task<IEnumerable<Question>> GetQuestionsByPollId(int pollId);
        public Task<bool> InsertQuestion(Question item);
        public Task<bool> UpdateQuestion(Question item);

    }
}
