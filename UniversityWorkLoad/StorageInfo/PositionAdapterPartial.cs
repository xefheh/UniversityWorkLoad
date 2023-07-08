using System.ComponentModel;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(Position)), ComplexPart(typeof(Lecturer))]
    public BindingList<Position> GetPositions() => _workloadContext.Positions.Local.ToBindingList();

    [DbGetMethod(typeof(Position))]
    public Position GetPosition(object identity) => _workloadContext.Positions.Local.First(position => position.PositionId == (int)identity);

    [DbRemoveMethod(typeof(Position))]
    public void RemovePosition(Position position) => _workloadContext.Positions.Local.Remove(position);

    [DbAddMethod(typeof(Position))]
    public void AddPosition(Position position)
    {
        _workloadContext.Positions.Local.Add(position);
        _workloadContext.SaveChanges();
    }

    [DbGetByFilter(typeof(Position))]
    public List<Position> GetPositionByFilter(string filter)
    {
        var filterCriteria = filter.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return _workloadContext.Positions.Local.Where(discipline => filterCriteria
            .All(criteria => GetStringProperties(discipline).
                Any(property => property.Contains(criteria.ToLower())))).ToList();
    }
}