using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(WorkCard))]
public class WorkCardDataFormatter : IDataFormatter<WorkCard>
{
    public WorkCard Create(object[] parameters) => new()
    {
        Date = (DateOnly)parameters[0],
        Lecturer = (Lecturer)parameters[1]
    };

    public void Update(WorkCard data, object[] parameters)
    {
        data.Date = (DateOnly)parameters[0];
        data.Lecturer = (Lecturer)parameters[1];
    }
}