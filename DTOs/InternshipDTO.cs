using HackathonApi.Entities;
using Nelibur.ObjectMapper;

namespace HackathonApi.DTOs
{
    public class InternshipDTO
    {
        public int Id { get; set; }
        public required DateTime DateOfStart { get; set; }
        public required DateTime DateOfEnd { get; set; }
        public required string CompanyName { get; set; }
        public required string CompanyAddress { get; set; }
        public required string CompanyNipNumber { get; set; }
        public required string CompanyKrsNumber { get; set; }
        public required string CompanyEmail { get; set; }
        public required string CompanyPhoneNumber { get; set; }
        public required string CompanyRegonNumber { get; set; }
        public required string CompanyRepresentativeFirstname { get; set; }
        public required string CompanyRepresentativeSurname { get; set; }
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
