using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class BookingRoomViewModel
    {
          public Guid Id { get; set; }
    public string Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<RoomViewModel> Rooms { get; set; }
    }
}