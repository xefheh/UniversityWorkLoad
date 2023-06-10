using UniversityWorkLoad.Attributes;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Interfaces;

namespace UniversityWorkLoad.DataFormatters;

[DataFormatter(typeof(Lecturer))]
public class LecturerDataFormatter : IDataFormatter<Lecturer>
{
    public Lecturer Create(object[] parameters) => new()
    {
        Surname = (string)parameters[0],
        Name = (string)parameters[1],
        MiddleName = (string)parameters[2],
        Position = (Position)parameters[3],
        Faculty = (Faculty)parameters[4],
        Photo = (byte[])parameters[5]
    };

    public void Update(Lecturer data, object[] parameters)
    {
        data.Surname = (string)parameters[0];
        data.Name = (string)parameters[1];
        data.MiddleName = (string)parameters[2];
        data.Position = (Position)parameters[3];
        data.Faculty = (Faculty)parameters[4];
        data.Photo = (byte[])parameters[5];
    }
}