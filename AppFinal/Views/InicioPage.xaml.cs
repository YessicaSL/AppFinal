using Microsoft.Maui.Controls;

namespace AppFinal.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    private async void Entrar_Clicked(object sender, EventArgs e)
    {
        // Navegar a MenuPage
        await Shell.Current.GoToAsync("MenuPage");
    }
}