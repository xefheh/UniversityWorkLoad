using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Faculty))]
public class FacultyDataFormatter : IDataFormatter<Faculty>
{
    public Faculty Create(object[] parameters) => new() { FacultyName = (string)parameters[0] };

    public void Update(Faculty data, object[] parameters) => data.FacultyName = (string)parameters[0];
}