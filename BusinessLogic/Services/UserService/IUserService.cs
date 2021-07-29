using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.UserService
{
    interface IUserService
    {

        public Task<bool> DeleteUser(int id);
        public Task<SysUser> FindUser(int id);
        public Task<int> FindUserByUsernamePassword(string username, string password);
        public Task<IEnumerable<SysUser>> GetAllUsers();
        public Task<bool> InsertUser(SysUser item);
        public Task<bool> UpdateUser(SysUser item);
        public Task<bool> UserValidationByUsername(string username);

    }
}
