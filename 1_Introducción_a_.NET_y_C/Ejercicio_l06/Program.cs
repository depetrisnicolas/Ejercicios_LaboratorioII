using System;

namespace Ejercicio_l06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anioInicio = SolicitarAnio("Inicio");
            int anioFin = SolicitarAnio("fin");

            for (int i = anioInicio + 1; i < anioFin; i++)
            {
                if (EsBisiesto(i)) 
                {
                    Console.WriteLine(i);
                }
            }
        }


        static int SolicitarAnio(string anioSolicitado)
        {        
            int retorno; 

            while (true)
            {
                Console.Write($"Ingrese un año de {anioSolicitado}, el mismo debe ser un entero positivo: ");
                if (int.TryParse(Console.ReadLine(), out int anio))
                {
                    retorno = anio; 
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida");
                }
            }

            return retorno; 
        }


        static bool EsBisiesto(int numero)
        {
            return numero % 4 == 0 && (!(numero % 100 == 0) || numero % 400 == 0); 
        }
    }
}