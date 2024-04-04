using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using Trip.Services.DTO;
using Trip.Services.Interfaces;
using System.Threading.Tasks;
using Trip.Data;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Identity;
using Trip.Api.ViewModels.Authentication.Login;
using Microsoft.Extensions.Configuration;
namespace Trip.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        public readonly IClientService _clientService;
        public readonly IUserService _userService;
        public readonly DbContextClass _dbContext;
        public AuthenticationController(IEmailService emailService,
         DbContextClass dbContext,
         IClientService clientService,
         IUserService userService,
         UserManager<IdentityUser> userManager,
         SignInManager<IdentityUser> signInManager)
        {
            _emailService = emailService;
            _dbContext = dbContext;
            _clientService = clientService;
            _userService = userService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
         public IActionResult TestEmail(){
          var message = new Message(new string [] {"firas@yopmail.com"},"Test","<h1>you have receive a mail authentication from Travel Booking application</h1>");

          _emailService.SendEmail(message);
            return Ok("Email sent successfully!");

         }
       
      
        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(2),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }

    internal class Response
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }
}