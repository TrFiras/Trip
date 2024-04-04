using System;

namespace Trip.Data.Models
{
    public class BaseModel
    {
        public DateTime? CreatedAt {get; set;}
        public string? CreatedBy {get; set;}
        public DateTime? LastModifiedAt {get; set;}
        public string? ModifiedBy {get; set;}
        public Guid Id {get; set;}
    }
}