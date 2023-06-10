using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Discipline))]
public class DisciplineDataFormatter : IDataFormatter<Discipline>
{
    public Discipline Create(object[] parameters)
    {
        throw new NotImplementedException();
    }

    public void Update(Discipline data, object[] parameters)
    {
        throw new NotImplementedException();
    }
}