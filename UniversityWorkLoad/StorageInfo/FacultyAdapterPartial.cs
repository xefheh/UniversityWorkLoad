using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(Faculty)), ComplexPart(typeof(Lecturer))]
    public BindingList<Faculty> GetFaculties() => _workloadContext.Faculties.Local.ToBindingList();

    [DbGetMethod(typeof(Faculty))]
    public Faculty GetFaculty(object identity) => _workloadContext.Faculties.Local.First(faculty => faculty.FacultyId == (int)identity);

    [DbRemoveMethod(typeof(Faculty))]
    public void RemoveFaculty(Faculty faculty)
    {
        _workloadContext.Faculties.Local.Remove(faculty);
    }

    [DbAddMethod(typeof(Faculty))]
    public void AddFaculty(Faculty faculty)
    {
        _workloadContext.Faculties.Add(faculty);
        SaveChanges();
    }
}   