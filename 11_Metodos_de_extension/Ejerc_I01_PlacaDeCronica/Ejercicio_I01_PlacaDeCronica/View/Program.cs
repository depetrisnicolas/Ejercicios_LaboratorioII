using Entidades;
namespace PlacasCronica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime ahora = new DateTime(2023, 10, 20);


            Console.WriteLine(ahora.ObtenerPlacaCronicaAle(EEstaciones.Verano));
            Console.WriteLine(ahora.ObtenerPlacaCronicaLucas(EEstaciones.Verano));
        }
    }
}