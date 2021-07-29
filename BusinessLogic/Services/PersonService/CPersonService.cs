using BusinessLogic.Services.ViewModels;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.PersonService
{
    public class CPersonService : IPersonService
    {

        private readonly C6_PP_T9Context _context;

        public CPersonService()
        {
            _context = new C6_PP_T9Context();
        }

        public async Task<bool> DeletePerson(int id)
        {
            try
            {
                var entity = await _context.People.FirstOrDefaultAsync(x => x.PersonId == id);

                if (entity == null)
                {
                    return false;
                }

                _context.People.Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Person> FindPerson(int id)
        {
            try
            {
                return await _context.People.FirstOrDefaultAsync(x => x.PersonId == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Person>> GetAllPeople()
        {
            try
            {
                return await _context.People.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<IEnumerable<CPolledPeopleViewModel>> GetAllPeopleViewModelByPollId(int pollId)
        {

            try
            {
                return await _context.People.Where(s => s.PollId == pollId).Select(s => new CPolledPeopleViewModel
                {
                    Codigo = s.PersonId,
                    Nombre = s.Name
                }).ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<Person> GetLastPerson()
        {
            try
            {
                return await _context.People.OrderByDescending(x => x.PersonId).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertPerson(Person item)
        {
            try
            {
                _context.People.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdatePerson(Person item)
        {
            try
            {
                var entity = await _context.People.FirstOrDefaultAsync(x => x.PersonId == item.PersonId);

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
