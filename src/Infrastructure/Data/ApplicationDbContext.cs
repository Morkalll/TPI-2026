using System.Reflection;
using TPI_2026.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TPI_2026.Domain.Enums;
using TPI_2026.Application.Common.Interfaces;


namespace TPI_2026.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
   : DbContext(options), IApplicationDbContext
{
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Recepcionist> Recepcionists => Set<Recepcionist>();
    public DbSet<Administrator> Administrators => Set<Administrator>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Appointment> Appoiments => Set<Appointment>();
    public DbSet<MedicalHistory> MedicalHistories => Set<MedicalHistory>();
    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Tell EF Core to ignore these — they are not database entities
        builder.Ignore<Domain.Common.BaseEvent>();

        // Picks up all IEntityTypeConfiguration<T> classes in this assembly
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    // Dispatches domain events after SaveChanges
    public override async Task<int> SaveChangesAsync(CancellationToken ct = default)
    {
        var result = await base.SaveChangesAsync(ct);
        return result;
    }



}