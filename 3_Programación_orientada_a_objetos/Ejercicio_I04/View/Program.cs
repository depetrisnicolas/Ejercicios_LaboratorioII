using ClassBoligrafo;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginalDeConsola = Console.ForegroundColor;
            string dibujo;

            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            Console.ForegroundColor = boligrafoAzul.GetColor();
            boligrafoAzul.Pintar(50, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"El nivel de tinta del boligrafo azul es {boligrafoAzul.GetTinta()}");

            Console.ForegroundColor = colorOriginalDeConsola;
            boligrafoAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"El nivel de tinta del boligrafo azul es {boligrafoAzul.GetTinta()}");

            Console.ForegroundColor = boligrafoAzul.GetColor();
            boligrafoAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"El nivel de tinta del boligrafo azul es {boligrafoAzul.GetTinta()}");

            Console.ReadKey();
            
        }
    }
}