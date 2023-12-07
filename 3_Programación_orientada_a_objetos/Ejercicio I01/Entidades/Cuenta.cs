using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Dinero: {this.cantidad}");

            return sb.ToString();
        }

        public void Ingresar(double monto)
        {
            if (monto >= 0) 
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(double monto) 
        {
            this.cantidad -= monto;
        }
    }
}