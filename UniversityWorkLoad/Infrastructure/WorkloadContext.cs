using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.Infrastructure;

public class WorkloadContext : DbContext
{
    private readonly string _connectionString;

    public WorkloadContext(string connectionString)
    {
        _connectionString = connectionString;
        Database.EnsureCreated();
    }

    [ReflexionDbEntities]
    public DbSet<Discipline> Disciplines { get; set; }

    [ReflexionDbEntities]
    public DbSet<Faculty> Faculties { get; set; }

    [ReflexionDbEntities]
    public DbSet<Lecturer> Lecturers { get; set; }

    [ReflexionDbEntities]
    public DbSet<Position> Positions { get; set; }

    [ReflexionDbEntities]
    public DbSet<StudyGroup> StudyGroups { get; set; }

    [ReflexionDbEntities]
    public DbSet<WorkCard> WorkCards { get; set; }

    [ReflexionDbEntities]
    public DbSet<WorkLoadLine> WorkLoadLines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkLoadLine>().HasKey(x => new { x.WorkCardId, x.LineId });
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql(_connectionString);
}