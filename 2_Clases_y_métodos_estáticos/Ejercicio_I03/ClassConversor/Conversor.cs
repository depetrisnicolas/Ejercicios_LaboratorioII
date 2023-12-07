using System.ComponentModel;

namespace ClassConversor
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = string.Empty;

            while (true)
            {
                
                int resultadoDivision = numeroEntero / 2;
                int bit = numeroEntero % 2;

                numeroEntero = resultadoDivision;
                numeroBinario = bit.ToString() + numeroBinario;

                if (resultadoDivision == 0)
                {
                    break;
                }
            }
            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(string numeroEntero)
        { 

            int baseDecimal = 2;
            int numeroDecimal = 0;
            int exponente = numeroEntero.Length - 1;

            foreach (var numero in numeroEntero)
            {
                int entero = (int)char.GetNumericValue(numero);
                numeroDecimal += entero * (int)Math.Pow(baseDecimal, exponente);
                exponente--;
            }

            return numeroDecimal;
        }
    }
}