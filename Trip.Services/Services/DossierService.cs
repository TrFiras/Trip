using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Services.DTO;
using Trip.Services.Interfaces;

namespace Trip.Services.Services
{
    public class DossierService : IDossierService
    {
        private readonly IMapper _mapper;
        private readonly IDossierRepository _dossierRepository;
        private readonly IConfiguration _config;
         public IUnitOfWork _unitOfWork;

        public DossierService(IMapper mapper,
            IDossierRepository dossierRepository,
            IConfiguration config,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _dossierRepository = dossierRepository;
            _config = config;
            _unitOfWork = unitOfWork;
        }

        public  BookedRoomInfoDTO BookRoom(DateTime dateDebut, DateTime dateFin, Guid UserID, List<RoomDTO> myBookedRooms) {
var rooms = myBookedRooms.Select(roomDto => _mapper.Map<Trip.Data.Models.Room>(roomDto)).ToList();

            var BookedRoomInfo = _mapper.Map<BookedRoomInfoDTO>(_dossierRepository.CreateDossier( dateDebut,  dateFin, UserID, rooms));
            return BookedRoomInfo;

        }

        public DossierDTO AddDossier(DossierDTO tripDossier)
        {
            var dossier = new DossierDTO{
                Id = Guid.NewGuid(),
                DossierNumber = tripDossier.DossierNumber,
                BookingRoomId = tripDossier.BookingRoomId,
                ClientId = tripDossier.ClientId,
                FlightId = tripDossier.FlightId
            };
              _dossierRepository.CreateDossier(_mapper.Map<Dossier>(dossier));
              
            return dossier;
        }

        public IEnumerable<DossierDTO> GetAll()
        {
             var dossiersList =   _dossierRepository.GetAllReservations();
           return _mapper.Map<IEnumerable<DossierDTO>>(dossiersList);
        }
        public  IEnumerable<DossierDTO> GetDossiersByClientName(string firstName, string lastName)
        {
            var dossierList =  _dossierRepository.GetDossiersByClientName(firstName, lastName);
            return _mapper.Map<IEnumerable<DossierDTO>>(dossierList);
        }

    }
}