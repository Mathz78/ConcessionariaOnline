using System.Collections.Generic;
using System.Linq;
using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using ConcessionariaOnline.Models.ConcessionariaOnlineContext;

namespace ConcessionariaOnline.Facades
{
    public class UserFunctions : IUserFunctions
    {
        private const string SUCCESS_MESSAGE = "Success.";
        private const string FAILURE_MESSAGE = "Failure.";

        private readonly ConcessionariaOnlineContext _context;

        public UserFunctions(ConcessionariaOnlineContext context)
        {
            _context = context;
        }

        public UserResponse AddUserIntoDb(User user)
        {
            var isEmailCreated = VerifyExistingEmail(user.Email);

            if (isEmailCreated)
            {
                return new UserResponse
                {
                    Message = "This email is already in use.",
                    Status = FAILURE_MESSAGE
                };
            }
            else 
            {
                _context.Add(user);
                _context.SaveChanges();

                return new UserResponse
                {
                    Message = "User has been registered successfully.",
                    Status = SUCCESS_MESSAGE
                };
            }
        }

        public UserResponse RemoveUserFromDb(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if(user == null)
            {
                return new UserResponse
                {
                    Message = "The user informed does not exist.",
                    Status = FAILURE_MESSAGE
                };
            }
            else
            {
                _context.Remove(user);
                _context.SaveChanges();
                return new UserResponse
                {
                    Message = "User removed successfully.",
                    Status = SUCCESS_MESSAGE
                };
            }  
        }

        public IList<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public UserResponse UpdateUserName(int id, string updatedName)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                user.Name = updatedName;
                _context.SaveChanges();

                return new UserResponse
                {
                    Message = "The user was updated.",
                    Status = SUCCESS_MESSAGE
                };
            }
            else
            {
                return new UserResponse
                {
                    Message = "The user do not exist.",
                    Status = FAILURE_MESSAGE
                };
            }
        }

        private bool VerifyExistingEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email.Contains(email));

            if (user != null)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}