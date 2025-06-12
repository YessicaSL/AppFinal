using AppFinal.Models;

namespace AppFinal.Views;

public partial class AgendarConversacionPage : ContentPage
{
    public AgendarConversacionPage()
    {
        InitializeComponent();
    }

    private void OnAgendarClicked(object sender, EventArgs e)
    {
        /*
        if (string.IsNullOrWhiteSpace(nombreEntry.Text) || string.IsNullOrWhiteSpace(apellidoEntry.Text))
        {
            confirmacionLabel.Text = "⚠️ Por favor ingresa nombre y apellido.";
            confirmacionLabel.TextColor = Colors.Red;
            return;
        }

        var alumno = new AlumnosModel
        {
            Nombre = nombreEntry.Text,
            Apellido = apellidoEntry.Text,
            FechaConversacion = fechaPicker.Date,
            HoraConversacion = horaPicker.Time
        };

        // Aquí podrías agregar el alumno a una lista si quieres persistencia
        confirmacionLabel.Text = $"✅ {alumno.Nombre} {alumno.Apellido}, tu conversación fue agendada para el {alumno.FechaConversacion:dd/MM/yyyy} a las {alumno.HoraConversacion:hh\\:mm}.";
        confirmacionLabel.TextColor = Color.FromArgb("#1F1F1F"); */
        if (nombreEntry == null)
            throw new NullReferenceException("nombreEntry es null");
        if (apellidoEntry == null)
            throw new NullReferenceException("apellidoEntry es null");
        if (fechaPicker == null)
            throw new NullReferenceException("fechaPicker es null");
        if (horaPicker == null)
            throw new NullReferenceException("horaPicker es null");
        if (confirmacionLabel == null)
            throw new NullReferenceException("confirmacionLabel es null");
    }
}