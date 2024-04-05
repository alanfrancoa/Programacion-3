using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoServices.Models
{
    public class Articulo
    {
        //Atributes
        public long id { get; private set; }
        public string description { get; set; }
        public decimal price { get; set; }

        public Articulo(long id, string description, decimal price)
        {
            this.id = id;
            this.description = description;
            this.price = price;
        }

        [Obsolete]
        private void foo() {
            Console.WriteLine("Hola");
        }
    }
}
