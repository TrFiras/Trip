
using System;
using System.Collections.Generic;
using Trip.Data.Models;
using Address = Trip.Data.Models.Address;

namespace Trip.API.ViewModels;

public class GetHotelResponse
{    public Guid Id { get; set; }

    public string Name { get; set; }

    public  Address Adress { get; set; }

    public string Ville { get; set; }

    public string Website { get; set; }

    public double Rating { get; set; }

    public string Image { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public int NumberOfRooms { get; set; }
            public  ICollection<Room> Rooms { get; set; }


}