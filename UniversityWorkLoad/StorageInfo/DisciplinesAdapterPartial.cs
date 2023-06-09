using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;
namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<Discipline> GetDisciplines() => _workloadContext.Disciplines.Local.ToBindingList();

    public Discipline GetDiscipline(object identity) => _workloadContext.Disciplines.Local.First(discipline => discipline.DisciplineId == (int)identity);

    public void RemoveDiscipline(Discipline discipline) => _workloadContext.Disciplines.Local.Remove(discipline);

    public void AddDiscipline(Discipline discipline) => _workloadContext.Disciplines.Local.Add(discipline);
}