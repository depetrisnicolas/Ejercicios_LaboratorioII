using CentralitaHerencia.excepciones;
using CentralitaHerencia.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CentralitaHerencia
{
    public class Centralita : IGuardar<string>
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

        public string RutaDeArchivos
        {
            get
            {
                return "MiArchivo.txt";
            }
            set
            {
                this.RutaDeArchivos = value;    
            }
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

        public bool Guardar()
        {
            DateTime fechaActual = DateTime.Now;
            string fechaLetras = fechaActual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");
            string mensaje = fechaLetras + " - Se realizó una llamada";

            //if (!Directory.Exists(this.RutaDeArchivos))
            //{
            //    Directory.CreateDirectory(this.RutaDeArchivos);
            //}

            using (StreamWriter sw = new StreamWriter(this.RutaDeArchivos, true))
            {
                sw.WriteLine(mensaje);
            }
            return true;
        }


        public string Leer()
        {
            using (StreamReader sr = new StreamReader (this.RutaDeArchivos))
            {
                string textoDelArchivo = sr.ReadToEnd();
                return textoDelArchivo;
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

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia total: {this.GananciasPorTotal}"); 
            sb.AppendLine($"Ganancia por llamados locales: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia por llamados provinciales: {this.GananciasPorProvincial}");
            sb.AppendLine("------------------------------------------------------------\n\n******** Listado de llamadas *********");
            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator == (Centralita c, Llamada llamada)
        {
            bool returnAux = false;

            foreach (Llamada call in c.Llamadas)
            {
                if (call == llamada)
                {
                    returnAux = true;
                    break;
                }
            }
            return returnAux;
        }

        public static bool operator != (Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator + (Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
                try
                {
                    c.Guardar();
                }
                catch (Exception ex) 
                {
                    throw new FallaLogException("Falla log exception");
                }
            }
            else
            {
                throw new CentralitaException("La llamada ya se encuentra registrada en el sistema", "Centralita", "Agregar llamada a Centralita");
            }
            return c;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
