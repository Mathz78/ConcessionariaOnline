using ConcessionariaOnline.Models;

namespace ConcessionariaOnline.Interfaces
{
    public interface IUserFunctions
    {
        public UserResponse AddUserIntoDb(User user);

        public UserResponse RemoveUserFromDb(int id);

    }
}