using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

public class Lecturer
{
    [DisplayName("Табельный номер"), Key]
    public int ReportCardId { get; set; }

    [DisplayName("Кафедра")]
    public virtual Faculty? Faculty { get; set; }

    [DisplayName("Должность")]
    public virtual Position? Position { get; set; }

    [DisplayName("Фамилия")]
    public string? Surname { get; set; }

    [DisplayName("Имя")]
    public string? Name { get; set; }

    [DisplayName("Отчество")]
    public string? MiddleName { get; set; }

    public override string ToString() => $"{Surname} + {Name[0]}. {MiddleName[0]}.";

    [Browsable(false)]
    public ICollection<WorkCard> WorkCards { get; set; }

    [Browsable(false)]
    public byte[] Photo { get; set; }
}