using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IClientRepository : IGenericRepository<Client>
    {
         void CreateClientWithUser(Client client, User user);
    }
}