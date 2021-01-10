using CiudappReportes.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using CiudappReportes.ViewModels;
using CiudappReportes.Views.Admin;
using CiudappReportes.Views.Technical;
using CiudappReportes.Services;

namespace CiudappReportes
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var loginPage = serviceProvider.GetRequiredService<LogInPage>();
                var alp = serviceProvider.GetRequiredService<AdminLoginPage>();
                Application.Run(alp);
            }

           
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<LogInPage>()
                .AddScoped<AdminLoginPage>()
                .AddScoped<TechnicalLoginPage>()
                .AddScoped<IAlert,Alert>();
        }
    }
}
