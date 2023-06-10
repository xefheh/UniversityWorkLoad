using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[PrimaryKey(nameof(PositionId))]
public class Position
{
    [DisplayName("Идентификатор должности"), Key]
    public int PositionId { get; set; }

    [DisplayName("Наименование должности")]
    public string? PositionName { get; set; }

    [DisplayName("Максимальная учебная нагрузка")]
    public decimal UpLimit { get; set; }

    [DisplayName("Минимальная учебная нагрузка")]
    public decimal LowerLimit { get; set; }

    [Browsable(false)]
    public ICollection<Lecturer> Lecturers { get; set; }
}