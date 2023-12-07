using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get 
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia (Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada is Local)
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    return gananciaLocal;
                 
                case Llamada.TipoLlamada.Provincial:
                    return gananciaProvincial;
                    
                default: 
                    return gananciaLocal + gananciaProvincial;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: {this.GananciasPorTotal}"); 
            sb.AppendLine($"Ganancia por llamados locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia por llamados provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine("------------------------------------------------------------\n\n******** Listado de llamadas *********");
            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
