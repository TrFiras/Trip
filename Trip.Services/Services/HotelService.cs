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
    public class HotelService : IHotelService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IUnitOfWork unitOfWork, IMapper mapper,
            IHotelRepository hotelRepository)
        {
            _unitOfWork = unitOfWork;
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

 


        public  IEnumerable<HotelDTO> GetAllHotels()
        {
            var hotelsList =  _unitOfWork.Hotels.GetAllHotelsDetails();
            return (_mapper.Map<IEnumerable<HotelDTO>>(hotelsList));
        }

    
}}
