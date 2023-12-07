using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.excepciones;

namespace Entidades
{
    public class PersonaDAO
    {
        private static string stringConnection;

        static PersonaDAO()
        {
            PersonaDAO.stringConnection = "Server=.;Database=Persona;Trusted_Connection=True;";
        }


        public static void Guardar(Persona persona)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.stringConnection))
                {
                    string query = "INSERT INTO Personas (nombre,apellido)" +
                        "values (@nombre,@apellido); SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("nombre", persona.Nombre);
                    command.Parameters.AddWithValue("apellido", persona.Apellido);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        public static List<Persona> Leer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.stringConnection))
                {
                    List<Persona> listaPersonas = new List<Persona>();
                    string query = "SELECT * FROM Personas";
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Persona persona = new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            listaPersonas.Add(persona);
                        }
                        return listaPersonas;
                    }
                    else
                    {
                        throw new ElementoNoEncontradoException("Tabla Vacia");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al obtener un elemento por ID", ex);
            }
        }

        public static Persona LeerPorID(int id)
        {
            List<Persona> listaPersonas = PersonaDAO.Leer();

            foreach (Persona persona in listaPersonas)
            {
                if (persona.Id == id)
                {
                    return persona;
                }
            }

            throw new ElementoNoEncontradoException("Ningún elemento para ese Id");
        }

        public static void Modificar(Persona personaEditada, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.stringConnection))
                {
                    string query = "UPDATE Personas set Nombre=@nombre, Apellido=@apellido WHERE ID=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);
                    command.Parameters.AddWithValue("nombre", personaEditada.Nombre);
                    command.Parameters.AddWithValue("apellido", personaEditada.Apellido);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al actualizar la persona", ex);
            }
        }

        public static bool Borrar(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(PersonaDAO.stringConnection))
                {
                    string query = "DELETE FROM Personas WHERE ID=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al borrar una persona", ex);
            }
        }
    }
}
