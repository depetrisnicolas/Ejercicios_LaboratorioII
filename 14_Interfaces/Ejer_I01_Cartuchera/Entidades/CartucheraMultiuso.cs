using Entidades.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraMultiuso
    {
        public List<IAcciones> listaDeAcciones;


        public CartucheraMultiuso(List<IAcciones> listaDeAcciones)
        {
            this.listaDeAcciones = listaDeAcciones;
        }

        public bool RecorrerElementos()
        {
            foreach (var item in listaDeAcciones)
            {
                if (item.UnidadesDeEscritura >= 1)
                {
                    if (item is Lapiz lapiz)
                    {
                        item.Escribir("1234567890");
                    }
                    else
                    {
                        item.Escribir("1234");
                    }
                }
                else
                {
                    item.Recargar(20);
                    return false;
                }  
            }
            return true;
        }
    }
}
