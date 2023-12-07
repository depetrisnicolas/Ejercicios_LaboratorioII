using System.ComponentModel;
using Entidades;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAlcanzado = Add("1,2");
            Console.WriteLine(numeroAlcanzado);
        }

        public static int Add(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {
                char[] delimiters;

                if (numeros[0] == '/' && numeros[1] == '/')
                {
                    delimiters = new char[] { ',', '\n', numeros[2] };
                }
                else
                {
                    delimiters = new char[] { ',', '\n' };
                }

                string[] partes = numeros.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                int suma = 0;

                foreach (string parte in partes)
                {
                    if (int.TryParse(parte, out int valor))
                    {
                        if (valor < 0)
                        {
                            throw new NegativoNoPermitidoException($"Se recibió un número negativo: {valor}");
                        }
                        else
                        {
                            suma += valor;
                        }
                    }
                }
                return suma;
            }
        }
    }
}