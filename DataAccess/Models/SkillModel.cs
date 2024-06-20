using System.Collections.Generic;

namespace DataAccess.Models
{
    public class SkillModel
    {
        public int SkillId { get; set; }

        public string SkillName { get; set; }

        public ICollection<UserSkillModel> UserSkill { get; set; }
    }
}
