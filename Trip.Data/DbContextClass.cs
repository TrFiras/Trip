using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trip.Data.Models;

namespace Trip.Data
{
  public class DbContextClass : DbContext
   {
        public DbContextClass()
        {
        }

        public DbContextClass(DbContextOptions<DbContextClass> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Dossier> Dossiers { get; set; }
        public DbSet<DossierFlight> DossierFlights { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<FellowTraveller> FellowTravellers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightAirplanes> FlightAirplanes { get; set; }
        public DbSet<FlightAirports> FlightAirports { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBookingRoom> RoomBookingRooms { get; set; }
        public DbSet<RoomExtra> RoomExtras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure SQLite
            optionsBuilder.UseSqlite("Data Source=trip_database3.db");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            
            modelBuilder.Entity<Extra>().HasIndex(h => h.OptionName).IsUnique();
            modelBuilder.Entity<Airplane>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<Airplane>().Property(h => h.Name).HasMaxLength(20);
            modelBuilder.Entity<Airplane>().Property(h => h.Capacity).HasMaxLength(8);
            modelBuilder.Entity<Airplane>().Property(h => h.Company).HasMaxLength(50);

            modelBuilder.Entity<Airport>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<Airport>().Property(h => h.Code).HasMaxLength(50);

            modelBuilder.Entity<Hotel>().HasIndex(h => h.Name).IsUnique();
            modelBuilder.Entity<User>().HasIndex(h => h.Email).IsUnique();
            modelBuilder.Entity<User>().Property(h => h.Email).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(h => h.Password).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(h => h.PhoneNumber).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(h => h.FirstName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(h => h.LastName).HasMaxLength(50);

            modelBuilder.Entity<Client>().HasIndex(h => h.PassportNumber).IsUnique();
            modelBuilder.Entity<Client>().Property(h => h.PassportNumber).HasMaxLength(50);
            modelBuilder.Entity<FellowTraveller>().Property(h => h.PassportNumber).HasMaxLength(50);
            modelBuilder.Entity<FellowTraveller>().Property(h => h.Relationship).HasMaxLength(50);
            modelBuilder.Entity<Address>().Property(h => h.Country).HasMaxLength(100);
            modelBuilder.Entity<Address>().Property(h => h.Region).HasMaxLength(100);
            modelBuilder.Entity<Address>().Property(h => h.PostalCode).HasMaxLength(10);

            modelBuilder.Entity<Airport>()
            .HasOne(c => c.address)
            .WithMany()
            .HasForeignKey(c => c.AdressId);

            modelBuilder.Entity<Client>()
                .HasOne(c => c.address)
                .WithMany()
                .HasForeignKey(c => c.AdresseId);

            modelBuilder.Entity<DossierFlight>()
                .HasKey(df => new { df.DossierId, df.FlightId });

            modelBuilder.Entity<FlightAirplanes>()
                .HasKey(fa => new { fa.FlightId, fa.AirplaneId });

            modelBuilder.Entity<FlightAirports>()
                .HasKey(fa => new { fa.FlightId, fa.AirportId });

            modelBuilder.Entity<RoomBookingRoom>()
                .HasKey(rb => new { rb.RoomId, rb.BookingRoomId });

            modelBuilder.Entity<RoomExtra>()
                .HasKey(re => new { re.RoomId, re.ExtraId });
        }
    }}