using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Operacion
    {
        public int a { get; set; }
        public int b { get; set; }
        public char tipo { get; set; }
        public int resultado { get; set; }

        public Operacion(int a, int b, char tipo, int resultado)
        {
            this.a = a;
            this.b = b;
            this.tipo = tipo;
            this.resultado = resultado;
        }
    }
}
