namespace HackathonApi.Entities;

public class Company
{
    public int Id { get; set; }
    public required string Name  { get; set; }
    public required string Address { get; set; }
    public required string NipNumber { get; set; }
    public required string KrsNumber { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string RegonNumber { get; set; }
    public required string RepresentativeFirstname { get; set; }
    public required string RepresentativeSurname { get; set; }
}