using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
    public class Room:BaseModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public decimal Discount { get; set; }
        public bool IsAvailable { get; set; }
  
        public Guid HotelId { get; set; } // Foreign key
        

        public Hotel Hotel { get; set; }
        public virtual ICollection<BookingRoom> BookingRoom { get; set; }
           public virtual ICollection<Extra> Extra { get; set; } 
    }
}