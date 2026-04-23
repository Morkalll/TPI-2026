using Domain.Enums;

namespace Domain.Entities;

public class Recepcionist : User
{
    public string EmployeeNumber { get; set; } = string.Empty;
    public string Shift { get; set; } = string.Empty;
    public string Sector { get; set; } = string.Empty;

    public Recepcionist() { Role = UserRole.Recepcionist; }
}

