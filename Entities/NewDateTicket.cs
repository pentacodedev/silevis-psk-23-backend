using HackathonApi.DTOs;
using HackathonApi.Enums;
using Nelibur.ObjectMapper;

namespace HackathonApi.Entities
{
    public class NewDateTicket
    {
        public int Id { get; set; }
        public required string StudentEmail { get; set; }
        public string Description { get; set; } = "";
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public TicketStatusEnum Status { get; set; }
        public required Internship Intership { get; set; }
        public bool IsAccepted => (Status == TicketStatusEnum.Accepted);

        public static NewDateTicket FromDTO(NewDateTicketDTO dto)
        {
            TinyMapper.Bind<NewDateTicketDTO, NewDateTicket>();
            return TinyMapper.Map<NewDateTicket>(dto);
        }

    }
}
