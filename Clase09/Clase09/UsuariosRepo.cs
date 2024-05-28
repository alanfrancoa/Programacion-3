using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09
{
    public class UsuariosRepo
    {
        public List<Usuario> getAll() 
        {
            string conectionString = "Server=PCGAMINGALAN\\SQLEXPRESS; Database=clase09; Integrated Security=True";

            SqlConnection connection = new SqlConnection(conectionString); //levantamos connectionString

            connection.Open(); //abrimos connection

            var comando = connection.CreateCommand(); //conectamos el comando 

            comando.CommandText = "SELECT ID, NOMBRE, CLAVE FROM USUARIOS;"; //creamos query

            SqlDataReader reader = comando.ExecuteReader(); //ejecutamos el comando

            List<Usuario> listado = new List<Usuario>(); //creamos lista de usuarios

            while (reader.Read()) //mientras reader sea true.
            {
                Usuario usuario = new Usuario(); //crea un nuevo usuario
                usuario.Id = reader.GetInt32(0); //le agrega el id, en base al row 0
                usuario.username = reader.GetString(1); //le agrega el username, en base al row 1
                usuario.password = reader.GetString(2); //le agrega el password, en base al row 2

                listado.Add(usuario); //se agrega el usuario a la lista

            }

            connection.Close();

            return listado; //retornamos el listado de usuarios.
        }
    }
}
