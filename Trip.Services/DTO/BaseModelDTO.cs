using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
   public class BaseModelDTO
{
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public string? ModifiedBy { get; set; }
}
}