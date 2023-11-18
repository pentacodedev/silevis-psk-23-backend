﻿using HackathonApi.Entities;

namespace HackathonApi.DTOs;

public class UserDTO
{
    public int Id { get; set; }
    public  required string LastName { get; set; }
    public required string FirstName { get; set; }
    public required string Email { get; set; }
    public required string StudentNumber { get; set; }
    public required List<StudentProgramme> StudentProgrammes { get; set; }
}

