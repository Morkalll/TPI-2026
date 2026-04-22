using Domain.Enums;
using TPI_2026.Domain.Constants;

namespace Domain.Entities;

// Patient hereda de User
public class Patient : User
{
    public string Dni {get; set;} = string.Empty;
    public string BirthDate {get; set;} = string.Empty;
    public string PhoneNumber {get; set;} = string.Empty;
    
    public string Adress {get; set;} = string.Empty;

    /* El intefaz ICollection se usa para guardar colecciones de objetos,
    como los turnos y los historiales medicos 
    (revisar la privacidad de metodos get y set)
    */
    public ICollection<Appointment> Appointments { get; private set; } = [];
    public ICollection<History> Histories { get; private set; } = [];

    public Patient() { Role = UserRole.Patient; }
}




