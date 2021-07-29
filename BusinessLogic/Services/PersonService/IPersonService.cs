using BusinessLogic.Services.ViewModels;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.PersonService
{
    interface IPersonService
    {

        public Task<bool> DeletePerson(int id);
        public Task<bool> DeletePeopleByPollId(int id);
        public Task<Person> FindPerson(int id);
        public Task<IEnumerable<Person>> GetAllPeople();
        public Task<IEnumerable<CPolledPeopleViewModel>> GetAllPeopleViewModelByPollId(int pollId);
        public Task<Person> GetLastPerson();
        public Task<bool> InsertPerson(Person item);
        public Task<bool> UpdatePerson(Person item);

    }
}
