using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.excepciones;

namespace Entidades
{
    public static class JuegoDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JuegoDAO()
        {
            JuegoDAO.cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            JuegoDAO.comando = new SqlCommand();
            JuegoDAO.conexion = new SqlConnection(JuegoDAO.cadenaConexion);
            JuegoDAO.comando.Connection = JuegoDAO.conexion;
            JuegoDAO.comando.CommandType = System.Data.CommandType.Text;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                using (JuegoDAO.conexion)
                {
                    string query = "DELETE FROM JUEGOS WHERE CODIGO_JUEGO=@codigoJuego";

                    JuegoDAO.comando = new SqlCommand(query, JuegoDAO.conexion);

                    JuegoDAO.comando.Parameters.AddWithValue("codigoJuego", codigoJuego);

                    JuegoDAO.conexion.Open();
                    JuegoDAO.comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex) 
            {

            }
        }

        public static void Modificar(Juego juego)
        {
            try
            {
                using (JuegoDAO.conexion)
                {
                    string query = "UPDATE JUEGOS set PRECIO=@precio, NOMBRE=@nombre, GENERO=@genero WHERE CODIGO_JUEGO=@codigoJuego";

                    JuegoDAO.comando = new SqlCommand(query, JuegoDAO.conexion);

                    JuegoDAO.comando.Parameters.AddWithValue("precio", juego.Precio);
                    JuegoDAO.comando.Parameters.AddWithValue("nombre", juego.Nombre);
                    JuegoDAO.comando.Parameters.AddWithValue("genero", juego.Genero);
                    JuegoDAO.comando.Parameters.AddWithValue("codigoJuego", juego.CodigoJuego);

                    JuegoDAO.conexion.Open();
                    JuegoDAO.comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void Guardar(Juego juego) 
        {
            try
            {
                using (JuegoDAO.conexion)
                {
                    string query = "INSERT INTO JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO)" +
                        "values (@codigo_usuario,@nombre,@precio,@genero); SELECT @@IDENTITY";

                    JuegoDAO.comando = new SqlCommand(query, JuegoDAO.conexion);

                    JuegoDAO.comando.Parameters.AddWithValue("codigo_usuario", juego.CodigoUsuario);
                    JuegoDAO.comando.Parameters.AddWithValue("nombre", juego.Nombre);
                    JuegoDAO.comando.Parameters.AddWithValue("precio", juego.Precio);
                    JuegoDAO.comando.Parameters.AddWithValue("genero", juego.Genero);

                    JuegoDAO.conexion.Open();
                    JuegoDAO.comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static List<Biblioteca> Leer()
        {
            try
            {
                using (JuegoDAO.conexion)
                {
                    List<Biblioteca> lista = new List<Biblioteca>();
                    string query = "SELECT JUEGOS.CODIGO_JUEGO,JUEGOS.NOMBRE,JUEGOS.GENERO,USUARIOS.USERNAME FROM JUEGOS " +
                        "INNER JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";
                    JuegoDAO.comando = new SqlCommand(query, JuegoDAO.conexion);
                    JuegoDAO.conexion.Open();
                    SqlDataReader reader = JuegoDAO.comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Biblioteca bibilioteca = new Biblioteca(reader["USUARIOS.USERNAME"].ToString(), reader["USUARIOS.GENERO"].ToString(),
                                reader["JUEGOS.NOMBRE"].ToString(), ((int)reader["JUEGOS.CODIGO_JUEGO"]));

                            lista.Add(bibilioteca);
                        }
                        return lista;
                    }
                    else
                    {
                        throw new ElementoNoEncontradoException("Tabla Vacia");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juego = null;

            try
            {
                using (JuegoDAO.conexion)
                {
                    string query = "SELECT * FROM JUEGOS WHERE CODIGO_JUEGO=@codigoJuego";
                    JuegoDAO.comando.Parameters.AddWithValue("codigoJuego", codigoJuego);
                    JuegoDAO.comando = new SqlCommand(query, JuegoDAO.conexion);
                    JuegoDAO.conexion.Open();
                    SqlDataReader reader = JuegoDAO.comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            juego = new Juego(reader.GetString(2), reader.GetDouble(3), reader.GetString(4), reader.GetInt32(0)); 
                        }
             
                        return juego;
                    }
                    else
                    {
                        throw new ElementoNoEncontradoException("No se encuentra un juego con ese código");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
