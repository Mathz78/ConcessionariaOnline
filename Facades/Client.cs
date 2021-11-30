using ConcessionariaOnline.Models.ConcessionariaOnlineContext;
using ConcessionariaOnline.Interfaces;
using ConcessionariaOnline.Models;
using System.Linq;

namespace ConcessionariaOnline.Facades
{
    public class Client : IClient
    {
        private const int MINIMUM_PRICE = 0;

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
    }
}