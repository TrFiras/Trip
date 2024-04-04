using System;

namespace Trip.Data.Models
{
    public class FellowTraveller:BaseModel
{
    public Guid Id { get; set; }
    public string Relationship { get; set; }
    public string PassportNumber { get; set; }
    public int Age { get; set; }
    public Guid? ClientId { get; set; }  // Foreign key

    public Client? client {get; set; }

}
}