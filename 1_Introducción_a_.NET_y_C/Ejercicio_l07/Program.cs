using System.Text.RegularExpressions;

namespace Ejercicio_l07
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            while (true)
            {
                int valorHora = SolicitarDatoNumerico("valor hora");
                string nombre = SolicitarNombre();
                int antiguedad = SolicitarDatoNumerico("antiguedad");
                int cantidadHoras = SolicitarDatoNumerico("cantidad horas");

                int sueldoBruto = CalcularHorasTrabajadas(valorHora, cantidadHoras) + CalcularAntiguedad(antiguedad);
                int sueldoNeto = CalcularDescuento(sueldoBruto);

                Console.WriteLine($"El trabajador {nombre} con una antiguedad de {antiguedad} años, cobra por hora {cantidadHoras}\n y percibe un salario bruto de ${sueldoBruto} y neto de ${sueldoNeto}");
            }
            
        }


        static int SolicitarDatoNumerico(string datoSolicitado)
        {
            int resultado;

            while (true)
            {
                Console.WriteLine($"Ingrese {datoSolicitado}: ");
                if (int.TryParse(Console.ReadLine(), out int valorDato) && valorDato > 0)
                {
                    resultado = valorDato;
                    break;
                }
                else 
                {
                    Console.WriteLine("El valor ingresado no es válido");
                }
            }
            return resultado;
        }

        static string SolicitarNombre()
        {
            string nombre;

            while (true)
            {
                Console.WriteLine("Ingrese un nombre: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                {
                    nombre = input;
                    break;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido");
                }
            }

            return nombre;
        }

        static int CalcularHorasTrabajadas(int valorHora, int cantidadHoras)
        {
            return valorHora * cantidadHoras;
        }

        static int CalcularAntiguedad(int aniosTrabajados)
        {
            return aniosTrabajados * 150;
        }

        static int CalcularDescuento(int sueldo)
        {
            return sueldo - (sueldo * 13 / 100);
        }
    }
}