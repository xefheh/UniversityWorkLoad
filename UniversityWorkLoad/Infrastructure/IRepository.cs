using System.ComponentModel;

namespace UniversityWorkLoad.Infrastructure;

public interface IRepository<T>
{
    BindingList<T> GetRecords();
    void Add(T record);
    void Remove(T record);
    void Update(T record, object[] parameters);
}