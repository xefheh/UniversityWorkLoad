using System.ComponentModel;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad.TableControllers
{
    internal class FacultyController
    {
        private readonly DataAdapter _adapter;

        public FacultyController(DataAdapter adapter) => _adapter = adapter;

        public void AddRecord(Faculty record) => _adapter.AddFaculty(record);

        public Faculty GetRecord(object identity) => _adapter.GetFaculty(identity);

        public BindingList<Faculty> GetRecords() => _adapter.GetFaculties();

        public void RemoveRecord(Faculty record) => _adapter.RemoveFaculty(record);

        public Faculty CreateRecord(object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
