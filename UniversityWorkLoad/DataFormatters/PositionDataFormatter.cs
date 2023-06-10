using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Position))]
public class PositionDataFormatter : IDataFormatter<Position>
{
    public Position Create(object[] parameters) => new()
    {
        PositionName = (string)parameters[0],
        UpLimit = (int)parameters[1],
        LowerLimit = (int)parameters[2]
    };

    public void Update(Position data, object[] parameters)
    {
        data.PositionName = (string)parameters[0];
        data.UpLimit = (int)parameters[1];
        data.LowerLimit = (int)parameters[2];
    }
}