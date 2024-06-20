using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ISkillData
    {
        Task<SkillModel> GetSkill(int skillId);

        Task<List<SkillModel>> GetSkills();

        Task CreateSkill(SkillModel skill);

        Task UpdateSkill(SkillModel skill);

        Task DeleteSkill(int skillId);
    }
}
