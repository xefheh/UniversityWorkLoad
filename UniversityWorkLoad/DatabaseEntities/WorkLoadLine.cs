using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("WorkLoadLine")]
public class WorkLoadLine
{
    [Browsable(false), Key, ForeignKey(nameof(WorkCard)), Column(Order = 2)] public int WorkCardId { get; set; }


    [DisplayName("Номер строки"), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 1)]
    public int LineId { get; set; }

    [DisplayName("Номер карты")]
    public virtual WorkCard? WorkCard { get; set; }


    [DisplayName("Рабочая группа")]
    public virtual StudyGroup? StudyGroup { get; set; }


    [DisplayName("Дисциплина")]
    public virtual Discipline? Discipline { get; set; }
    
    [DisplayName("Лекционные часы")]
    public int LectureHours { get; set; }

    [DisplayName("Практические часы")]
    public int PracticeHours { get; set; }

    [DisplayName("Прочие часы")]
    public int OtherHours { get; set; }
}

