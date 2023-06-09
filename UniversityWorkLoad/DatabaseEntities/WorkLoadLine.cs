using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UniversityWorkLoad.DatabaseEntities;

[Table("WorkLoadLine")]
public class WorkLoadLine
{
    [DisplayName("Номер строки"), Key]
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

