using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
namespace Trip.Data.Repositories
{

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
        public User GetByEmail(string email)
        {
            return  _dbContext.Set<User>().Single(u => u.Email == email);
        }
         public Client GetByEmailAndPassword(string email, string password)
        {

            return   _dbContext.Set<Client>().Include(w=>w.user)
            .FirstOrDefault(u => u.user.Email == email & u.user.Password == password);
        }

        public void AddRangeUser(User draftUser)
        {

            _dbContext.Set<User>().AddRange(draftUser);
        }
        public User CreateUser(User draftUser)
        {
            AddRangeUser(draftUser);
            _dbContext.SaveChanges();
            return draftUser;
        }

    }
}