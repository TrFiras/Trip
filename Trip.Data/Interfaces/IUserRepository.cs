using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByEmail(string email);
        public User CreateUser(User draftUser);
        Client GetByEmailAndPassword (string email, string password);
    }
}