using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
   public class UserDTO : BaseModelDTO
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
   
    public string PassportNumber { get; set; }
       public AddressDTO Adresse { get; set; } // Foreign key
}
}