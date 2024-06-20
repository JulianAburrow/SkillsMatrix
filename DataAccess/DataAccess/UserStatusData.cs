using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class UserStatusData : IUserStatusData
    {
        private readonly SkillsMatrixContext _context;

        public UserStatusData(SkillsMatrixContext context)
            => _context = context;

        public async Task<List<UserStatusModel>> GetUserStatuses()
        {
            return await _context.UserStatus
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
