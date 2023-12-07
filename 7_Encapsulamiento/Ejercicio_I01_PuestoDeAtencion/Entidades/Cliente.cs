using System.Data.Common;

namespace Entidades
{
    public class Cliente
    {
        //ATRIBUTOS
        private string nombre;
        private int numero;

        //CONSTRUCTORES
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre)
            :this(numero)  
        {
            this.nombre = nombre;   
        }

        //PROPIEDADES
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        //SOBRECARGAS
        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator != (Cliente c1, Cliente c2)
        {
            return !(c1 == c2);   
        }

    }

}