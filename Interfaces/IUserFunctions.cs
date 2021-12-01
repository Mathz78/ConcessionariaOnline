using System.Collections.Generic;
using ConcessionariaOnline.Models;

namespace ConcessionariaOnline.Interfaces
{
    public interface IUserFunctions
    {
        public UserResponse AddUserIntoDb(User user);

        public UserResponse RemoveUserFromDb(int id);

        public IList<User> GetAllUsers();

        public UserResponse UpdateUserName(int id, string updatedName);
    }
}