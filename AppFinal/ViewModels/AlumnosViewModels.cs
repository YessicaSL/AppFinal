using AppFinal.ViewModels;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace AppFinal.ViewModels;

public partial class AlumnosViewModels : ObservableObject
{
    public ObservableCollection<AlumnosModel> Alumnos { get; set; } = new();



    [RelayCommand]
    public async Task ListarAlumnos()
    {
        Alumnos.Clear();
        Alumnos.Add(new AlumnosModel() {Apellido = "Test", Nombre = "Fualno"});
        Alumnos.Add(new AlumnosModel() { Apellido = "Test", Nombre = "Perengano" });
        Alumnos.Add(new AlumnosModel() { Apellido = "Test", Nombre = "Sutana" });
        Alumnos.Add(new AlumnosModel() { Apellido = "Test", Nombre = "Mengana" });

    }
}
