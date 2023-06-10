using System.ComponentModel;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(Position))]
    public BindingList<Position> GetPositions() => _workloadContext.Positions.Local.ToBindingList();

    public Position GetPosition(object identity) => _workloadContext.Positions.Local.First(position => position.PositionId == (int)identity);

    [DbRemoveMethod(typeof(Position))]
    public void RemovePosition(Position position) => _workloadContext.Positions.Local.Remove(position);

    [DbAddMethod(typeof(Position))]
    public void AddPosition(Position position) => _workloadContext.Positions.Local.Add(position);
}