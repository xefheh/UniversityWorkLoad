using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<Position> GetPositions() => _workloadContext.Positions.Local.ToBindingList();

    public Position GetPosition(object identity) => _workloadContext.Positions.Local.First(position => position.PositionId == (int)identity);

    public void RemovePosition(Position position) => _workloadContext.Positions.Local.Remove(position);

    public void AddPosition(Position position) => _workloadContext.Positions.Local.Add(position);
}