using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(WorkCard))]
public class WorkCardDataFormatter : IDataFormatter<WorkCard>
{
    public WorkCard Create(object[] parameters) => new()
    {
        StartPeriod = (DateOnly)parameters[0],
        EndPeriod = (DateOnly)parameters[1],
        Lecturer = (Lecturer)parameters[2]
    };

    public void Update(WorkCard data, object[] parameters)
    {
        data.StartPeriod = (DateOnly)parameters[0];
        data.EndPeriod = (DateOnly)parameters[1];
        data.Lecturer = (Lecturer)parameters[2];
    }
}