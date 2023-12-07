namespace Ejercicio_l04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 2; 
            int encontrados = 0; 

            Console.WriteLine("Los primeros 4 números perfectos son:");

            while (encontrados < 4)
            {
                if (EsNumeroPerfecto(numero))
                {
                    Console.WriteLine(numero);
                    encontrados++;
                }
                numero++;
            }

            static bool EsNumeroPerfecto(int numero)
            {
                int sumaDivisores = 1; 

                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                        if (i != numero / i) // Evitamos contar el mismo divisor dos veces si es un cuadrado perfecto
                        {
                            sumaDivisores += numero / i;
                        }
                    }
                }

                return sumaDivisores == numero;
            }
        }
    }
}