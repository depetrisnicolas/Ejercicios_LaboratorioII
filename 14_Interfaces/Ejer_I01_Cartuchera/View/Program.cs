using Entidades;
using Entidades.interfaces;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            List<IAcciones> listaDeAcciones = new List<IAcciones>();
            listaDeAcciones.Add(new Lapiz(10));
            listaDeAcciones.Add(new Lapiz(5));
            listaDeAcciones.Add(new Lapiz(20));

            listaDeAcciones.Add(new Boligrafo(40, ConsoleColor.Red));
            listaDeAcciones.Add(new Boligrafo(10, ConsoleColor.Yellow));
            listaDeAcciones.Add(new Boligrafo(20, ConsoleColor.Green));

            List<Lapiz> listaDeLapices = new List<Lapiz>();
            listaDeLapices.Add(new Lapiz(10));
            listaDeLapices.Add(new Lapiz(5));
            listaDeLapices.Add(new Lapiz(20));

            List<Boligrafo> listaDeBoligrafos = new List<Boligrafo>();

            listaDeBoligrafos.Add(new Boligrafo(40, ConsoleColor.Red));
            listaDeBoligrafos.Add(new Boligrafo(10, ConsoleColor.Yellow));
            listaDeBoligrafos.Add(new Boligrafo(20, ConsoleColor.Green));

            CartucheraMultiuso miCartucheraMultiuso = new CartucheraMultiuso(listaDeAcciones);
            CartucheraSimple miCartucheraSimple = new CartucheraSimple(listaDeBoligrafos, listaDeLapices);

            while(miCartucheraMultiuso.RecorrerElementos())
            {
                Console.WriteLine("Sigo recorriendo elementos de mi cartuchera multiuso");
            }
            Console.WriteLine("Deje de recorrer mi cartuchera multiuso");

            while (miCartucheraSimple.RecorrerElementos())
            {
                Console.WriteLine("Sigo recorriendo elementos de mi cartuchera simple");
            }
            Console.WriteLine("Deje de recorrer mi cartuchera simple");
        }
    }
}