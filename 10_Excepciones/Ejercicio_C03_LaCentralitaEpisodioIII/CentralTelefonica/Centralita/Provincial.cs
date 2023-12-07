using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public override float CostoLlamada
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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja horaria: {this.franjaHoraria}"); 
            sb.AppendLine($"Costo llamada: {this.CostoLlamada}");

            return sb.ToString();   
        }

        public override bool Equals(object? obj)
        {
            return obj is Provincial;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
