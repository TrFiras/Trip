using System;

namespace Trip.Data.Models
{
    public class RoomExtra
    {
        public Guid RoomId { get; set; }
        public Guid ExtraId { get; set; }
        public Room room { get; set; }
        public Extra extra { get; set; }
    }
    }
