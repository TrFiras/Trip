using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
    public class FellowTravellerDTO : BaseModelDTO
{
    public Guid Id { get; set; }
    public string Relationship { get; set; }
    public string PassportNumber { get; set; }
    public int Age { get; set; }
    public Guid? ClientId { get; set; }
    public ClientDTO Client { get; set; }
}
}