using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class UserViewModelData : BaseModelViewModel
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
     public string PassportNumber { get; set; }
        public string Adresse { get; set; } 
}
}