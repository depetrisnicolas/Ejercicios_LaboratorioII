using ClassConversor;
using System.Diagnostics.CodeAnalysis;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Probamos el codigo

                NumeroBinario numeroBinario = "1111";
                NumeroDecimal numeroDecimal = 8;

                string binario = (string)numeroBinario;
                double unDecimal = (double)numeroDecimal;

                NumeroBinario nuevoNumeroBinario = (NumeroBinario)numeroDecimal;
                NumeroDecimal nuevoNumeroDecimal = (NumeroDecimal)numeroBinario;
                Console.WriteLine(nuevoNumeroBinario.numero);
                Console.WriteLine(nuevoNumeroDecimal.numero);

                Console.WriteLine($"El numero binario es {numeroBinario.numero}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");

                Console.WriteLine($"El numero decimal es {numeroDecimal.numero}, sumado con el binario da un total de {numeroBinario + numeroDecimal}");
               
                //string suma = numeroBinario + numeroDecimal;
                //double sumaDos = numeroDecimal + numeroBinario;

                //Console.WriteLine(suma);
                //Console.WriteLine(sumaDos);
                //Console.WriteLine($"El numero binario es {numeroBinario.numero}, resta con el decimal da un total de {numeroDecimal - numeroBinario}");

                //Console.WriteLine($"El numero decimal es {numeroDecimal.numero}, resta con el binario da un total de {(numeroBinario - numeroDecimal)}");
                //Console.ReadKey();

            }
        }
    }
}