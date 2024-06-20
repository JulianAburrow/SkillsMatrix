using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.DataAccess
{
    public class SkillData : ISkillData
    {
        private readonly STMGroupSkillsMatrixContext _context;

        public SkillData(STMGroupSkillsMatrixContext context)
            => _context = context;

        public async Task<SkillModel> GetSkill(int skillId)
        {
            return await _context.SkillModel
                .AsNoTracking()
                .SingleOrDefaultAsync(s => s.SkillId == skillId);
        }

        public async Task<List<SkillModel>> GetSkills()
        {
            return await _context.SkillModel
                .Include(s => s.UserSkill)
                    .ThenInclude(us => us.User)
                .OrderBy(s => s.SkillName)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task CreateSkill(SkillModel skill)
        {
            _context.Add(skill);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSkill(SkillModel skill)
        {
            var skillToUpdate = await _context.SkillModel
                .SingleOrDefaultAsync(s => s.SkillId == skill.SkillId);
            if (skillToUpdate == null) return;

            skillToUpdate.SkillName = skill.SkillName;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteSkill(int skillId)
        {
            var skillToDelete = _context.SkillModel
                .SingleOrDefaultAsync(s => s.SkillId == skillId);
            if (skillToDelete == null) return;

            _context.Remove(skillToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
