using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("Faculty")]
public class Faculty
{
    [DisplayName("Идентификатор кафедры"), Key]
    public int FacultyId { get; set; }

    [DisplayName("Наименование кафедры")]
    public string? FacultyName { get; set; }

    [Browsable(false)]
    public virtual ICollection<Lecturer> Lecturers { get; set; }
}