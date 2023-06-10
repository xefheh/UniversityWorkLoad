using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(WorkLoadLine))]
public class WorkLoadLineDataFormatter : IDataFormatter<WorkLoadLine>
{
    public WorkLoadLine Create(object[] parameters)
    {
        throw new NotImplementedException();
    }

    public void Update(WorkLoadLine data, object[] parameters)
    {
        throw new NotImplementedException();
    }
}