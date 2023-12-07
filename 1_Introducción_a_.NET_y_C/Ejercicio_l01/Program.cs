namespace Ejercicio_l01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosIngresados = new int[5]; // Creamos un arreglo para almacenar los números
            int acumulador = 0;
            int minimo = int.MaxValue; // Inicializamos el mínimo con un valor grande
            int maximo = int.MinValue; // Inicializamos el máximo con un valor pequeño
            int contador = 0;

            Console.WriteLine("Ingresa 5 números:");

            for (int i = 0; i < 5; i++)
            {
                contador++;
                Console.Write($"Número {i + 1}: ");
                string datoIngresado = Console.ReadLine();


                if (int.TryParse(datoIngresado, out numerosIngresados[i]))
                {
                    acumulador += numerosIngresados[i];

                    if (numerosIngresados[i] < minimo)
                    {
                        minimo = numerosIngresados[i];
                    }
                    if (numerosIngresados[i] > maximo)
                    {
                        maximo = numerosIngresados[i];
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingresa un número entero.");
                    i--;
                }
            }

            double promedio = (double)acumulador / contador;

            Console.WriteLine($"Promedio: {promedio}\nValor máximo: {maximo}\nValor mínimo: {minimo}");
        }
    }
}