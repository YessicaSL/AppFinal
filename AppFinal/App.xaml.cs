using Microsoft.Extensions.DependencyInjection;
using System.Runtime.Versioning; // Asegúrate de incluir este espacio de nombres
using AppFinal.ViewModels;
using AppFinal.Views;
using AppFinal.Services;

namespace AppFinal
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        [SupportedOSPlatform("android21.0")]
        public new static App? Current => Application.Current as App;

        public App()
        {
            var services = new ServiceCollection();
            Services = ConfigureServices(services);

            InitializeComponent();
            MainPage = new NavigationPage(new MenuPage());
        }

        private static IServiceProvider ConfigureServices(ServiceCollection services)
        {
            // Services
            services.AddSingleton<IFunction, Functions>();

            // ViewModels
            services.AddTransient<AlumnosModel>();
            services.AddTransient<AlumnosViewModels>();

            // Views
            services.AddSingleton<ListadoAlumnos>();

            return services.BuildServiceProvider();
        }
    }
}
