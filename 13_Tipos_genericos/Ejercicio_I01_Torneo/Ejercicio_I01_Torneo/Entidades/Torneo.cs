using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Torneo <T> where T : Equipo 
    {
        private List<T> equipos;
        private string nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        public string JugarPartido
        {
            get
            {
                Random rd = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[rd.Next(0, equipos.Count)];
                    equipo2 = equipos[rd.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);

                return CalcularPartido(equipo1, equipo2);
            }
        }
        


        public static bool operator == (Torneo<T> torneo, T equipo)
        {
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator + (Torneo<T> torneo, T equipo)
        {
            if ((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {this.nombre}");
            foreach (T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            return $"{equipo1.nombre} {random.Next(0, 10)} - {equipo2.nombre} {random.Next(0, 10)}";
        }



    }
}