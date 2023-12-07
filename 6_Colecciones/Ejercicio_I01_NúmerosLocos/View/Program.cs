

using System.Security.Cryptography.X509Certificates;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LISTA NUMEROS RANDOM: ");
            int contador = 0;

            List<int> listaNumerosRandom = new List<int>();
            Random numeroRandom = new Random();

            while(true)
            { 
                int numeroAleatorio = numeroRandom.Next(-10,10);
                if(contador == 20)
                {
                    break;
                }
                else
                {
                    if (numeroAleatorio != 0)
                    {
                        listaNumerosRandom.Add(numeroAleatorio);
                        contador++;
                    }
                }    
            }

            foreach (int numero in listaNumerosRandom) 
            {
                Console.WriteLine(numero);
            }
            

            Console.WriteLine("\nLISTA POSITIVOS DECRECIENTE: ");

            List<int> listaPositivosDecreciente = new List<int>();
            List<int> listaNegativosCreciente = new List<int>();

            foreach (int numero in listaNumerosRandom)
            {
                if(numero > 0)
                {
                    listaPositivosDecreciente.Add(numero);
                }
                else if(numero < 0)
                {
                    listaNegativosCreciente.Add(numero);
                }
            }

            listaPositivosDecreciente.Sort(FuncionCriterio);

            foreach (int numero in listaPositivosDecreciente)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\nLISTA NEGATIVOS CRECIENTE: ");

            listaNegativosCreciente.Sort();

            foreach (int numero in listaNegativosCreciente)
            {
                Console.WriteLine(numero);
            }
        }

        public static int FuncionCriterio(int a, int b)
        {
            return b - a;
        }
    }
}