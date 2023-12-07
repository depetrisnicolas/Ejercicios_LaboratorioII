using Entidades.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CartucheraSimple
    {
        public List<Boligrafo> listaDeBoligrafos;
        public List<Lapiz> listaDeLapices;

        public CartucheraSimple(List<Boligrafo> listaDeBoligrafos, List<Lapiz> listaDeLapices)
        {
            this.listaDeBoligrafos = listaDeBoligrafos;
            this.listaDeLapices = listaDeLapices;
        }

        public bool RecorrerElementos()
        {
            foreach (var item in this.listaDeBoligrafos)
            {
                if (item.UnidadesDeEscritura >= 1)
                {
                    item.Escribir("1234");
                }
                else
                {
                    item.Recargar(20);
                    return false;   
                }
            }

            foreach (var item in this.listaDeLapices)
            {
                if (((IAcciones)item).UnidadesDeEscritura >= 1)
                {
                    ((IAcciones)item).Escribir("1234567890");
                }
                else
                {
                    ((IAcciones)item).Recargar(20);
                    return false;
                }
            }
            return true;

        }
    }
}
