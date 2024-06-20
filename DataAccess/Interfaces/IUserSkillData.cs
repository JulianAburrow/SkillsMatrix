using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface IUserSkillData
    {
        void AddUserSkills(List<UserSkillModel> userSkills);

        void DeleteUserSkills(int userId);
    }
}
