using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.Input;

namespace AppFinal.ViewModels;

public partial class AlumnoViewModel : ObservableValidator
{

    private string apellido = string.Empty;

    [Required(ErrorMessage = "El campo de nombre es obligatorio")]
    [MaxLength(30)]
    public string Text_Apellido
    {
        get => apellido;
        set => SetProperty(ref apellido, value, true);
    }

    private string nombre = string.Empty;

    [Required(ErrorMessage ="El campo de nombre es obligatorio")]
    [MaxLength(30)]
    public string Text_Nombre
    {
        get { return nombre; }
        set => SetProperty(ref nombre, value, true);
    }

    [RelayCommand]
    public void GuardarAlumno()
    {
        ValidateAllProperties();
        var erro_nombre= GetErrors(nameof(Text_Nombre)).ToList();
        var erro_apellido = GetErrors(nameof(Text_Apellido)).ToList();
    }
}
