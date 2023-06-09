using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<WorkLoadLine> GetWorkLoadLines() => _workloadContext.WorkLoadLines.Local.ToBindingList();

    public WorkLoadLine GetWorkLoadLine(object identity) => _workloadContext.WorkLoadLines.Local.First(workLoadLine => workLoadLine.LineId == (int)identity);

    public void RemoveWorkLoadLine(WorkLoadLine workLoadLine) => _workloadContext.WorkLoadLines.Local.Remove(workLoadLine);

    public void AddWorkLoadLine(WorkLoadLine workLoadLine) => _workloadContext.WorkLoadLines.Local.Add(workLoadLine);
}