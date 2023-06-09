using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<StudyGroup> GetStudyGroups() => _workloadContext.StudyGroups.Local.ToBindingList();

    public StudyGroup GetStudyGroup(object identity) => _workloadContext.StudyGroups.Local.First(studyGroup => studyGroup.GroupId == (int)identity);

    public void RemoveStudyGroup(StudyGroup studyGroup) => _workloadContext.StudyGroups.Local.Remove(studyGroup);

    public void AddStudyGroup(StudyGroup studyGroup) => _workloadContext.StudyGroups.Local.Add(studyGroup);
}