using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("WorkCard")]
public class WorkCard
{
    [DisplayName("Номер карты"), Key]
    public int CardId { get; set; }

    [DisplayName("Начало учебного года"), Column(TypeName = "date")]
    public DateOnly StartPeriod { get; set; }

    [DisplayName("Конец учебного года"), Column(TypeName = "date")]
    public DateOnly EndPeriod { get; set; }

    [DisplayName("ФИО Преподавателя")]
    public virtual Lecturer? Lecturer { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }
}