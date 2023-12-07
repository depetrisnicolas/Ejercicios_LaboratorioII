using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        ///ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;

        //CONSTRUCTORES
        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //METODOS
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        //SOBRECARGA IMPLICITA
        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        //SOBRECARGAS EXPLICITAS
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad() * Peso.GetCotizacion());
        }

        //SOBRECARGAS DE OPERADORES
        public static bool operator == (Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator == (Dolar d, Euro e)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator == (Dolar d, Peso p)
        {
            return d.GetCantidad() == ((Dolar)p).GetCantidad();
        }

        public static bool operator != (Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator - (Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator - (Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }

        public static Dolar operator + (Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }
        public static Dolar operator + (Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cantidad: {this.cantidad}");
            sb.AppendLine($"Cotización: {cotzRespectoDolar}");

            return sb.ToString();
        }
    }
}
