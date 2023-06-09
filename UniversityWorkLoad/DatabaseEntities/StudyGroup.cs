using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("StudyGroup")]
public class StudyGroup
{
    [DisplayName("Идентификатор группы"), Key]
    public int GroupId { get; set; }

    [DisplayName("Наименование группы")]
    public string? GroupName { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }
}