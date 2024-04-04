using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Trip.Data; // Assuming DbContextClass is in Trip.Data namespace
using Trip.Data.Models; // Assuming all entity classes are in Trip.Data.Models namespace

namespace DbUpBulkInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            var connectionString = "Data Source=trip_database3.db"; // Specify the relative path to your SQLite database file

            var optionsBuilder = new DbContextOptionsBuilder<DbContextClass>();
            optionsBuilder.UseSqlite(connectionString);
            // Assuming you have initialized DbContextClass instance
            using (var dbContext = new DbContextClass(optionsBuilder.Options))
            {

            var addressList = new List<Address> {
                new Address { Latitude=48.5F, Longitude=46F, City = "City1", Country = "Country1", Region = "Region1", PostalCode = "12345", CreatedAt = DateTime.Now, CreatedBy = "Admin", LastModifiedAt = DateTime.Now, ModifiedBy = "Admin" },
                new Address { Latitude=45.5F, Longitude=43F, City = "City2", Country = "Country2", Region = "Region2", PostalCode = "67890" , CreatedAt = DateTime.Now, CreatedBy = "Admin", LastModifiedAt = DateTime.Now, ModifiedBy = "Admin"}
            };

         

       
            // Bulk insert all data
            dbContext.Addresses.AddRange(addressList);
       

            dbContext.SaveChanges();
        }
    }
}
}
