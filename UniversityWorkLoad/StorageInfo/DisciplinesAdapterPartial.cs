using System.ComponentModel;
using System.Diagnostics;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(Discipline))]
    public BindingList<Discipline> GetDisciplines() => _workloadContext.Disciplines.Local.ToBindingList();

    [DbGetMethod(typeof(Discipline))]
    public Discipline GetDiscipline(object identity) => _workloadContext.Disciplines.Local.First(discipline => discipline.DisciplineId == (int)identity);

    [DbRemoveMethod(typeof(Discipline))]
    public void RemoveDiscipline(Discipline discipline) => _workloadContext.Disciplines.Local.Remove(discipline);

    [DbAddMethod(typeof(Discipline))]
    public void AddDiscipline(Discipline discipline)
    {
        _workloadContext.Disciplines.Local.Add(discipline);
        SaveChanges();
    }
}