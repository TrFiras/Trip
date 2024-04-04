using System;
using System.Collections.Generic;

namespace Trip.Data.Models
{
    public class Extra:BaseModel
    {
        public Guid Id { get; set; }
        public string OptionName { get; set; }
        public bool IsFree { get; set; }
        public decimal OptionPrice { get; set; }
        public bool IsActive { get; set; }
        public string Icon { get; set; }
    

        public virtual ICollection<Room> Rooms { get; set; }
    }
}