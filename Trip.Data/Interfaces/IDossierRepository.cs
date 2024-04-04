using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Entities;
using Trip.Data.Models;

namespace Trip.Data.Interfaces
{
    public interface IDossierRepository : IGenericRepository<Dossier>
    {
        Dossier GetById(Guid id);
        BookedRoomInfoEntity CreateDossier(DateTime dateDebut, DateTime dateFin,  Guid UserID,List<Room> myBookedRooms);
        Dossier CreateDossier(Dossier dossier);
        List<Dossier> GetAllReservations();
        List<Dossier> GetDossiersByClientName(string firstName, string lastName);
    }
}
