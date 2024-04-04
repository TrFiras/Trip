using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Data.Repositories;
using Trip.Services.DTO;
using Trip.Services.Interfaces;

namespace Trip.Services.Services
{
    public class ClientService : IClientService
    {
        public IUnitOfWork _unitOfWork;
        public IClientRepository _clientRepository;
        public IMapper _mapper;

        public ClientService(IUnitOfWork unitOfWork, IMapper mapper, IClientRepository clientRepository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _clientRepository = clientRepository;
        }

        public Task FindByEmailAsync(string email) => throw new NotImplementedException();

        public  IEnumerable<ClientDTO> GetAllClients()
        {
            var clientsList =  _unitOfWork.Clients.GetAll();
            return (_mapper.Map<IEnumerable<ClientDTO>>(clientsList));
        }
    }
}