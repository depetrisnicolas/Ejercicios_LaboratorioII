using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine($"Codigo de barra: {p.codigoDeBarra}");
            sb.AppendLine($"Marca: {p.GetMarca}");
            sb.AppendLine($"Precio: {p.GetPrecio}");

            return sb.ToString();
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator  == (Producto p1, Producto p2) 
        {
            return p1.GetMarca() == p2.GetMarca() && p1.codigoDeBarra == p2.codigoDeBarra;
        }

        public static bool operator != (Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator == (Producto p, string marca)
        {
            return p.GetMarca() == marca;
        }

        public static bool operator != (Producto p, string marca)
        {
            return !(p == marca);
        }

    }
}