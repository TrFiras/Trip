using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trip.Data.Entities;
using Trip.Data.Interfaces;
using Trip.Data.Models;

namespace Trip.Data.Repositories
{
    public class DossierRepository : GenericRepository<Dossier>, IDossierRepository
    {
        public DossierRepository(DbContextClass dbContext) : base(dbContext)
        {
        }

        public  BookedRoomInfoEntity CreateDossier(DateTime dateDebut, DateTime dateFin, Guid UserID, List<Room> myBookedRooms) {
            
            double totalAmount = 0;
            foreach (var roomItem in myBookedRooms) {
                totalAmount += roomItem.Price - (roomItem.Price * (double)roomItem.Discount/100);
                foreach(var extraItem in roomItem.Extra) {
                  if (extraItem.IsFree == false)
                    {
                        totalAmount += (double)extraItem.OptionPrice;
                    }
                }
            }
            BookingRoom draftBookingRoom = new BookingRoom();
            draftBookingRoom.Type="N/A";
            draftBookingRoom.StartDate = dateDebut;
            draftBookingRoom.EndDate = dateFin;
            draftBookingRoom.TotalAmount = (decimal)totalAmount;
            _dbContext.BookingRooms.Add(draftBookingRoom);

            Dossier draftDossier = new Dossier();
            draftDossier.DossierNumber= "";
            draftDossier.ClientId = UserID;
            draftDossier.FlightId=null;
            draftDossier.BookingRoomId=draftBookingRoom.Id;

            foreach (var roomItem in myBookedRooms) {
                RoomBookingRoom draftRoomBookingRoom = new RoomBookingRoom();
                draftRoomBookingRoom.RoomId = roomItem.Id;
                draftRoomBookingRoom.BookingRoomId = draftBookingRoom.Id;
                _dbContext.RoomBookingRooms.Add(draftRoomBookingRoom);
            }

            _dbContext.SaveChanges();

            BookedRoomInfoEntity myBookedEntity = new BookedRoomInfoEntity();
            myBookedEntity.TotalAmount = (decimal)totalAmount;
            myBookedEntity.CountRooms = myBookedRooms.Count;

            return  myBookedEntity;
        }

       
 public List<Dossier> GetAllReservations()
        {
            var dossierList =  _dbContext.Set<Dossier>()
            .Include(d => d.Client)
            .ThenInclude(d=>d.address)
            .Include(x=>x.BookingRoom)
            .ThenInclude(x=>x.Rooms)
            .ThenInclude(x=>x.Hotel)
            .Include(y => y.dossierFlights)
            .ThenInclude(y => y.flight)
            .ThenInclude(y => y.flightAirports)
            .ThenInclude(y => y.airport)
            .Include(y=>y.dossierFlights)
            .ThenInclude(y => y.flight)
            .ThenInclude(y=>y.flightAirplanes )
            .ThenInclude(y=> y.airplane)
            .ToList();

            return dossierList;
        }
        public List<Dossier> GetDossiersByClientName(string firstName, string lastName)
        {
            return  _dbContext.Dossiers
                .Include(d => d.Client)
                .ThenInclude(d => d.user)
                .Include(x=>x.BookingRoom)
                .ThenInclude(x=>x.Rooms)
                 .ThenInclude(x=>x.Hotel)
                .Include(y=>y.dossierFlights)
                .ThenInclude(y => y.flight)
                .ThenInclude(y=>y.flightAirplanes )
                .ThenInclude(y=> y.airplane)
                .Include(y=>y.dossierFlights)
                .ThenInclude(y => y.flight)
                .ThenInclude(y=>y.flightAirports)
                .ThenInclude(y=> y.airport)
                .Where(d => d.Client.user.FirstName == firstName && d.Client.user.LastName == lastName)
                .ToList();
        }

        public Dossier GetById(Guid id)
        {
            return _dbContext.Set<Dossier>().FirstOrDefault(d => d.Id == id);
        }
     public Dossier CreateDossier(Dossier dossier)
    {
        _dbContext.Dossiers.Add(dossier);
        _dbContext.SaveChanges();
        return dossier;
    }
    }
}
