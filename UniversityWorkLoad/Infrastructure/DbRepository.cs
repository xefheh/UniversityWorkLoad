using System.ComponentModel;
using System.Reflection;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.Infrastructure;

public class DbRepository<T> : IRepository<T>
{
    private static MethodInfo s_addMethodInfo;
    private static MethodInfo s_removeMethodInfo;
    private static MethodInfo s_getAllMethodInfo;
    private static MethodInfo s_getMethodInfo;
    private static Type s_dataFormatterType;

    static DbRepository()
    {
        var itemType = typeof(T);
        var adapterType = typeof(DataAdapter);
        var ttypes = Assembly.GetExecutingAssembly().GetTypes().
            Where(t => t.GetCustomAttribute(typeof(DataFormatter)) is not null);
        s_dataFormatterType = ttypes.First(t => t.CustomAttributes.ToArray()[2].ConstructorArguments[0].Value == itemType);
        var dbMethods = adapterType.GetMethods().Where(method =>
             method.GetCustomAttribute(typeof(DbMethod)) is not null);
        dbMethods = dbMethods.Where(method =>
            (((DbMethod)method.GetCustomAttribute(typeof(DbMethod))!)!).Type == itemType);
         foreach (var method in dbMethods)
         {
             switch (method.GetCustomAttribute(typeof(DbMethod)))
             {
                 case DbAddMethod: s_addMethodInfo = method; break;
                 case DbRemoveMethod: s_removeMethodInfo = method; break;
                 case DbGetAllMethod: s_getAllMethodInfo = method; break;
                 case DbGetMethod: s_getMethodInfo = method; break;
             }
         }
    }

    private readonly DataAdapter _dataAdapter;
    private readonly IDataFormatter<T> _dataFormatter;

    public DbRepository(DataAdapter dataAdapter)
    {
        _dataAdapter = dataAdapter;
        _dataFormatter = (IDataFormatter<T>)Activator.CreateInstance(s_dataFormatterType, Array.Empty<object>());
    }

    [RepositoryAddMethod]
    public void AddRecord(object[] parameters) => s_addMethodInfo.Invoke(_dataAdapter,
        new object[] { _dataFormatter.Create(parameters) });

    [RepositoryGetAllMethod]
    public BindingList<T> GetRecords() => (BindingList<T>)s_getAllMethodInfo.Invoke(_dataAdapter, Array.Empty<object>());

    [RepositoryRemoveMethod]
    public void RemoveRecord(T record) => s_removeMethodInfo.Invoke(_dataAdapter, new object[] { record });

    public void UpdateRecord(T record, object[] attributes) { _dataFormatter.Update(record, attributes);}

    public T GetRecord(object identity) => (T)s_getMethodInfo.Invoke(_dataAdapter, new[] { identity });
    public void SaveDb() => _dataAdapter.SaveChanges();
}