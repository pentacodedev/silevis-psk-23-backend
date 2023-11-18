using HackathonApi.Entities;
using HackathonApi.Enums;
using Nelibur.ObjectMapper;

namespace HackathonApi.DTOs
{
    public class NewDateTicketDTO
    {
        public int Id { get; set; }
        public required string StudentEmail { get; set; }
        public string Description { get; set; } = "";
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public TicketStatusEnum Status { get; set; }
        public required InternshipDTO Intership { get; set; }
        public bool IsAccepted => (Status == TicketStatusEnum.Accepted);

        public static NewDateTicketDTO FromEntity(NewDateTicket ticket)
        {
            TinyMapper.Bind<NewDateTicket, NewDateTicketDTO>();
            return TinyMapper.Map<NewDateTicketDTO>(ticket);
        }
        
    }
}
