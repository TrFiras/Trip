using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class RoomViewModel : BaseModelViewModel
{
    public string Type { get; set; }
    public double Price { get; set; }
    public decimal Discount { get; set; }
    public bool IsAvailable { get; set; }
    public Guid HotelId { get; set; }
    public HotelViewModel Hotel { get; set; }
    public ICollection<BookingRoomViewModel> BookingRoom { get; set; }
    public ICollection<ExtraViewModel> Extra { get; set; }
}
}