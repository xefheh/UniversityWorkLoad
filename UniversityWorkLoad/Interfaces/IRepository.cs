using System.ComponentModel;
using UniversityWorkLoad.Attributes;

namespace UniversityWorkLoad.Interfaces;

public interface IRepository<T>
{
    [RepositoryAddMethod]
    void AddRecord(object[] parameters);

    [RepositoryGetAllMethod]
    BindingList<T> GetRecords();

    [RepositoryRemoveMethod]
    void RemoveRecord(T record);

    void UpdateRecord(T record, object[] attributes);

    [RepositoryGetMethod]
    T GetRecord(object identity);

    void SaveDb();
}