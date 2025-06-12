namespace AppFinal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ListadoAlumnos), typeof(ListadoAlumnos));
            Routing.RegisterRoute(nameof(Alumno), typeof(Alumno));
        }
    }
}
