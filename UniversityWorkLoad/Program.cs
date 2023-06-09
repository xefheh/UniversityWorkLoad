using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            const string connectionString = "Data Source=inspection.db";
            using var workloadContext = new WorkloadContext(connectionString);
            var adapter = new DataAdapter(workloadContext);
            var tableControllers = new Dictionary<Type, dynamic>();
            var entityTypes = Assembly.GetExecutingAssembly().GetTypes().Where(type => type.Namespace == "UniversityWorkLoad.DatabaseEntities");
            foreach (var entityType in entityTypes)
            {
                var controllerType = typeof(DataGridViewController<>).MakeGenericType(entityType);
                var controllerInstance = Activator.CreateInstance(controllerType, workloadContext);
                tableControllers.Add(controllerType, controllerInstance);
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(tableControllers));
        }
    }
}