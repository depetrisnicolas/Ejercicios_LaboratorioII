using Microsoft.VisualBasic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private long dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, long dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaDeNacimiento() 
        {
            return this.fechaDeNacimiento;
        }

        public long GetDni()
        {
            return this.dni;
        }

        public void SetNombre(string unNombre)
        {
            this.nombre = unNombre;
        }

        public void SetFechaDeNacimiento(DateTime unaFechaDeNacimiento)
        {
            this.fechaDeNacimiento = unaFechaDeNacimiento; 
        }

        public void SetDni(long unDni)
        {
            this.dni = unDni;
        }

        private int CalcularEdad(DateTime fechaDeNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaDeNacimiento.Year;

            if (fechaDeNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {(this.fechaDeNacimiento).ToString("dd/MM/yyyy")}");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Edad: {CalcularEdad(this.fechaDeNacimiento)}");
            sb.AppendLine($"{EsMayorDeEdad()}");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            string mensaje;

            if (CalcularEdad(this.fechaDeNacimiento) > 17) 
            {
                return mensaje = "Es mayor de edad";
            }
            else
            {
                return mensaje = "Es menor";
            }
  
        }
    }
}