using Microsoft.Extensions.DependencyInjection;
using AppFinal.ViewModels;
using AppFinal.Views;
using AppFinal.Services;

namespace AppFinal
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        public new static App Current => (App)Application.Current;

        public App()
        {
            var services = new ServiceCollection();
            Services = ConfigureServices(services);

            InitializeComponent();
            MainPage = new AppShell();
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
