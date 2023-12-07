using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :this(miFranja, new Llamada(duracion, destino, origen))
        {
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float costo;

            switch (this.franjaHoraria) 
            {
                case Franja.Franja_1:
                    costo = base.Duracion * (float)0.99;
                    break;

                case Franja.Franja_2:
                    costo = base.Duracion * (float)1.25;
                    break;

                default:
                    costo = base.Duracion * (float)0.66;
                    break;
            }

            return costo;
        }
    }
}
