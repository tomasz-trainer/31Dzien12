using Microsoft.Extensions.DependencyInjection;
using P03WeatherForecastWPF.Client.Services;
using P03WeatherForecastWPF.Client.ViewModels;
using P04WeatherForecastConsole.Client;
using System.Configuration;
using System.Data;
using System.Windows;

namespace P03WeatherForecastWPF.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        public App()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
           // services.AddSingleton<IMeteoService, OpenMeteoService>(); // rejestracja serwisu jako singleton
            services.AddSingleton<IMeteoService, FakeMeteoService>(); // rejestracja serwisu jako singleton


            services.AddSingleton<IMainViewModel, MainViewModel>(); // rejestracja MainViewModel jako singleton

            services.AddTransient<MainWindow>(); // tworzy instancję MainWindow przy każdym żądaniu

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
