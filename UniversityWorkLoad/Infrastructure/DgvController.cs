using System.ComponentModel;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.Infrastructure;

public class DgvController<T> : IDgvController<T>
{
    private static Type s_formType;

    static DgvController()
    {
        var itemType = typeof(T);
        var dbObjectsFormTypes = Assembly.GetExecutingAssembly().GetTypes().
            Where(t => t.GetCustomAttribute(typeof(DbObjectForm)) is not null);
        if (itemType == typeof(WorkCard) || itemType == typeof(WorkLoadLine)) return;
        var currentType  = dbObjectsFormTypes.Where(t =>
            t.CustomAttributes.First().ConstructorArguments[0].Value == itemType);
        s_formType = currentType.First();
    }

    private readonly IRepository<T> _repository;

    public DgvController(IRepository<T> repository) => _repository = repository;

    public void ShowForm()
    {
        var recordForm = Activator.CreateInstance(s_formType, s_formType.CustomAttributes.First().AttributeType == typeof(DbSimpleForm) ? 
            Array.Empty<object>() : new object[] { _repository.GetParts() });
        if (recordForm is null) throw new NullReferenceException();
        var castForm = (Form)recordForm;
        var castInterface = (IRecordForm)recordForm;
        if (castForm.ShowDialog() != DialogResult.OK) return;
        _repository.AddRecord(castInterface.GetParams());
    }

    public void ShowForm(object identity)
    {
        var record = _repository.GetRecord(identity);
        var recordForm = Activator.CreateInstance(s_formType, record);
        if (recordForm is null) throw new NullReferenceException();
        var castForm = (Form)recordForm;
        var castInterface = (IRecordForm)recordForm;
        if (castForm.ShowDialog() != DialogResult.OK) return;
        _repository.UpdateRecord(record, castInterface.GetParams());
    }

    public BindingList<T> GetBindingRecords() => _repository.GetRecords();

    public void RemoveRecord(object identity) => _repository.RemoveRecord(_repository.GetRecord(identity));
    public void InvokeSaving() => _repository.SaveDb();
}