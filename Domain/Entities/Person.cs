﻿namespace Domain.Entities;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int DocumentType { get; set; }
    public string DocumentNumber { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}