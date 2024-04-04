using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.Interfaces
{
    public interface IClientService
    {
        Task FindByEmailAsync(string email);
        IEnumerable<ClientDTO> GetAllClients();
    }
}