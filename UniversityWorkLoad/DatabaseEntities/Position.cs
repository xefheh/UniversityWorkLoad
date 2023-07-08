using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.DatabaseEntities;

[PrimaryKey(nameof(PositionId))]
public class Position
{
    [DisplayName("Идентификатор должности"), Key, FilterCriteria]
    public int PositionId { get; set; }

    [DisplayName("Наименование должности"), FilterCriteria]
    public string? PositionName { get; set; }

    [DisplayName("Максимальная учебная нагрузка"), FilterCriteria]
    public decimal UpLimit { get; set; }

    [DisplayName("Минимальная учебная нагрузка"), FilterCriteria]
    public decimal LowerLimit { get; set; }

    [Browsable(false)]
    public ICollection<Lecturer> Lecturers { get; set; }

    public override string ToString() => PositionName;
}