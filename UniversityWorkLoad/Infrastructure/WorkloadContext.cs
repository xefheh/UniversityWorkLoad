using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.Infrastructure;

public class WorkloadContext : DbContext
{
    private readonly string _connectionString;

    public WorkloadContext(string connectionString)
    {
        _connectionString = connectionString;
    }


    public DbSet<Discipline> Disciplines { get; set; }

    public DbSet<Faculty> Faculties { get; set; }

    public DbSet<Lecturer> Lecturers { get; set; }

    public DbSet<Position> Positions { get; set; }

    public DbSet<StudyGroup> StudyGroups { get; set; }

    public DbSet<WorkCard> WorkCards { get; set; }

    public DbSet<WorkLoadLine> WorkLoadLines { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorkLoadLine>().HasKey(line => new {line.LineId});
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite(_connectionString);
}