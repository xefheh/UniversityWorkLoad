using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("Discipline")]
public class Discipline
{
    [DisplayName("Идентификатор дисциплины"), Key, FilterCriteria]
    public int DisciplineId { get; set; }

    [DisplayName("Наименование дисциплины"), FilterCriteria]
    public string? DisciplineName { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }

    public override string ToString() => DisciplineName;
}