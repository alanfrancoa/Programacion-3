using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09
{
    public class Usuario
    {
        public long Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Usuario(long id, string username, string password)
        {
            Id = id;
            this.username = username;
            this.password = password;
        }

        public Usuario() { }
    }
}
