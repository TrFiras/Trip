using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Services.DTO;
using Trip.Services.Interfaces;

namespace Trip.Services.Services
{

    public class AirportService : IAirportService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IAirportRepository _airportRepository;

        public AirportService(IUnitOfWork unitOfWork, IMapper mapper,
            IAirportRepository airportRepository)
        {
            _unitOfWork = unitOfWork;
            _airportRepository = airportRepository;
            _mapper = mapper;
        }

            public IEnumerable<AirportDTO> GetAllAirports()
        {
            var airportsList =  this._unitOfWork.Airports.GetAll();
            return  (_mapper.Map<IEnumerable<AirportDTO>>(airportsList));
        }
        
    }
}