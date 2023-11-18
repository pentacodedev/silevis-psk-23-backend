using HackathonApi.Entities;
using Nelibur.ObjectMapper;

namespace HackathonApi.DTOs;

public class StudentDTO
{
    public int Id { get; set; }
    public string Surname { get; set; }
    public string Firstname { get; set; }
    public bool FullTimeStudies { get; set; }
    public int YearOfStudies { get; set; }
    public int IndexNumber { get; set; }
    public StudentDTO()
    {
    }

    public static StudentDTO FromEntity(UserDTO student)
    {
        TinyMapper.Bind<UserDTO, StudentDTO>();
        return TinyMapper.Map<StudentDTO>(student);
    }
}
