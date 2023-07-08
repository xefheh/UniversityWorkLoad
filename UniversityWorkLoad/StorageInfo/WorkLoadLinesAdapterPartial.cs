using System.ComponentModel;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(WorkLoadLine))]
    public BindingList<WorkLoadLine> GetWorkLoadLines() => _workloadContext.WorkLoadLines.Local.ToBindingList();

    [DbGetMethod(typeof(WorkLoadLine))]
    public WorkLoadLine GetWorkLoadLine(object identity) => _workloadContext.WorkLoadLines.Local.First(workLoadLine => workLoadLine.LineId == (int)identity);

    [DbRemoveMethod(typeof(WorkLoadLine))]
    public void RemoveWorkLoadLine(WorkLoadLine workLoadLine) => _workloadContext.WorkLoadLines.Local.Remove(workLoadLine);

    [DbAddMethod(typeof(WorkLoadLine))]
    public void AddWorkLoadLine(WorkLoadLine workLoadLine)
    {
        _workloadContext.WorkLoadLines.Local.Add(workLoadLine);
        _workloadContext.SaveChanges();
    }

    [DbGetByFilter(typeof(WorkLoadLine))]
    public List<WorkLoadLine> GetWorkLoadLinesByFilter(string filter)
    {
        var filterCriteria = filter.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return _workloadContext.WorkLoadLines.Local.Where(discipline => filterCriteria
            .All(criteria => GetStringProperties(discipline).
                Any(property => property.Contains(criteria.ToLower())))).ToList();
    }
}