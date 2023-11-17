namespace HackathonApi.Entities;

public class Company
{
     public int Id { get; set; }
     public required string Name  { get; set; }
     public required string Address { get; set; }
    public required string NipNumber { get; set; }
    public required string KrsNumber { get; set; }
    public required string RegonNumber { get; set; }
    public required List<User> Representatives { get; set; }
    public required List<Intership> Interships { get; set; }
}