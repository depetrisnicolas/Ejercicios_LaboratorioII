using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassConversor
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public double ConvertirBinarioADecimal(string numeroEntero)
        {

            int baseDecimal = 2;
            double numeroDecimal = 0;
            int exponente = numeroEntero.Length - 1;

            foreach (var numero in numeroEntero)
            {
                int entero = (int)char.GetNumericValue(numero);
                numeroDecimal += entero * (int)Math.Pow(baseDecimal, exponente);
                exponente--;
            }

            return numeroDecimal;
        }

        public static implicit operator NumeroBinario (string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal (NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)numeroBinario.ConvertirBinarioADecimal(numeroBinario.numero);
        }

        public static explicit operator string (NumeroBinario numeroBinario)
        {
            return numeroBinario.numero;
        }

        public static bool operator == (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.numero == ((NumeroBinario)numeroDecimal).numero;
        }

        public static bool operator != (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        public static string operator + (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.ConvertirDecimalABinario(((NumeroDecimal)numeroBinario).numero + numeroDecimal.numero);  
        }

        public static string operator - (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.ConvertirDecimalABinario(((NumeroDecimal)numeroBinario).numero - numeroDecimal.numero);
        }

    }
}
