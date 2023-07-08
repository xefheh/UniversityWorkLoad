using System.Reflection;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.Infrastructure;

namespace UniversityWorkLoad.StorageInfo;

public partial class DataAdapter
{
    private readonly WorkloadContext _workloadContext;
    private readonly IEnumerable<Tuple<object?, MethodInfo>> _loadMethods;

    public DataAdapter(WorkloadContext context)
    {
        _workloadContext = context;
        _loadMethods = InitializeLoadMethods(GetContextTypes());
        LoadLocaleData();
    }

    public void SaveChanges() => _workloadContext.SaveChanges();

    private static IEnumerable<Type> GetContextTypes()
    {
        return typeof(WorkloadContext)
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(property => property.GetCustomAttribute(typeof(ReflexionDbEntities)) is not null)
            .Select(property => property.PropertyType.GenericTypeArguments[0]);
    }

    private IEnumerable<Tuple<object?, MethodInfo>> InitializeLoadMethods(IEnumerable<Type> contextTypes)
    {
        var setMethod = typeof(DbContext).GetMethod("Set", Array.Empty<Type>());
        foreach (var type in contextTypes)
        {
            var setResult = setMethod?.MakeGenericMethod(type).Invoke(_workloadContext, Array.Empty<object>());
            var methodInfo = typeof(EntityFrameworkQueryableExtensions).GetMethod("Load")?
                .MakeGenericMethod(type);
            if(methodInfo is null) yield break;
            yield return Tuple.Create(setResult, methodInfo);
        }
    }

    private void LoadLocaleData()
    {
        foreach (var method in _loadMethods)
            method.Item2.Invoke(null, new[] { method.Item1 });
    }
    public string[] GetStringProperties(object obj)
    {
        var properties = obj.GetType()
            .GetProperties(BindingFlags.Public | BindingFlags.Instance)
            .Where(property => property.CustomAttributes.Any(attribute => attribute.AttributeType == typeof(FilterCriteria)))
            .Select(property => property.GetValue(obj).ToString().ToLower());
        return properties.ToArray();
    }
}