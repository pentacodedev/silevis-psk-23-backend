using HackathonApi.Entities;
using Nelibur.ObjectMapper;

namespace HackathonApi.DTOs
{
    public class InternshipDTO
    {
        public int Id { get; set; }
        public required CompanyDTO IntershipCreator { get; set; }
        public required DateTime DateOfStart { get; set; }
        public required DateTime DateOfEnd { get; set; }
        public required DateTime RecrutationStart { get; set; }
        public required DateTime RecrutationEnd { get; set; }
        public string? StudentEmail { get; set; }
        public string? ManagerEmail { get; set; }
        public bool IsSigned { get; set; }

        public static InternshipDTO FromEntity(Internship internship)
        {
            TinyMapper.Bind<Internship, InternshipDTO>();
            TinyMapper.Bind<Company, CompanyDTO>();

            return TinyMapper.Map<InternshipDTO>(internship);
        }
    }


}
