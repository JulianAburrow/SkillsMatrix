namespace DataAccess.Models
{
    public class UserSkillModel
    {
        public int UserSkillId { get; set; }

        public int UserId { get; set; }

        public int SkillId { get; set; }

        public int UserSkillScore { get; set; }

        public UserModel User { get; set; }

        public SkillModel Skill { get; set; }
    }
}
