using DataLayer.DataAccess;
using DataLayer.Services;

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

            var developerDataManagement = new DeveloperDataManagement(); // Substitua pelo seu gerenciamento de dados real
            var techLeaderDataManagement = new TechLeaderDataManagement(); // Substitua pelo seu gerenciamento de dados real
            var authenticationService = new AuthenticationService(developerDataManagement, techLeaderDataManagement);
            var loginForm = new LoginForm(authenticationService);


            Application.Run(loginForm);
        }
    }
}