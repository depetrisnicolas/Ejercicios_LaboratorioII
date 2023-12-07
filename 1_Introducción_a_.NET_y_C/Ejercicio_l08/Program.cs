namespace Ejercicio_l08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura = SolicitarAltura();
            DibujarTriangulo(altura);
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

        static void DibujarTriangulo(int altura)
        {

            for (int i = 1; i <= altura * 2; i+=2)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}