using System;
using System.Collections.Generic;
namespace Trip.Api.ViewModels
{
    public class UserLoginViewModel : BaseModelViewModel
{
    public string Email { get; set; }
    public string Password { get; set; }
}
}