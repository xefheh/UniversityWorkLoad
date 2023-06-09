using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    public BindingList<WorkCard> GetWorkCard() => _workloadContext.WorkCards.Local.ToBindingList();

    public WorkCard GetWorkCard(object identity) => _workloadContext.WorkCards.Local.First(workCard => workCard.CardId == (int)identity);

    public void RemoveWorkCard(WorkCard workCard) => _workloadContext.WorkCards.Local.Remove(workCard);

    public void AddWorkCard(WorkCard workCard) => _workloadContext.WorkCards.Local.Add(workCard);
}