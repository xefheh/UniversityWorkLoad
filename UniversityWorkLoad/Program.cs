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
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(adapter));
        }
    }
}