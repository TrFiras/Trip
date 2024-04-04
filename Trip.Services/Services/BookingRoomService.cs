using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Interfaces;
using Trip.Data.Models;
using Trip.Data.Repositories;
using Trip.Services.DTO;
using Trip.Services.Interfaces;

namespace Trip.Services.Services
{
    public class BookingRoomService : IBookingRoomService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IBookingRoomRepository _bookingRoomRepository;

        public BookingRoomService(IUnitOfWork unitOfWork, IMapper mapper,
            IBookingRoomRepository bookingRoomRepository)
        {
            _unitOfWork = unitOfWork;
            _bookingRoomRepository = bookingRoomRepository;
            _mapper = mapper;
        }

        public bool CreateBookingRoom(BookingRoomDTO bookingRoom, Guid dossierId, Guid roomId)
        {
                // Add booking room to database
                _unitOfWork.BookingRooms.Add(_mapper.Map<BookingRoom>(bookingRoom));
                 _unitOfWork.Save();

                // Update Dossier with BookingRoomId
                var dossier = _mapper.Map<DossierDTO>(_unitOfWork.Dossiers.GetById(dossierId));
                dossier.BookingRoomId = bookingRoom.Id;
                _unitOfWork.Dossiers.Update(_mapper.Map<Dossier>(dossier));

                // Update Room with BookingRoom
                var room = _mapper.Map<RoomDTO>(_unitOfWork.Rooms.GetById(roomId));
                room.BookingRooms.Add(bookingRoom);
                _unitOfWork.Rooms.Update(_mapper.Map<Room>(room));

                // Save changes to database
                 _unitOfWork.Save();

                return true;
        }
    }
}
