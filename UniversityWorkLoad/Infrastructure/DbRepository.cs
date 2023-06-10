using System.ComponentModel;
using System.Reflection;
using UniversityWorkLoad.Attributes;
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
    private static Dictionary<Type, MethodInfo> s_complexMethods;

    static DbRepository()
    {
        var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
        s_complexMethods = new Dictionary<Type, MethodInfo>();
        var itemType = typeof(T);
        var adapterType = typeof(DataAdapter);
        InitializeFormatter(assemblyTypes, itemType);
        InitializeMethods(adapterType, itemType);
        InitializeComplexMethods(adapterType, itemType);
    }

    private static void InitializeComplexMethods(Type adapterType, Type itemType)
    {
        var methods = adapterType.GetMethods();
        var complexMethods = methods.Where(method => method.GetCustomAttribute(typeof(ComplexPart)) is not null);
        var currentMethods = complexMethods.Where(method =>
            method.CustomAttributes.ToArray()[1].ConstructorArguments[0].Value == itemType);
        foreach (var method in currentMethods)
        {
            var returnType = method.ReturnType;
            var returnGeneric = returnType.GenericTypeArguments[0];
            s_complexMethods.Add(returnGeneric, method);
        }
    }

    private static void InitializeFormatter(Type[] assemblyTypes, Type itemType)
    {
        var ttypes = assemblyTypes.Where(t => t.GetCustomAttribute(typeof(DataFormatter)) is not null);
        s_dataFormatterType = ttypes.First(t => t.CustomAttributes.ToArray()[2].ConstructorArguments[0].Value == itemType);
    }

    private static void InitializeMethods(Type adapterType, Type itemType)
    {
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

    public void AddRecord(object[] parameters) => s_addMethodInfo.Invoke(_dataAdapter,
        new object[] { _dataFormatter.Create(parameters) });

    public BindingList<T> GetRecords() => (BindingList<T>)s_getAllMethodInfo.Invoke(_dataAdapter, Array.Empty<object>());

    public void RemoveRecord(T record) => s_removeMethodInfo.Invoke(_dataAdapter, new object[] { record });

    public void UpdateRecord(T record, object[] attributes) { _dataFormatter.Update(record, attributes); }

    public T GetRecord(object identity) => (T)s_getMethodInfo.Invoke(_dataAdapter, new[] { identity });
    public void SaveDb() => _dataAdapter.SaveChanges();

    public Dictionary<Type, dynamic> GetParts()
    {
        var parts = new Dictionary<Type, dynamic>();
        foreach (var pair in s_complexMethods)
            parts.Add(pair.Key, pair.Value.Invoke(_dataAdapter, Array.Empty<object>()));
        return parts;
    }
}