using System;
using Microsoft.Maui.Controls;

namespace AppFinal.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        
        private async void OnRegistrarAlumnoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Alumno));
        }
      
        private async void OnAgendarConversacionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgendarConversacionPage());
        }
    }
}