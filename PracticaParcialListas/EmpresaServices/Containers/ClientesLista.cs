using EmpresaServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaServices.Containers
{
    public class ClientesLista
    {
        //atributos
        private readonly List<Cliente> clientes;
         
        //constructor
        public ClientesLista()
        {
            this.clientes = new List<Cliente>();
        }

        //metodos

        /// <summary>
        /// Buscar un cliente por su DNI
        /// </summary>
        /// <param name="numeroBuscado">Recibe un numero de tipo long</param>
        /// <returns>Devuelve un Pokemon o null</returns>
        public Cliente BuscarPorDni(long numeroBuscado) 
        {

            Cliente clienteEncontrado = null;

            foreach (Cliente cliente in this.clientes) 
            {
                if (cliente.Dni == numeroBuscado) 
                {
                    clienteEncontrado = cliente;
                    break;
                }
            }
            return clienteEncontrado;
        }

        /// <summary>
        /// Validar la existencia de un cliente por su numero de DNI
        /// </summary>
        /// <param name="numero">Recibe un numeero de tipo long</param>
        /// <returns>Retorna un booleano</returns>
        public bool ExistePorDNI(long numero) 
        { 
            bool existe = this.BuscarPorDni(numero) != null;
            return existe;
        }

        /// <summary>
        /// Agregar un cliente a la lista mediante validacion
        /// </summary>
        /// <param name="cliente">Recibe un objeto de tipo Cliente</param>
        /// <returns>Devuelve un valor booleano de mi resultado de la accion</returns>
        public bool agregarCliente(Cliente cliente) 
        {
            bool seAgrega = !this.ExistePorDNI((long)cliente.Dni);
            // Si existePorNumero devuelve TRUE, quiere decir que hay un cliente, al setear con el NOT (!) pasa a FALSE por ende no se agrega
            // Si existePorNumero devuelve FALSE, quiere decir que NO hay un cliente, al setear con el NOT (!) pasa a TRUE por ende se agrega

            if (seAgrega) //si se agrega da true, lo agregamos a nuestra lista.
            {
                this.clientes.Add(cliente);
            }

            return seAgrega;
        }
        /// <summary>
        /// Listar lista de clientes
        /// </summary>
        /// <returns>Devuelve una copia de la lista de clientes</returns>

        public List<Cliente> GetClientes() 
        {
            List<Cliente> listaCopia = new List<Cliente>(this.clientes);
            //Creamos una copia de la lista, para evitar inconvenientes

            return listaCopia;
            //retornamos esa copia.
        }


        /// <summary>
        /// Muestra cliente mas joven
        /// </summary>
        /// <returns>Devuelve el cliente de Cliente, mas joven.</returns>
        public Cliente MasJoven() 
        {
            Cliente clienteMasJoven = null;

            foreach (Cliente cliente in this.clientes)
            {
                if (clienteMasJoven == null || cliente.ClienteEdad < clienteMasJoven.ClienteEdad)
                {
                    clienteMasJoven = cliente;
                }
            } //si es la primera vez que pasa, o la edad del cliente es menor que la del cliente mas joven, este toma su lugar.
            return clienteMasJoven;
        }

        /// <summary>
        /// Muestra cliente mas viejo
        /// </summary>
        /// <returns>Devuelve el cliente de Cliente, mas viejo.</returns>
        public Cliente MasViejo()
        {
            Cliente clienteMasViejo = null;

            foreach (Cliente cliente in this.clientes)
            {
                if (clienteMasViejo == null || cliente.ClienteEdad > clienteMasViejo.ClienteEdad)
                {
                    clienteMasViejo = cliente;
                }
            } //si es la primera vez que pasa, o la edad del cliente es mayor que la del cliente mas viejo, este toma su lugar.
            return clienteMasViejo;
        }

        /// <summary>
        /// Calcular clientes por ciudad
        /// </summary>
        /// <param name="ciudad">Recibe un string para la ciudad</param>
        /// <returns>Devuelve la cantidad de clientes de esa ciudad</returns>
        public long clientesPorCiudad(string ciudad)
        {
            long cantidadClientes = 0;

            foreach (Cliente cliente in this.clientes)
            {
                if (cliente.ClienteLocalidad.ToUpper() == ciudad.ToUpper())
                {
                    cantidadClientes++;
                }
            } //Si el cliente es de la ciudad, le suma uno a la cantidadClientes.
            return cantidadClientes;
        }

        /// <summary>
        /// Calcular promedio de edad de clientes
        /// </summary>
        /// <returns>Devuelve el promedio</returns>
        public double PromedioEdad() 
        {
            long acumulador = 0;

            foreach (Cliente cliente in clientes)
            {
                acumulador += cliente.ClienteEdad;
            }

            if (this.clientes.Count > 0) 
            {   
                double promedio = acumulador / clientes.Count;
                return (promedio);
            } else 
            {
                return 0;
            }
                        
        }

        /// <summary>
        /// Calcular cliente por plan
        /// </summary>
        /// <params name="tipoCliente"> </params>
        /// <returns>Devuelve el promedio</returns>
        public long ClientePorPlan(string tipoCliente) 
        {   long cantidad = 0;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.TipoPlan.ToString().ToUpper() == tipoCliente.ToUpper()) 
                { 
                    cantidad++;
                }
            }
            return cantidad;
        }

    }
}

