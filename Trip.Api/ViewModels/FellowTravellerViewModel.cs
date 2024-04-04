using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class FellowTravellerViewModel : BaseModelViewModel
{
    public string Relationship { get; set; }
    public string PassportNumber { get; set; }
    public int Age { get; set; }
    public Guid? ClientId { get; set; }
    public ClientViewModel Client { get; set; }
}
}