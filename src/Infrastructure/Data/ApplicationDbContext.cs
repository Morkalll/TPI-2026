using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Domain.Enums;


namespace  TPI_2026.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
   :DbContext(options)
{
    public DbSet<Patient> Patients => Set<Patient>();
    public DbSet<Doctor> Doctors => Set<Doctor>();
    public DbSet<Recepcionist> Recepcionists => Set<Recepcionist>();
    public DbSet<Administrator> Administrators => Set<Administrator>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Appointment> Appoiments => Set<Appointment>();
    public DbSet<History> Histories => Set<History>();

     protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
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