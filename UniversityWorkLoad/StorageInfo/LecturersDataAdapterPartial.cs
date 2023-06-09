using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<Lecturer> GetLecturers() => _workloadContext.Lecturers.Local.ToBindingList();

    public Lecturer GetLecturer(object identity) => _workloadContext.Lecturers.Local.First(lecturer => lecturer.ReportCardId == (int)identity);

    public void RemoveWorkLoadLine(Lecturer lecturer) => _workloadContext.Lecturers.Local.Remove(lecturer);

    public void AddWorkLoadLine(Lecturer lecturer) => _workloadContext.Lecturers.Local.Add(lecturer);
}