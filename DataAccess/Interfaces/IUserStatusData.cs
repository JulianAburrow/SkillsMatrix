using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserStatusData
    {
        Task<List<UserStatusModel>> GetUserStatuses();
    }
}
