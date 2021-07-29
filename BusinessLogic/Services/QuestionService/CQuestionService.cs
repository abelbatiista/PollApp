using BusinessLogic.Services.ViewModels;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.QuestionService
{
    public class CQuestionService : IQuestionService
    {

        private readonly C6_PP_T9Context _context;

        public CQuestionService()
        {
            _context = new C6_PP_T9Context();
        }

        public async Task<bool> DeleteQuestion(int id)
        {
            try
            {
                var entity = await _context.Questions.FirstOrDefaultAsync(x => x.QuestionId == id);

                if (entity == null)
                {
                    return false;
                }

                _context.Questions.Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteQuestionsByPollId(int id)
        {
            try
            {
                var entities = await _context.Questions.Where(x => x.PollId == id).ToListAsync();

                if (entities == null)
                {
                    return false;
                }

                _context.Questions.RemoveRange(entities);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Question> FindQuestion(int id)
        {
            try
            {
                return await _context.Questions.FirstOrDefaultAsync(x => x.QuestionId == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Question>> GetAllQuestions()
        {
            try
            {
                return await _context.Questions.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<CQuestionViewModel>> GetAllQuestionsViewModelByPollId(int pollId)
        {

            try
            {
                return await _context.Questions.Where(s => s.PollId == pollId).Select(s => new CQuestionViewModel
                {
                    Codigo = s.QuestionId,
                    Titulo = s.Title
                }).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<IEnumerable<Question>> GetQuestionsByPollId(int pollId)
        {
            try
            {
                return await _context.Questions.Where(s => s.PollId == pollId).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertQuestion(Question item)
        {
            try
            {
                _context.Questions.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateQuestion(Question item)
        {
            try
            {
                var entity = await _context.Questions.FirstOrDefaultAsync(x => x.QuestionId == item.QuestionId);

                if (entity == null)
                {
                    return false;
                }

                _context.Entry(entity).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
