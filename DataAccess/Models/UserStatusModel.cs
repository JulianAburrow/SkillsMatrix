using System.Collections.Generic;

namespace DataAccess.Models
{
    public class UserStatusModel
    {
        public int StatusId { get; set; }

        public string StatusName { get; set; }

        public IEnumerable<UserModel> User { get; set; }
    }
}
