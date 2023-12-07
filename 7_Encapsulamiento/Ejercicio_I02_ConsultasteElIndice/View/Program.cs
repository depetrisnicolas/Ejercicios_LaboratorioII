using Entidades;
namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro nuevoLibro = new Libro();

            nuevoLibro[0] = "8";
            nuevoLibro[1] = "2";
            nuevoLibro[2] = "3";
            nuevoLibro[3] = "4";
            nuevoLibro[4] = "5";
            nuevoLibro[5] = "12";



            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine(nuevoLibro[i]);
            }

            Console.WriteLine(nuevoLibro[12]);
        }
    }
}