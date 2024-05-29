using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaServices.Models
{   //clase publica
    public class Cliente
    {   //atributos
        public int Dni { get; set; }
        public string ClienteName { get; set; }
        public string ClienteApellido { get; set; }
        public string ClienteLocalidad { get; set; }
        public TipoPlan TipoPlan { get; set; }
        public int ClienteEdad { get; set; }

        //constructor
        public Cliente(int dni, string clienteName, string clienteApellido, string clienteLocalidad, TipoPlan tipoPlan, int clienteEdad)
        {
            Dni = dni;
            ClienteName = clienteName;
            ClienteApellido = clienteApellido;
            ClienteLocalidad = clienteLocalidad;
            TipoPlan = tipoPlan;
            ClienteEdad = clienteEdad;
        }

        public override string ToString()
        {
            string description = ClienteName + " " + ClienteApellido + " " + "(" + ClienteEdad + ")";
            return description;
        }
    }
}
