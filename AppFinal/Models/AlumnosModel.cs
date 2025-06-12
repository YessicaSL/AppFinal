using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.Models;

public class AlumnosModel
{
    public override string ToString() =>
        $"{Nombre} {Apellido}";
    public string Nombre { get; set; }
    public string Apellido { get; set; }
}
