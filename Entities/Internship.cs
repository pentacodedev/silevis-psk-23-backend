using HackathonApi.DTOs;
using Nelibur.ObjectMapper;

namespace HackathonApi.Entities;


public class Internship
{
    public int Id { get; set; }
    public required Company IntershipCreator { get; set; }
    public required DateTime DateOfStart { get; set; }
    public required DateTime DateOfEnd { get; set; }
    public required DateTime RecrutationStart { get; set; }
    public required DateTime RecrutationEnd { get; set; }
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
