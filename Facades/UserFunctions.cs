using System.Linq;
using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using ConcessionariaOnline.Models.ConcessionariaOnlineContext;

namespace ConcessionariaOnline.Facades
{
    public class UserFunctions : IUserFunctions
    {
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
                    Message = "Este e-mail já está em uso.",
                    Status = "Falha."
                };
            }
            else 
            {
                _context.Add(user);
                _context.SaveChanges();

                return new UserResponse
                {
                    Message = "Usuário cadastrado com sucesso.",
                    Status = "Sucesso."
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