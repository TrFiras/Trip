using System;
using System.Collections.Generic;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
using DossierVM = Trip.API.ViewModels.TripDossierViewModel;
namespace Trip.Api.ViewModels
{
    public class ClientViewModel : UserViewModel
{
    public Guid ClientId { get; set; }
    public string PassportNumber { get; set; }
    public bool IsActive { get; set; }
    public Guid AdresseId { get; set; }
        public Guid UserId { get; set; }
        public AddressViewModel Address { get; set; }
        public UserViewModel user { get; set; }
    }
}