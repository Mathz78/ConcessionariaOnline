using ConcessionariaOnline.Models.ConcessionariaOnlineContext;
using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using System.Linq;
using System.Collections.Generic;

namespace ConcessionariaOnline.Facades
{
    public class Client : IClient
    {
        private readonly ConcessionariaOnlineContext _context;

        public Client(ConcessionariaOnlineContext context)
        {
            _context = context;
        }

        public UserResponse CreateClient(Models.Client client)
        {
            var isUserCreated = _context.Clients.Any(c => c.CPF == client.CPF);

            if (!isUserCreated)
            {
                _context.Add(client);
                _context.SaveChanges();

                return new UserResponse
                {
                    Message = "Client created.",
                    Status = "Success."
                };
            }
            else
            {
                return new UserResponse
                {
                    Message = "The client already exists.",
                    Status = "Failure."
                };
            }
        }

        public IList<Models.Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }

        public UserResponse DeleteUser(int id)
        {
            var user = _context.Clients.FirstOrDefault(c => c.ClientId == id);

            if (user != null)
            {
                _context.Remove(user);
                _context.SaveChanges();
                
                return new UserResponse
                {
                    Message = "The client was deleted.",
                    Status = "Success."
                };
            }
            else 
            {
                return new UserResponse
                {
                    Message = "The client was not found.",
                    Status = "Failure."
                };
            }
        }
    }
}