using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IAdressRepository : IGenericRepository<Address>
    {
         public Address CreateAdress(Address draftAdress);
    }
}