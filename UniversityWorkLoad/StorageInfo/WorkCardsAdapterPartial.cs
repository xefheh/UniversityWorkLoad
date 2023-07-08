using System.ComponentModel;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    [DbGetAllMethod(typeof(WorkCard)), ComplexPart(typeof(WorkLoadLine))]
    public BindingList<WorkCard> GetWorkCard() => _workloadContext.WorkCards.Local.ToBindingList();

    [DbGetMethod(typeof(WorkCard))]
    public WorkCard GetWorkCard(object identity) => _workloadContext.WorkCards.Local.First(workCard => workCard.CardId == (int)identity);

    [DbRemoveMethod(typeof(WorkCard))]
    public void RemoveWorkCard(WorkCard workCard) => _workloadContext.WorkCards.Local.Remove(workCard);

    [DbAddMethod(typeof(WorkCard))]
    public void AddWorkCard(WorkCard workCard)
    {
        _workloadContext.WorkCards.Local.Add(workCard);
        _workloadContext.SaveChanges();
    }

    [DbGetByFilter(typeof(WorkCard))]
    public List<WorkCard> GetWorkCardsByFilter(string filter)
    {
        var filterCriteria = filter.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return _workloadContext.WorkCards.Local.Where(discipline => filterCriteria
            .All(criteria => GetStringProperties(discipline).
                Any(property => property.Contains(criteria.ToLower())))).ToList();
    }
}