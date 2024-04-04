using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class UserViewModel : BaseModelViewModel
{
        public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
     public string PassportNumber { get; set; }
        public AddressViewModel Adresse { get; set; } 
}
}