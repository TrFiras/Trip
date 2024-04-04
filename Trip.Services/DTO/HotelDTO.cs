using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
    public partial class HotelDTO : BaseModelDTO
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
    public AddressDTO Address { get; set; }
}
}