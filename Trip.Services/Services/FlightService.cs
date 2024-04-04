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
    public class FlightService : IFlightService
    {
        public IUnitOfWork _unitOfWork;
        public IFlightRepository _flightRepository;
        public IMapper _mapper;

        public FlightService(IUnitOfWork unitOfWork, IMapper mapper,
            IFlightRepository flightRepository)
        {
            _unitOfWork = unitOfWork;
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public  IEnumerable<FlightDTO> GetAllFlights()
        {
            var FlightsList =  _unitOfWork.Flights.GetAllFlightsDetails()
;
            return (_mapper.Map<IEnumerable<FlightDTO>>(FlightsList));
        }




    }
}
