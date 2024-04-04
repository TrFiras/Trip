using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
    public class Client
{
    public Guid ClientId { get; set; }
    public string PassportNumber { get; set; }
    public bool IsActive { get; set; }
    public Guid? AdresseId { get; set; } // Foreign key
    public Guid UserId { get; set; } // Foreign key
    public virtual ICollection<FellowTraveller>? FellowTravellers { get; set; } 
    public virtual ICollection<Dossier>? Dossiers { get; set; } 
    public Address address {get; set;}
    public User user { get; set;}

}
}