namespace FrontEnd.DisplayModels
{
    public class UserSkillDisplayModel
    {
        public int UserSkillId { get; set; }

        public int UserId { get; set; }

        public int SkillId { get; set; }

        public int UserSkillScore { get; set; }

        public UserDisplayModel  User { get; set; }

        public SkillDisplayModel Skill { get; set; }
    }
}
