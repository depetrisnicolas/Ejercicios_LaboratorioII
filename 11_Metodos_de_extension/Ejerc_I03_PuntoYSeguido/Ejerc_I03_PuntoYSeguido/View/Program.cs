using System.Runtime.CompilerServices;

namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".ContarSignos());
        }
    }

    public static class MiExtension
    {
        public static int ContarSignos(this String str)
        {
            if (str is not null)
            {
                int acumulador = 0;

                foreach (char c in str)
                {
                    if (c == '.' || c == ',' || c == ';')
                    {
                        acumulador++;
                    }
                }
                return acumulador;
            }
            return 0;
        }
    }
}