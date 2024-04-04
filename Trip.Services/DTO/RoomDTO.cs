using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
    public class RoomDTO : BaseModelDTO
{
    public Guid Id { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
    public decimal Discount { get; set; }
    public bool IsAvailable { get; set; }
    public Guid HotelId { get; set; }
    public HotelDTO Hotel { get; set; }
    public ICollection<BookingRoomDTO> BookingRooms { get; set; }
    public ICollection<ExtraDTO> Extras { get; set; }
}
}