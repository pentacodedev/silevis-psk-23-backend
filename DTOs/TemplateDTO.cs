using HackathonApi.Entities;

namespace HackathonApi.DTOs
{
    public class TemplateDTO
    {
        public InternshipDTO Internship { get; set; }
        public User User { get; set; } 
        
        public bool Polish { get; set; }
    }
}
