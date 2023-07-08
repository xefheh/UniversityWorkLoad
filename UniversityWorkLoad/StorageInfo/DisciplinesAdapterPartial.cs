using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(Discipline)), ComplexPart(typeof(WorkLoadLine))]
    public BindingList<Discipline> GetDisciplines() => _workloadContext.Disciplines.Local.ToBindingList();

    [DbGetMethod(typeof(Discipline))]
    public Discipline GetDiscipline(object identity) => _workloadContext.Disciplines.Local.First(discipline => discipline.DisciplineId == (int)identity);

    [DbRemoveMethod(typeof(Discipline))]
    public void RemoveDiscipline(Discipline discipline) => _workloadContext.Disciplines.Local.Remove(discipline);

    [DbAddMethod(typeof(Discipline))]
    public void AddDiscipline(Discipline discipline)
    {
        _workloadContext.Disciplines.Local.Add(discipline);
        _workloadContext.SaveChanges();
    }

    [DbGetByFilter(typeof(Discipline))]
    public List<Discipline> GetDisciplineByFilter(string filter)
    {
        var filterCriteria = filter.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return _workloadContext.Disciplines.Local.Where(discipline => filterCriteria
            .All(criteria => GetStringProperties(discipline).
                Any(property => property.Contains(criteria.ToLower())))).ToList();
    }
}