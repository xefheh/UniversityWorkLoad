using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("Discipline")]
public class Discipline
{
    [DisplayName("Идентификатор дисциплины"), Key]
    public int DisciplineId { get; set; }

    [DisplayName("Наименование дисциплины")]
    public string? DisciplineName { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }

    public override string ToString() => DisciplineName;
}