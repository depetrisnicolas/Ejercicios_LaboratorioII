using Entidades.excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioDAO
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDAO()
        {
            UsuarioDAO.cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            UsuarioDAO.comando = new SqlCommand();
            UsuarioDAO.conexion = new SqlConnection(UsuarioDAO.cadenaConexion);
        }

        public static List<Usuario> Leer()
        {
            try
            {
                using (UsuarioDAO.conexion)
                {
                    List<Usuario> listaUsuarios = new List<Usuario>();
                    string query = "SELECT CODIGO_USUARIO,USERNAME FROM USUARIOS";
                    UsuarioDAO.comando = new SqlCommand(query, UsuarioDAO.conexion);
                    UsuarioDAO.conexion.Open();
                    SqlDataReader reader = UsuarioDAO.comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario(reader.GetString(1), reader.GetInt32(0));
                            listaUsuarios.Add(usuario);
                        }
                        return listaUsuarios;
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
    }
}
