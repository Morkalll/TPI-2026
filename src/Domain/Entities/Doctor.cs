using Domain.Enums;

namespace Domain.Entities;

// Doctor hereda de User
public class Doctor : User
{
    public string Credential {get; set;} = string.Empty;
    // Atributo Specialty es del tipo enum Specialty
    public string Specialty Specialty {get; set;}
    public List<int> Rooms { get; private set; } = [];
    public bool Disponible { get; set; } = true;

    //Cardinalidades
    public ICollection<Room> Rooms { get; private set; } = [];
    public ICollection<Appointment> Appointments { get; private set; } = [];

    public Doctor() { Role = UserRole.Doctor; }
}

}
  
