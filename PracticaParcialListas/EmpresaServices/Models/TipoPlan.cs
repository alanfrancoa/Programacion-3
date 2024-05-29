using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaServices.Models
{   //Clase Publica
    public class TipoPlan
    {   //Atributos
        public string Tipo { get; } //Obtener pero no modificar

        //Constructor
        public TipoPlan(string tipo)
        {
            Tipo = tipo;
        }

        //Metodo
        public override string ToString() //Override porque estamos sobreescribiendo el ToString()

        {
            return Tipo.ToString();
        }

    }
}
