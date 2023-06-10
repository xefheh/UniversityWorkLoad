using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(StudyGroup))]
public class StudyGroupDataFormatter : IDataFormatter<StudyGroup>
{
    public StudyGroup Create(object[] parameters) => new() { GroupName = (string)parameters[0] };

    public void Update(StudyGroup data, object[] parameters) => data.GroupName = (string)parameters[0];
}