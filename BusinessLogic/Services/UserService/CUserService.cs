using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.UserService
{
    public class CUserService : IUserService
    {

        private readonly C6_PP_T9Context _context;

        public CUserService()
        {
            _context = new C6_PP_T9Context();
        }

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                var entity = await _context.SysUsers.FirstOrDefaultAsync(x => x.UserId == id);

                if (entity == null)
                {
                    return false;
                }

                _context.SysUsers.Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<SysUser> FindUser(int id)
        {
            try
            {
                return await _context.SysUsers.FirstOrDefaultAsync(x => x.UserId == id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<int> FindUserByUsernamePassword(string username, string password)
        {
            try
            {

                var entity = await _context.SysUsers.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);

                if (entity == null)
                {
                    return 0;
                }
                else
                {
                    return entity.UserId;
                }

            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<IEnumerable<SysUser>> GetAllUsers()
        {
            try
            {
                return await _context.SysUsers.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> InsertUser(SysUser item)
        {
            try
            {
                _context.SysUsers.Add(item);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateUser(SysUser item)
        {
            try
            {
                var entity = await _context.SysUsers.FirstOrDefaultAsync(x => x.UserId == item.UserId);

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

        public async Task<bool> UserValidationByUsername(string username)
        {
            try
            {

                var entity = await _context.SysUsers.FirstOrDefaultAsync(x => x.Username == username);

                if (entity == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
