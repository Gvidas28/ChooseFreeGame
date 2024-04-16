using ChooseFreeGame.Logic.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace ChooseFreeGame.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            RegisterServices(services);
            var serviceProvider = services.BuildServiceProvider();
            var mainPage = serviceProvider.GetRequiredService<MainPage>();
            Application.Run(mainPage);
        }

        private static void RegisterServices(ServiceCollection services)
        {
            services.AddScoped<MainPage>();
            services.AddScoped<GameDetailsPage>();
            services.AddScoped<SavedGamesPage>();
            services.AddScoped<IHelperService, HelperService>();
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IGameService, GameService>();
        }
    }
}