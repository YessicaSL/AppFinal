using AppFinal;
using AppFinal.ViewModels;

namespace AppFinal.Views;

public partial class Alumno : ContentPage
{
	public Alumno()
	{
		BindingContext = App.Services.GetRequiredService<AlumnoViewModel>();
		InitializeComponent();
	}
}