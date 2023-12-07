using ClassConversor;
namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroConvertidoABinario = Conversor.ConvertirDecimalABinario(100);
            int numeroConvertidoADecimal = Conversor.ConvertirBinarioADecimal("1100100");
            Console.WriteLine(numeroConvertidoABinario);
            Console.WriteLine(numeroConvertidoADecimal);
        }
    }
}