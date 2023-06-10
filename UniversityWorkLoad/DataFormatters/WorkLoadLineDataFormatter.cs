using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(WorkLoadLine))]
public class WorkLoadLineDataFormatter : IDataFormatter<WorkLoadLine>
{
    public WorkLoadLine Create(object[] parameters) => new()
    {
        WorkCard = (WorkCard)parameters[0],
        Discipline = (Discipline)parameters[1],
        StudyGroup = (StudyGroup)parameters[2],
        LectureHours = (int)parameters[3],
        PracticeHours = (int)parameters[4],
        OtherHours = (int)parameters[5]
    };

    public void Update(WorkLoadLine data, object[] parameters)
    {
        data.WorkCard = (WorkCard)parameters[0];
        data.Discipline = (Discipline)parameters[1];
        data.StudyGroup = (StudyGroup)parameters[2];
        data.LectureHours = (int)parameters[3];
        data.PracticeHours = (int)parameters[4];
        data.OtherHours = (int)parameters[5];
    }
}