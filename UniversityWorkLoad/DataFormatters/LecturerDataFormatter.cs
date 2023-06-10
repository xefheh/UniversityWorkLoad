using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Lecturer))]
public class LecturerDataFormatter : IDataFormatter<Lecturer>
{
    public Lecturer Create(object[] parameters)
    {
        throw new NotImplementedException();
    }

    public void Update(Lecturer data, object[] parameters)
    {
        throw new NotImplementedException();
    }
}