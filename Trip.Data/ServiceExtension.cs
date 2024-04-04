using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using trip.Data.Repositories;
using Trip.Data.Interfaces;
using Trip.Data.Repositories;

namespace Trip.Data.ServicesExtensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContextClass>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }
    }
}
