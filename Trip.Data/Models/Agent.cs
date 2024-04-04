using System;

namespace Trip.Data.Models
{
    public class Agent : User
{
    public Guid AgentId { get; set; }
    public DateTime EnrollmentDate { get; set; }
}
}