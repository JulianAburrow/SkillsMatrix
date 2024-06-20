using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserData
    {
        Task<UserModel> GetUser(int userId);

        Task<List<UserModel>> GetUsers();

        Task CreateUser(UserModel user);

        Task UpdateUser(UserModel user);

        Task DeleteUser(int userId);
    }
}
