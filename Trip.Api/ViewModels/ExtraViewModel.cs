
using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class ExtraViewModel : BaseModelViewModel
{
    public string OptionName { get; set; }
    public bool IsFree { get; set; }
    public decimal OptionPrice { get; set; }
    public bool IsActive { get; set; }
    public string Icon { get; set; }
    public ICollection<RoomViewModel> Rooms { get; set; }
}
}