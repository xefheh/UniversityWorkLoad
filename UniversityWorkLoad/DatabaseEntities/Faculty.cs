using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("Faculty")]
public class Faculty
{
    [DisplayName("Идентификатор кафедры"), Key, 
     DatabaseGenerated(DatabaseGeneratedOption.Identity), FilterCriteria]
    public int FacultyId { get; set; }

    [DisplayName("Наименование кафедры"), FilterCriteria]
    public string? FacultyName { get; set; }

    [Browsable(false)]
    public virtual ICollection<Lecturer> Lecturers { get; set; }

    public override string ToString() => FacultyName;
}