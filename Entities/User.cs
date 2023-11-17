namespace HackathonApi.Entities;

public class User
{
    public int Id { get; set; }
    public DateTime Created { get; set; } = DateTime.Now;
    public string Email { get; set; }
    public required int StaffStatus { get; set; }
    public string? FirstName { get; set; }
}
