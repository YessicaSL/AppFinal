using AppFinal;
using AppFinal.ViewModels;

namespace AppFinal.Views;

public partial class ListadoAlumnos : ContentPage
{
	public ListadoAlumnos()
	{
        InitializeComponent();
        BindingContext = App.Services.GetRequiredService < AlumnosViewModels>();
		
	}
}