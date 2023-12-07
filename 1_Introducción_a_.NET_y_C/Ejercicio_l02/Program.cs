namespace Ejercicio_l02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("INGRESE UN NUMERO: ");
                string numeroIngresado = Console.ReadLine();
            
                if(int.TryParse(numeroIngresado, out int numero) && (numero > 0))
                {
                    double numeroAlCuadrado = Math.Pow(numero, 2);
                    double numeroAlCubo = Math.Pow(numero, 3);
                    Console.WriteLine($"El número {numero} al cuadrado es: {numeroAlCuadrado} y al cubo es: {numeroAlCubo}");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }
        }
    }
}