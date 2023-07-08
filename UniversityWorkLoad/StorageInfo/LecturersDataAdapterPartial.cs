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
        _workloadContext.SaveChanges();
    }

    [DbGetByFilter(typeof(Lecturer))]
    public List<Lecturer> GetLecturerByFilter(string filter)
    {
        var filterCriteria = filter.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return _workloadContext.Lecturers.Local.Where(discipline => filterCriteria
            .All(criteria => GetStringProperties(discipline).
                Any(property => property.Contains(criteria.ToLower())))).ToList();
    }
}