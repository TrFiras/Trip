using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
    public class BookingRoom:BaseModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalAmount { get; set; }

        public ICollection<Room> Rooms { get; set; }
  
    }
}