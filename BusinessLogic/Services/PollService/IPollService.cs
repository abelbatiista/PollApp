using BusinessLogic.Services.ViewModels;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.PollService
{
    interface IPollService
    {

        public Task<bool> DeletePoll(int id);
        public Task<Poll> FindPoll(int id);
        public Task<IEnumerable<Poll>> GetAllPolls();
        public Task<IEnumerable<Poll>> GetAllPollsByUserId(int userId);
        public Task<IEnumerable<CPollViewModel>> GetAllPollsViewModel();
        public Task<IEnumerable<CPollViewModel>> GetAllPollsViewModelByUserId(int userId);
        public Task<Poll> GetLastPoll();
        public Task<bool> InsertPoll(Poll item);
        public Task<bool> UpdatePoll(Poll item);

    }
}
