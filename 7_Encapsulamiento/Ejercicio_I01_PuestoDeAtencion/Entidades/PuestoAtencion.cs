using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        //ENUMERADOS
        public enum Puesto
        {
            Caja1, Caja2
        }

        //ATRIBUTOS
        private static int numeroActual;
        private Puesto puesto;

        //PROPIEDADES
        public int NumeroActual
        {
            get
            {
                return ++numeroActual;
            }
        }

        //CONSTRUCTORES
        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        //METODOS
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(5000);
                return true;
            }
            return false;
        }


    }


}
