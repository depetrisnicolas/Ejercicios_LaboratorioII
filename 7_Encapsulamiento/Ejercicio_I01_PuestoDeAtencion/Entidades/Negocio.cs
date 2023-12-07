using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        //ATRIBUTOS
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        //CONSTRUCTORES
        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        //PROPIEDADES
        public Cliente Cliente 
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
        //SOBRECARGAS
        public static bool operator == (Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (c == cliente)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator + (Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~ (Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

    }
}
