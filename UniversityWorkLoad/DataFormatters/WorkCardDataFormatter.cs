using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(WorkCard))]
public class WorkCardDataFormatter : IDataFormatter<WorkCard>
{
    public WorkCard Create(object[] parameters)
    {
        throw new NotImplementedException();
    }

    public void Update(WorkCard data, object[] parameters)
    {
        throw new NotImplementedException();
    }
}