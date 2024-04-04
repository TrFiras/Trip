using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class HotelViewModel : BaseModelViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid AddressId { get; set; }
    public string Ville { get; set; }
    public string Website { get; set; }
    public double Rating { get; set; }
    public string Image { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int NumberOfRooms { get; set; }
    public ICollection<RoomViewModel> Rooms { get; set; }
    public AddressViewModel Address { get; set; }
}
}