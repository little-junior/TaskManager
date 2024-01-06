using DataLayer.DataAccess;
using DataLayer.Services;
using System.Reflection;

namespace UI
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
            ApplicationConfiguration.Initialize();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataRepository");
            Directory.CreateDirectory(path);

            var developerDataManagement = new DeveloperDataManagement();
            var techLeaderDataManagement = new TechLeaderDataManagement(); 
            var authenticationService = new AuthenticationService(developerDataManagement, techLeaderDataManagement);

            var loginForm = new LoginForm(authenticationService);
            
            Application.Run(loginForm);
        }
    }
}