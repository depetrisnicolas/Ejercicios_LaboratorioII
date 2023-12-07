using Entidades.interfaces;
using System.Drawing;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.UnidadesDeEscritura = unidades;
        }

        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set
            {
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.UnidadesDeEscritura -= texto.Length * 0.3f;
            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.UnidadesDeEscritura += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Boligrafo color: {this.Color} con {this.UnidadesDeEscritura} unidades de tinta restantes";
        }
    }
}