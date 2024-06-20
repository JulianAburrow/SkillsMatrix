using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class UserStatusData : IUserStatusData
    {
        private readonly STMGroupSkillsMatrixContext _context;

        public UserStatusData(STMGroupSkillsMatrixContext context)
            => _context = context;

        public async Task<List<UserStatusModel>> GetUserStatuses()
        {
            return await _context.UserStatus
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
