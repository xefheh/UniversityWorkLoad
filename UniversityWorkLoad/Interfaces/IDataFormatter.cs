namespace UniversityWorkLoad.Interfaces;

public interface IDataFormatter<T>
{
    T Create(object[] parameters);

    void Update(T data, object[] parameters);
}