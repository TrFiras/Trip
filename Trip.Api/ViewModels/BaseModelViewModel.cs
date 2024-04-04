using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class BaseModelViewModel
    {
         public DateTime? CreatedAt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public string ModifiedBy { get; set; }
    }
}