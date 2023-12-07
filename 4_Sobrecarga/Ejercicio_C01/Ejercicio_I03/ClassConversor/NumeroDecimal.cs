using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConversor
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public string ConvertirDecimalABinario(double numeroEntero)
        {
            string numeroBinario = string.Empty;

            while (true)
            {

                int resultadoDivision = (int)numeroEntero / 2;
                int bit = (int)numeroEntero % 2;

                numeroEntero = resultadoDivision;
                numeroBinario = bit.ToString() + numeroBinario;

                if (resultadoDivision == 0)
                {
                    break;
                }
            }
            return numeroBinario;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.ConvertirDecimalABinario(numeroDecimal.numero);
        }

        public static explicit operator double (NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.numero;
        }

        public static bool operator == (NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero == ((NumeroDecimal)numeroBinario).numero;
        }

        public static bool operator != (NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return !(numeroDecimal == numeroBinario);
        }

        public static double operator + (NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero + ((NumeroDecimal)numeroBinario).numero;
        }

        public static double operator - (NumeroDecimal numeroDecimal, NumeroBinario numeroBinario)
        {
            return numeroDecimal.numero - ((NumeroDecimal)numeroBinario).numero;
        }

    }
}
