namespace AppFinal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Rutas de navegación
            Routing.RegisterRoute(nameof(ListadoAlumnos), typeof(ListadoAlumnos));
            Routing.RegisterRoute(nameof(Alumno), typeof(Alumno));
            Routing.RegisterRoute(nameof(InicioPage), typeof(InicioPage));
            //Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
        }
    }
}
