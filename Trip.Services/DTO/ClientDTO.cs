using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trip.Data.Models;
namespace Trip.Services.DTO
{
    public class ClientDTO : UserDTO
{
    public Guid ClientId { get; set; }
    public string PassportNumber { get; set; }
    public bool IsActive { get; set; }
    public Guid AdresseId { get; set; }
    public Guid UserId { get; set; } 
    public AddressDTO Address { get; set; }
    public UserDTO user { get; set; }
    }
}