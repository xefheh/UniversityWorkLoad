using System.ComponentModel;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(StudyGroup))]
    public BindingList<StudyGroup> GetStudyGroups() => _workloadContext.StudyGroups.Local.ToBindingList();

    [DbGetMethod(typeof(StudyGroup))]
    public StudyGroup GetStudyGroup(object identity) => _workloadContext.StudyGroups.Local.First(studyGroup => studyGroup.GroupId == (int)identity);

    [DbRemoveMethod(typeof(StudyGroup))]
    public void RemoveStudyGroup(StudyGroup studyGroup) => _workloadContext.StudyGroups.Local.Remove(studyGroup);

    [DbAddMethod(typeof(StudyGroup))]
    public void AddStudyGroup(StudyGroup studyGroup)
    {
        _workloadContext.StudyGroups.Local.Add(studyGroup);
        SaveChanges();
    }
}