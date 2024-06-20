using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace DataAccess.DataAccess
{
    public class UserData : IUserData
    {
        private readonly STMGroupSkillsMatrixContext _context;

        public UserData(STMGroupSkillsMatrixContext context)
            => _context = context;

        public async Task<UserModel> GetUser(int userId) =>
            await _context.User
                .Include(u => u.UserSkill)
                    .ThenInclude(us => us.Skill)
                .Include(u => u.UserStatus)
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.UserId == userId);                
        

        public async Task<List<UserModel>> GetUsers() =>
            await _context.User
                .Include(u => u.UserSkill)
                .Include(u => u.UserStatus)
                .AsNoTracking()
                .OrderBy(u => u.FirstName)
                .ToListAsync();

        public async Task CreateUser(UserModel user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(UserModel user)
        {
            var userToUpdate = await _context.User
                .SingleOrDefaultAsync(u => u.UserId == user.UserId);
            if (userToUpdate == null) return;

            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.StatusId = user.StatusId;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int userId)
        {
            var userToDelete = _context.User
                .Include(u => u.UserSkill)
                .SingleOrDefault(u => u.UserId == userId);
            if (userToDelete == null) return;

            foreach (var userSkill in userToDelete.UserSkill)
            {
                _context.Remove(userSkill);
            }

            _context.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
