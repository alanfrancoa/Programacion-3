using CarritoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Services
{
    public class Carrito
    {
        private readonly List<Articulo> list;//creamos

        //constructor
        public Carrito()
        {
            this.list = new List<Articulo>(); //instanciamos
        }

        public decimal getTotal() 
        {
            decimal total = 0;
            foreach (Articulo art in this.list) 
            {
                total += art.price;
            }
            return total;
        }

        public void add(Articulo articulo)
        {
            this.list.Add(articulo);
        }
    }
}
