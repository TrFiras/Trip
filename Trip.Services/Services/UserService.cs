using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Data.Repositories;
using Trip.Services.DTO;
using Trip.Services.Interfaces;
using static GraphQL.Instrumentation.Metrics;

namespace Trip.Services.Services
{
    public class UserService : IUserService

    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var usersList =  _unitOfWork.Users.GetAll();
            return (_mapper.Map<IEnumerable<UserDTO>>(usersList));
        }
         
        public UserDTO GetUserByEmail(string email)
        {

            var user =  _unitOfWork.Users.GetByEmail(email);
            if (user != null)
            {
                return (_mapper.Map<UserDTO>(user));
            }

            return null;
        }
        
        public bool Register(UserDTO user)
        {
            if (user != null)
            {
                AddressDTO adr = new AddressDTO();
                adr.PostalCode = user.Adresse.PostalCode;
                adr.Country = user.Adresse.Country;
                adr.City = user.Adresse.City;
                adr.Region = user.Adresse.Region;
                _unitOfWork.Adresses.CreateAdress(_mapper.Map<Address>(adr));
                var savedAdressId = _unitOfWork.SaveReturnGuid<Address>();

                UserDTO registredUser = new UserDTO();
                registredUser.Email = user.Email;
                registredUser.Password = user.Password;
                registredUser.FirstName = user.FirstName;
                registredUser.LastName = user.LastName;
                registredUser.PhoneNumber = user.PhoneNumber;
                _unitOfWork.Users.CreateUser(_mapper.Map<User>(registredUser));
                var savedUserId = _unitOfWork.SaveReturnGuid<User>();

                // Create and set properties of the Client entity
                ClientDTO client = new ClientDTO
                {
                    ClientId = Guid.NewGuid(),
                    PassportNumber = user.PassportNumber,
                    IsActive = true, 
                    AdresseId = savedAdressId,
                    UserId = savedUserId

                };
                    _unitOfWork.Clients.Add(_mapper.Map<Client>(client));
                    var result = _unitOfWork.Save();

                return result > 0;
            }
            return false;
        }
        public ClientDTO GetUserByEmailAndPassword(string email, string password)
        {
            // Retrieve the user by email
            var user =  _unitOfWork.Users.GetByEmailAndPassword(email, password);

            // If user exists and passwords match, return the user
            if (user != null )
            {
                return _mapper.Map<ClientDTO>(user);
            }

            return null; // Return null if user not found or passwords don't match
        }
        
    }
}