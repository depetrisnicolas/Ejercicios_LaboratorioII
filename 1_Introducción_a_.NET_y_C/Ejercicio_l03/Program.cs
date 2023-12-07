using System.Runtime.Intrinsics.X86;

namespace Ejercicio_l03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("INGRESE UN NUMERO: ");
                string datoIngresado = Console.ReadLine();

                if (int.TryParse(datoIngresado, out int numero))
                {
                    Console.WriteLine($"Listado números primos hasta el {numero}: ");
                    for (int i = 1; i < numero; i++)
                    {
                        if (EsPrimo(i))
                        {
                            Console.WriteLine(i);
                        }
                    }

                    Console.WriteLine("DESEA CONTINUAR [S] Si - [N] No");
                    string rtaContinuar = Console.ReadLine();
                    if (rtaContinuar.ToUpper() != "S")
                    {
                        break;
                    }
                }
                else if (datoIngresado == "salir")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("El dato ingresado no correcto. Debe ingresar un número entero positivo");
                }
            }
        }

        static bool EsPrimo(int numero)
        {
            int contador = 0;

            for (int i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }

            }

            if (contador != 2)
            {
                return false;
            }
            else 
            { 
                return true; 
            }
        }
    }
}