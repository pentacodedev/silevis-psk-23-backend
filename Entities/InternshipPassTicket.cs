using HackathonApi.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace HackathonApi.Entities
{
    public class InternshipPassTicket
    {
        int Id { get; set; }
        public string StudentEmail { get; set; }
        public byte[] Attachment { get; set; }
        public TicketStatusEnum Status { get; set; }

    }
}
