namespace UniversityWorkLoad.Infrastructure;

public class DataGridViewController<TEntity> : IDataGridViewController<TEntity> where TEntity : class
{
    private readonly WorkloadContext _workloadContext;

    public DataGridViewController(WorkloadContext workloadContext)
    {
        _workloadContext = workloadContext;
    }

    public void LoadData(DataGridView dataGridView)
    {
        var bindingList = _workloadContext.Set<TEntity>().Local.ToBindingList();
        dataGridView.DataSource = bindingList;
    }

    public void SaveData()
    {
        _workloadContext.SaveChanges();
    }
}

public interface IDataGridViewController<TEntity> where TEntity : class
{
    void LoadData(DataGridView dataGridView);
    void SaveData();
}