using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("StudyGroup")]
public class StudyGroup
{
    [DisplayName("Идентификатор группы"), Key, FilterCriteria]
    public int GroupId { get; set; }

    [DisplayName("Наименование группы"), FilterCriteria]
    public string? GroupName { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }

    public override string ToString() => GroupName;
}