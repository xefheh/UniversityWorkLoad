using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("WorkCard")]
public class WorkCard
{
    [DisplayName("Номер карты"), Key, FilterCriteria]
    public int CardId { get; set; }

    [DisplayName("Дата"), Column(TypeName = "date"), FilterCriteria]
    public DateOnly Date { get; set; }


    [DisplayName("ФИО Преподавателя"), FilterCriteria]
    public virtual Lecturer? Lecturer { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }

    public override string ToString() => $"{CardId}: {Lecturer}: {Date}";
}