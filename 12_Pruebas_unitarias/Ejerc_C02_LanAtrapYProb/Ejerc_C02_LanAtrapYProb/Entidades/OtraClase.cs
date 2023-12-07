using Entidades.excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MiMetodoDeInstancia()
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Excepcion capturada en OtraClase en MiMetodoDeInstancia", ex);
            }

        }

    }


}
