using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Trip.Data.Models;
using Trip.Services.DTO;

namespace Trip.Services.Interfaces
{
    public interface IDossierService
    {
        DossierDTO AddDossier(DossierDTO tripDossier);
        IEnumerable<DossierDTO> GetAll();
        IEnumerable<DossierDTO> GetDossiersByClientName(string firstName, string lastName);

        BookedRoomInfoDTO BookRoom(DateTime dateDebut, DateTime dateFin, Guid UserID, List<RoomDTO> myBookedRooms);
    }
}
