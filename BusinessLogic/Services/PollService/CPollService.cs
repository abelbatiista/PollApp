using BusinessLogic.Services.ViewModels;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.PollService
{
    public class CPollService : IPollService
    {
        private readonly C6_PP_T9Context _context;

        public CPollService()
        {
            _context = new C6_PP_T9Context();
        }

        public async Task<bool> DeletePoll(int id)
        {
            try
            {
                var entity = await _context.Polls.FirstOrDefaultAsync(x => x.PollId == id);

                if (entity == null)
                {
                    return false;
                }

                _context.Polls.Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Poll> FindPoll(int id)
        {
            try
            {
                return await _context.Polls.FirstOrDefaultAsync(x => x.PollId == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Poll>> GetAllPolls()
        {
            try
            {
                return await _context.Polls.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Poll>> GetAllPollsByUserId(int userId)
        {

            try
            {
                return await _context.Polls.Where(s => s.UserId == userId).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<IEnumerable<CPollViewModel>> GetAllPollsViewModel()
        {
            return await _context.Polls.Select(s => new CPollViewModel
            {
                Codigo = s.PollId,
                Titulo = s.Title
            }).ToListAsync();
        }

        public async Task<IEnumerable<CPollViewModel>> GetAllPollsViewModelByUserId(int userId)
        {
            try
            {
                return await _context.Polls.Where(s => s.UserId == userId).Select(s => new CPollViewModel
                {
                    Codigo = s.PollId,
                    Titulo = s.Title
                }).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Poll> GetLastPoll()
        {
            try
            {
                return await _context.Polls.OrderByDescending(x => x.PollId).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertPoll(Poll item)
        {
            try 
            {
                _context.Polls.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdatePoll(Poll item)
        {
            try
            {
                var entity = await _context.Polls.FirstOrDefaultAsync(x => x.PollId == item.PollId);

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
