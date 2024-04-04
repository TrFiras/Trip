using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
namespace Trip.Data.Repositories
{
    public class ClientRepository: GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

        public void AddClientWithUser(Client client, User user)
        {

            _dbContext.Set<User>().AddRange(user);
            _dbContext.Set<Client>().AddRange(client);
        }

        public void CreateClientWithUser(Client client, User user)
        {
            AddClientWithUser(client, user);
             _dbContext.SaveChanges();
        }
    }
}