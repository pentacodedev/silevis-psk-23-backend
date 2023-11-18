using HackathonApi.DTOs;
using Nelibur.ObjectMapper;

namespace HackathonApi.Entities;


public class Internship
{
    public int Id { get; set; }



    public required string CompanyName { get; set; }
    public required string CompanyAddress { get; set; }
    public required string CompanyNipNumber { get; set; }
    public required string CompanyKrsNumber { get; set; }
    public required string CompanyEmail { get; set; }
    public required string CompanyPhoneNumber { get; set; }
    public required string CompanyRegonNumber { get; set; }
    public required string CompanyRepresentativeFirstname { get; set; }
    public required string CompanyRepresentativeSurname { get; set; }


    public required DateTime DateOfStart { get; set; }
    public required DateTime DateOfEnd { get; set; }
    public string? StudentEmail { get; set; }
    public string? ManagerEmail { get; set; }
    public bool HasStudent => StudentEmail != null;
    public int DaysUntilExpired => (DateTime.Now - DateOfStart).Days;
    public bool IsSigned { get; set; }

    public static Internship FromDTO(InternshipDTO dto)
    {
        dto.Id = 0;
        TinyMapper.Bind<InternshipDTO, Internship>();
        return TinyMapper.Map<Internship>(dto);
    }
}
