using Biblioteca;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio_l01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;
            int valorMinimo = int.MaxValue;
            int valorMaximo = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
         
                int numero = SolicitarNumero(i);

                if (Validador.Validar(numero, -100, 100))
                {
                    numeros[i] = numero;
                    suma += numero;

                    if (numero < valorMinimo)
                        valorMinimo = numero;
                    if (numero > valorMaximo)
                        valorMaximo = numero;
                }
                else
                {
                    Console.WriteLine("El número debe estar en el rango -100 y 100. Intente nuevamente.");
                    i--; 
                }
            }

            double promedio = (double) suma / numeros.Length;

            Console.WriteLine($"Valor mínimo ingresado: {valorMinimo}\nValor máximo ingresado: {valorMaximo}\nPromedio de " +
                $"los números ingresados: {promedio:F2}");
        }

        static int SolicitarNumero(int indice)
        {
            int resultado;

            Console.Write($"Ingrese el número {indice + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                resultado = numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente nuevamente.");
                resultado = 0;
                indice--;
            }
            return resultado;
        }
    }

}


