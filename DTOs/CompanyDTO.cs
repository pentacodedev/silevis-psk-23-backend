using HackathonApi.Entities;
using Nelibur.ObjectMapper;

namespace HackathonApi.DTOs
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required string NipNumber { get; set; }
        public required string KrsNumber { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string RegonNumber { get; set; }
        public required string RepresentativeFirstname { get; set; }
        public required string RepresentativeSurname { get; set; }
        public static CompanyDTO FromEntity(Company entity)
        {
            TinyMapper.Bind<Company, CompanyDTO>();
            return TinyMapper.Map<CompanyDTO>(entity);
        }
    }
}
