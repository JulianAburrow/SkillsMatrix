using System.Collections.Generic;

namespace DataAccess.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StatusId { get; set; }

        public UserStatusModel UserStatus { get; set; }

        public List<UserSkillModel> UserSkill { get; set; }
    }
}
