using ClassSumador;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador objetoSumador = new Sumador();
            Sumador objetoSumador2 = new Sumador(6);

            int unNumero = (int)objetoSumador2;

            bool resultado = objetoSumador | objetoSumador2;
            Console.WriteLine(resultado);
            Console.WriteLine(unNumero);
        }
    }
}