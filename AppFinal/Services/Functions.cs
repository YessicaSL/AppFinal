using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinal.Interfaces;

namespace AppFinal.Services
{
    public class Functions : IFunction
    {
        public string CambiarTexto(string text, int count)
        => $"{text} : {count}";
    }
}
