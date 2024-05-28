using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09
{
    class Program
    {
        static void Main(string[] args)
        {
            string conectionString = "Server=PCGAMINGALAN\\SQLEXPRESS; Database=clase09; Integrated Security=True";

            SqlConnection connection = new SqlConnection(conectionString); //levantamos connectionString

            connection.Open(); //abrimos connection

            var comando = connection.CreateCommand(); //conectamos el comando 

            comando.CommandText = "INSERT INTO USUARIOS (NOMBRE, CLAVE)" +
                "VALUES ('userconsole', '1234');"; //creamos query

            try
            {
                comando.ExecuteNonQuery(); //Ejecutamos el comando, non query no levanta resultados.
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine(sqlEx.Message);
            }

            //Traer info de la base de datos

            SqlCommand comandoLeer = connection.CreateCommand(); //creamos nuevo comando

            comandoLeer.CommandText = "SELECT ID, NOMBRE FROM USUARIOS ORDER BY ID"; //agregamos query

            //Ya que el comando a ejecutar nos debe traer informacion, debemos almacenarla en un cursor para poder recorrerla.

            SqlDataReader cursor = comandoLeer.ExecuteReader(); // el cursor nos trae la informacion.

            cursor.Read();//Movernos a la siguiente linea, a pararnos en el primer registro, en este caso.

            Usuario usuario1 = new Usuario(); //creamos un objeto

            usuario1.Id = cursor.GetInt32(0); //guardamos el id, del row 0
            usuario1.username = cursor.GetString(1); //guardamos el username del row 1

            Console.WriteLine(usuario1.Id); // mostramos la info
            Console.WriteLine(usuario1.username);

            UsuariosRepo repo = new UsuariosRepo();
            List<Usuario> lista = repo.getAll(); // Utilizamos funcion getAll de usuariosRepo, esta nos retorna un objeto que es la lista de usuarios.

            foreach (Usuario usuario in lista)
            {
                Console.WriteLine($"ID: {usuario.Id}");
                Console.WriteLine($"Usuario: {usuario.username}");
                Console.WriteLine($"Contrasena: {usuario.password}");
                Console.WriteLine($"");
            }

            connection.Close();
            Console.ReadLine();
        }
    }

}

            