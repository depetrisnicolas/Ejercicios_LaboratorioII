using Entidades;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            string numeroIngresado = Console.ReadLine();
            if (int.TryParse(numeroIngresado, out int numeroInt))
            {
                Console.WriteLine("Numero de" + new string(' ', 10) + $"{numeroInt.ObtenerCantidadDigitos()} dígitos");
            }
        }
    }
}