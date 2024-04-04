using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Trip.Services.DTO
{
    public class ExtraDTO : BaseModelDTO
{
    public Guid Id { get; set; }
    public string OptionName { get; set; }
    public bool IsFree { get; set; }
    public decimal OptionPrice { get; set; }
    public bool IsActive { get; set; }
    public string Icon { get; set; }
}
}