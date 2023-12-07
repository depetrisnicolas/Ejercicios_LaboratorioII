namespace Ejercicio_l05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número entero positivo: ");
                if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)
                {
                    Console.WriteLine($"Los centros numéricos entre 1 y {numero} son:");

                    for (int i = 2; i <= numero; i++)
                    {
                        if (EsCentroNumerico(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar un número entero positivo.");
                }
            }
        }

        static bool EsCentroNumerico(int numero)
        {
            int sumaAnteriores = 0;
            int sumaPosteriores = 0;

            for (int i = 1; i < numero; i++)
            {
                sumaAnteriores += i;
            }

            for (int i = numero + 1; sumaPosteriores < sumaAnteriores; i++)
            {
                sumaPosteriores += i;
            }

            return sumaAnteriores == sumaPosteriores;
        }
    }
}