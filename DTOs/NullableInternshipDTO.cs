using HackathonApi.Entities;
using Nelibur.ObjectMapper;

namespace HackathonApi.DTOs
{
    public class NullableInternshipDTO
    {
        public int? Id { get; set; }
        public DateTime? DateOfStart { get; set; }
        public DateTime? DateOfEnd { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? CompanyNipNumber { get; set; }
        public string? CompanyKrsNumber { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhoneNumber { get; set; }
        public string? CompanyRegonNumber { get; set; }
        public string? CompanyRepresentativeFirstname { get; set; }
        public string? CompanyRepresentativeSurname { get; set; }
        public string? StudentEmail { get; set; }
        public string? ManagerEmail { get; set; }
        public bool? IsSigned { get; set; }

        public static NullableInternshipDTO FromEntity(Internship internship)
        {
            TinyMapper.Bind<Internship, NullableInternshipDTO>();
            TinyMapper.Bind<Company, CompanyDTO>();

            return TinyMapper.Map<NullableInternshipDTO>(internship);
        }
    }


}
