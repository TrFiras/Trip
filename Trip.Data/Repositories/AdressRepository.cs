using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
namespace Trip.Data.Repositories
{
    public class AdressRepository: GenericRepository<Address>, IAdressRepository
    {
        public AdressRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
        public Address CreateAdress(Address draftAdress)
        {
            _dbContext.Addresses.Add(draftAdress);
            _dbContext.SaveChanges();
            return draftAdress;
        }
    }   
}