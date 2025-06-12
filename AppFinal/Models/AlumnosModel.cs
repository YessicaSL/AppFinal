using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.Models;

public class AlumnosModel
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime FechaConversacion { get; set; }
    public TimeSpan HoraConversacion { get; set; }

    public override string ToString() =>
        $"{Nombre} {Apellido} - {FechaConversacion:dd/MM/yyyy} a las {HoraConversacion:hh\\:mm}";
}