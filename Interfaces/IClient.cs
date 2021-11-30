using System.Collections.Generic;
using ConcessionariaOnline.Models;

namespace ConcessionariaOnline.Interfaces
{
    public interface IClient
    {
        public UserResponse CreateClient(Client client);

        public IList<Models.Client> GetAllClients();
    }
}