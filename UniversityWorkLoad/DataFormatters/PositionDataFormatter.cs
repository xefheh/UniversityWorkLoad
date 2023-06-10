using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Position))]
public class PositionDataFormatter : IDataFormatter<Position>
{
    public Position Create(object[] parameters)
    {
        throw new NotImplementedException();
    }

    public void Update(Position data, object[] parameters)
    {
        throw new NotImplementedException();
    }
}