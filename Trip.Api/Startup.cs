using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Text.Json.Serialization;
using Trip.Services.Interfaces;
using Trip.Services.Services;
using Trip.Data.ServicesExtensions;
using Trip.Data.Repositories;
using Trip.Services.DTO;
using Trip.Data.Interfaces;
namespace Trip.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDIServices(Configuration);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IAirportService, AirportService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IBookingRoomService, BookingRoomService>();
            services.AddScoped<IDossierService, DossierService>();
           
              // Add the following line to register the IDossierRepository service
            services.AddScoped<IDossierRepository, DossierRepository>();
            services.AddScoped<IAdressRepository, AdressRepository>();
            services.AddScoped<IBookingRoomRepository, BookingRoomRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddGraphQLServer()
           .AddQueryType<GraphQLQueryType>()
           .AddType<graphql.HotelType>()
           .AddApolloTracing();

            #region Allow-Orgin
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });
            #endregion

            //Add Config for Required Email
            services.Configure<IdentityOptions>(
                opts => opts.SignIn.RequireConfirmedEmail = true
                );

            //Add Email Configs
            var emailConfig = Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);

            services.AddScoped<IEmailService, EmailService>();
            services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

            services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API Title", Version = "v1" });
    });
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

                app.UseDeveloperExceptionPage();
               
                app.UseSwagger();
           
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Name v1");
                });
             

   }
            app.UseHttpsRedirection();
          
  
            app.UseRouting();

            app.UseAuthorization();
            // Enable CORS
            app.UseCors("AllowOrigin");
            app.UseStaticFiles();
        
    
    

            app.UseEndpoints(endpoints =>
              {
                  endpoints.MapControllers();
              
               endpoints.MapGraphQL(path:"/graphql");

              });
        }
    }
}
