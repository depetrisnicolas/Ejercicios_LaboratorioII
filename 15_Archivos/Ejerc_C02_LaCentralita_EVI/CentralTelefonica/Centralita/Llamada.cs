using CentralitaHerencia.interfaces;
using System.Text;
namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {this.Duracion}");
            sb.AppendLine($"Numero origen : {this.NroOrigen}");
            sb.AppendLine($"Numero destino: {this.NroDestino}");
           
            return sb.ToString();
        }

        public static int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int returnAux = 0;

            if (llamada1.Duracion < llamada2.Duracion) 
            {
                returnAux = -1;
            }
            else if (llamada1.Duracion > llamada2.Duracion)
            {
                returnAux = 1;
            }
            return returnAux;
        }

        public static bool operator == (Llamada l1, Llamada l2)
        {
            return l1.Equals (l2) && (l1.NroDestino == l2.NroDestino) && (l1.NroOrigen == l2.NroOrigen);
        }

        public static bool operator != (Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


    }
}