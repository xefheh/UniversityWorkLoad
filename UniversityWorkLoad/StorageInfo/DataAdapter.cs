using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Infrastructure;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    private readonly WorkloadContext _workloadContext;

    public DataAdapter(WorkloadContext context)
    {
        _workloadContext = context;
        LoadLocaleData();
    }

    private void LoadLocaleData()
    {
        _workloadContext.Faculties.Load();
        _workloadContext.Disciplines.Load();
        _workloadContext.Lecturers.Load();
        _workloadContext.Positions.Load();
        _workloadContext.StudyGroups.Load();
        _workloadContext.WorkCards.Load();
        _workloadContext.WorkLoadLines.Load();
    }
}