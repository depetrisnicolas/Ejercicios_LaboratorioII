using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaDeCreacion;

        protected Equipo(string nombre, DateTime fechaDeCreacion)
        {
            this.nombre = nombre;
            this.fechaDeCreacion = fechaDeCreacion;
        }

        public static bool operator == (Equipo equipo1, Equipo equipo2)
        {
            return (equipo1.nombre == equipo2.nombre) && (equipo1.fechaDeCreacion == equipo2.fechaDeCreacion);
        }

        public static bool operator != (Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        public string Ficha()
        {
            return $"[{this.nombre}] fundado el [{this.fechaDeCreacion.ToString("dd/MM/yyyy")}]";
        }


    }
}
