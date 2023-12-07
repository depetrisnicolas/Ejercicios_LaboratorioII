using Biblioteca;
namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto unProducto = new Producto("0011122219", "Philips", (float)50000.00);
            string unCodigoDeBarra = (string)unProducto;

            Console.WriteLine(unCodigoDeBarra);
        }
    }
}