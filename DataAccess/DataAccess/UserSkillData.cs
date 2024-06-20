using DataAccess.Interfaces;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.DataAccess
{
    public class UserSkillData : IUserSkillData
    {
        private readonly STMGroupSkillsMatrixContext _context;

        public UserSkillData(STMGroupSkillsMatrixContext context)
            => _context = context;

        public async void AddUserSkills(List<UserSkillModel> userSkills)
        {
            _context.AddRange(userSkills);
            await _context.SaveChangesAsync();
        }

        public async void DeleteUserSkills(int userId)
        {
            var userSkillsToRemove = _context.UserSkill
                .Where(u => u.UserId == userId)
                .ToList();
            if (userSkillsToRemove.Count == 0) return;

            _context.RemoveRange(userSkillsToRemove);
            await _context.SaveChangesAsync();
        }
    }
}
