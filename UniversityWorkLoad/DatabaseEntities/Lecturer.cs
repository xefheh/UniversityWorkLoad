using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.DatabaseEntities;

public class Lecturer
{
    [DisplayName("Табельный номер"), Key, FilterCriteria]
    public int ReportCardId { get; set; }

    [DisplayName("Кафедра"), FilterCriteria]
    public virtual Faculty? Faculty { get; set; }

    [DisplayName("Должность"), FilterCriteria]
    public virtual Position? Position { get; set; }

    [DisplayName("Фамилия"), FilterCriteria]
    public string? Surname { get; set; }

    [DisplayName("Имя"), FilterCriteria]
    public string? Name { get; set; }

    [DisplayName("Отчество"), FilterCriteria]
    public string? MiddleName { get; set; }

    public override string ToString() => $"{Surname} {Name[0]}. {MiddleName[0]}.";

    [Browsable(false)]
    public ICollection<WorkCard> WorkCards { get; set; }

    [Browsable(false)]
    public byte[] Photo { get; set; }
}