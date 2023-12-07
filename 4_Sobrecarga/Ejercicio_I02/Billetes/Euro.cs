using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        ///ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;

        //CONSTRUCTORES
        static Euro()
        {
            Euro.cotzRespectoDolar = 1 / 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

        //METODOS
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        //SOBRECARGA IMPLICITA
        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        //SOBRECARGAS EXPLICITAS
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar (e.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }

        //SOBRECARGAS DE OPERADORES
        public static bool operator == (Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }

        public static bool operator != (Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator == (Euro e, Dolar d)
        {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }

        public static bool operator != (Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator == (Euro e, Peso p)
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }

        public static bool operator != (Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator - (Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator - (Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator + (Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
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
