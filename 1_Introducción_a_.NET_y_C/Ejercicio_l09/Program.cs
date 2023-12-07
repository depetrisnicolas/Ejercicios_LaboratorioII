namespace Ejercicio_l09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = SolicitarAltura();
            DibujarTrianguloEquilatero(altura);
        }

        static int SolicitarAltura()
        {
            int resultado;

            while (true)
            {
                Console.WriteLine($"Ingrese una altura para el triángulo: ");
                if (int.TryParse(Console.ReadLine(), out int valorDato) && valorDato > 0)
                {
                    resultado = valorDato;
                    break;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es válido");
                }
            }
            return resultado;
        }

        static void DibujarTrianguloEquilatero(int altura)
        {

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= altura - i; j++)
                {
                    Console.Write(" ");
                }

                // Imprimir asteriscos
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}