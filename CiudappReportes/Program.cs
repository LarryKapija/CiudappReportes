using CiudappReportes.Constants;
using CiudappReportes.Models;
using CiudappReportes.Services;
using CiudappReportes.Services.Classes;
using CiudappReportes.Services.Interfaces;
using CiudappReportes.Views;
using CiudappReportes.Views.Admin;
using CiudappReportes.Views.Technical;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
namespace CiudappReportes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var loginPage = serviceProvider.GetRequiredService<MainPage>();
                Application.Run(loginPage);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IAlert, Alert>()
                .AddScoped<IEncrypt, Encrypt>()
                .AddScoped<IAutentication, Autentication>()

            #region views
                .AddSingleton<MainPage>()
                .AddScoped<AdminLoginPage>()
                .AddScoped<AdminProfilePage>()
                .AddScoped<TechnicalLoginPage>()
                .AddScoped<TechnicalProfilePage>()
            #endregion

                .AddSingleton<Session>();

        }
    }
}
