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

    [DisplayName("Дата"), Column(TypeName = "date")]
    public DateOnly Date { get; set; }


    [DisplayName("ФИО Преподавателя")]
    public virtual Lecturer? Lecturer { get; set; }

    [Browsable(false)]
    public ICollection<WorkLoadLine> WorkLoadLines { get; set; }
}