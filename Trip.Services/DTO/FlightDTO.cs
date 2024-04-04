using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
  public class FlightDTO : BaseModelDTO
{
    public Guid Id { get; set; }
    public DateTime FlightDate { get; set; }
    public string FlightNumber { get; set; }
}
}