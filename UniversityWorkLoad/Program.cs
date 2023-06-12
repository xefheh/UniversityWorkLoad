using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using UniversityWorkLoad.DatabaseEntities;
using UniversityWorkLoad.Infrastructure;
using UniversityWorkLoad.MainFormSettings;
using UniversityWorkLoad.StorageInfo;

namespace UniversityWorkLoad
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var assemblyTypes = Assembly.GetExecutingAssembly().GetTypes().
                Where(type => type.Namespace == "UniversityWorkLoad.DatabaseEntities");
            const string connectionString = "Host=localhost;Port=5432;Database=WO24rkloads;Username=postgres;Password=1234";
            using var workloadContext = new WorkloadContext(connectionString);
            var adapter = new DataAdapter(workloadContext);
            var dgvControllers = new Dictionary<Type, dynamic>();
            foreach (var type in assemblyTypes)
            {
                var repositoryType = typeof(DbRepository<>).MakeGenericType(type);
                var controllerType = typeof(DgvController<>).MakeGenericType(type);
                dgvControllers.Add(type, Activator.CreateInstance(controllerType, 
                    Activator.CreateInstance(repositoryType, adapter)) ?? throw new NullReferenceException());
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(dgvControllers));
        }
    }
}