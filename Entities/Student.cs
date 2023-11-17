namespace HackathonApi.Entities;

public class Student
{
    public int Id { get; set; }
    public  required string Name { get; set; }
    public string? FirstName { get; set; }
    public required bool FullTimeStudies { get; set; }
    public int YearOfStudies { get; set;}
    public int IndexNumber { get; set; }
}

