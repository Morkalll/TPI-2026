using TPI_2026.Domain.Entities;

namespace TPI_2026.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Patient> Patients { get; }
    DbSet<Doctor> Doctors { get; }
    DbSet<Recepcionist> Recepcionists { get; }
    DbSet<Administrator> Administrators { get; }
    DbSet<Room> Rooms { get; }
    DbSet<Appointment> Appoiments { get; }
    DbSet<MedicalHistory> MedicalHistories { get; }
    DbSet<TodoList> TodoLists { get; }
    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
