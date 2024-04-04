using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
    public partial class Hotel:BaseModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public Guid AddressId { get; set; } 

        public string Ville { get; set; } = null!;

        public string Website { get; set; } = null!;

        public double Rating { get; set; }

        public string Image { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int NumberOfRooms { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
        public Address address {get; set;}
      
    }
}