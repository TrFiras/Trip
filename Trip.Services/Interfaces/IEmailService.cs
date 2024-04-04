using Trip.Services.DTO;

namespace Trip.Services.Interfaces
{
    public interface IEmailService
    {
           void SendEmail(Message message);
    }
}