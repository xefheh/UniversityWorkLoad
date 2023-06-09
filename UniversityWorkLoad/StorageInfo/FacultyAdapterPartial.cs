using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<Faculty> GetFaculties() => _workloadContext.Faculties.Local.ToBindingList();

    public Faculty GetFaculty(object identity) => _workloadContext.Faculties.Local.First(faculty => faculty.FacultyId == (int)identity);

    public void RemoveFaculty(Faculty faculty) => _workloadContext.Faculties.Local.Remove(faculty);

    public void AddFaculty(Faculty faculty) => _workloadContext.Faculties.Local.Add(faculty);
}