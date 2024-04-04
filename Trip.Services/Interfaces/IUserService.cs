using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAllUsers();
        UserDTO GetUserByEmail(string email);
        bool Register(UserDTO user);
        ClientDTO GetUserByEmailAndPassword(string email, string password);
    }
}