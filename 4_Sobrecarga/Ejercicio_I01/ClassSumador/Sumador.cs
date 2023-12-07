using System.Drawing;
using System.Runtime.CompilerServices;

namespace ClassSumador
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador():this(0)
        {

        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;

            return a + b;
        }

        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }

        public int GetCantidad()
        {
            return this.cantidadSumas;
        }

        public static long operator + (Sumador a, Sumador b)
        {
            return a.cantidadSumas + b.cantidadSumas;
        }

        public static bool operator | (Sumador a, Sumador b)
        {
            return a.cantidadSumas == b.cantidadSumas;
        }


    }
}