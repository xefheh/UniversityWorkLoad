using System.ComponentModel;

namespace UniversityWorkLoad.Interfaces;

public interface IDgvController<T>
{
    void ShowForm();

    void ShowForm(object identity);

    BindingList<T> GetBindingRecords();

    void RemoveRecord(object identity);

    void InvokeSaving();

    T GetCardById(object identity);
}