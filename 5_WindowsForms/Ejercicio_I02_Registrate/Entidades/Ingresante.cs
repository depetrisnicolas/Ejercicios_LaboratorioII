using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string nombre;
        private string direccion;
        private int edad;
        private string pais;
        private string genero;
        private string[] cursos;

        public Ingresante(string nombre, string direccion, int edad, string pais, string genero, string[] cursos)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.pais = pais;
            this.genero = genero;
            this.cursos = cursos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Genero: {this.genero}");
            foreach (string curso in cursos) 
            {
                sb.Append($"Curso: {curso}");
            }

            return sb.ToString();
        }
    }
}