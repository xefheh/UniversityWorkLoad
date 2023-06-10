using System.ComponentModel;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(Lecturer)), ComplexPart(typeof(WorkCard))]
    public BindingList<Lecturer> GetLecturers() => _workloadContext.Lecturers.Local.ToBindingList();

    [DbGetMethod(typeof(Lecturer))]
    public Lecturer GetLecturer(object identity) => _workloadContext.Lecturers.Local.First(lecturer => lecturer.ReportCardId == (int)identity);

    [DbRemoveMethod(typeof(Lecturer))]
    public void RemoveLecturer(Lecturer lecturer) => _workloadContext.Lecturers.Local.Remove(lecturer);

    [DbAddMethod(typeof(Lecturer))]
    public void AddLecturer(Lecturer lecturer)
    {
        _workloadContext.Lecturers.Local.Add(lecturer);
        SaveChanges();
    }
}