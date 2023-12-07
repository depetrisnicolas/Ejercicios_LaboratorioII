using System.Text;

namespace Billetes
{
    public class Peso
    {
        ///ATRIBUTOS
        private double cantidad;
        private static double cotzRespectoDolar;

        //CONSTRUCTORES
        static Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }

        //METODOS
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        //SOBRECARGA IMPLICITA
        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        //SOBRECARGAS EXPLICITAS
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar (p.GetCantidad() / Peso.cotzRespectoDolar);
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        //SOBRECARGAS DE OPERADORES
        public static bool operator == (Peso p1, Peso p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }

        public static bool operator != (Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator == (Peso p, Dolar d)
        {
            return p.GetCantidad() == ((Peso)d).GetCantidad();
        }

        public static bool operator != (Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator == (Peso p, Euro e)
        {
            return p.GetCantidad() == ((Peso)e).GetCantidad();
        }

        public static bool operator != (Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator - (Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() - ((Peso)d).GetCantidad());
        }
        public static Peso operator - (Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }

        public static Peso operator + (Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
        }
        public static Peso operator + (Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
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