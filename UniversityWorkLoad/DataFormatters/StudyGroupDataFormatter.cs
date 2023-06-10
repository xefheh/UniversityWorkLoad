using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(StudyGroup))]
public class StudyGroupDataFormatter : IDataFormatter<StudyGroup>
{
    public StudyGroup Create(object[] parameters)
    {
        throw new NotImplementedException();
    }

    public void Update(StudyGroup data, object[] parameters)
    {
        throw new NotImplementedException();
    }
}