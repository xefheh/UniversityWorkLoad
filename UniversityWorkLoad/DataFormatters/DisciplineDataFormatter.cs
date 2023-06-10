using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Discipline))]
public class DisciplineDataFormatter : IDataFormatter<Discipline>
{
    public Discipline Create(object[] parameters) => new() { DisciplineName = (string)parameters[0] };

    public void Update(Discipline data, object[] parameters) => data.DisciplineName = (string)parameters[0];
}