using BusinessLogic.Services.ViewModels;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.AnswerService
{
    public class CAnswerService : IAnswerService
    {

        private readonly C6_PP_T9Context _context;

        public CAnswerService()
        {
            _context = new C6_PP_T9Context();
        }

        public async Task<bool> DeleteAnswer(int id)
        {
            try
            {
                var entity = await _context.Answers.FirstOrDefaultAsync(x => x.AnswerId == id);

                if (entity == null)
                {
                    return false;
                }

                _context.Answers.Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Answer> FindAnswer(int id)
        {
            try
            {
                return await _context.Answers.FirstOrDefaultAsync(x => x.AnswerId == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Answer>> GetAllAnswers()
        {
            try
            {
                return await _context.Answers.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<CAnswerViewModel>> GetAllAnswersByPollAndPersonId(int pollId, int personId)
        {
            try
            {
                return await _context.Answers.Where(s => s.PollId == pollId && s.PersonId == personId).Select(s => new CAnswerViewModel
                {
                    CodigoEncuesta = s.PollId,
                    Persona = s.Person.Name,
                    Pregunta = s.Question.Title,
                    Respuesta = s.Title
                }).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertAnswer(Answer item)
        {
            try
            {
                _context.Answers.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAnswer(Answer item)
        {
            try
            {
                var entity = await _context.Answers.FirstOrDefaultAsync(x => x.AnswerId == item.AnswerId);

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
