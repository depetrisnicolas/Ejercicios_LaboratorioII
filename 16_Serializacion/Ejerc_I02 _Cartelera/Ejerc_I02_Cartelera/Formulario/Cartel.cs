using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    public class Cartel
    {
        private int colorARGB;

        public int ColorARGB
        {
            get { return colorARGB; }
            set { colorARGB = value; }
        }

        private Texto titulo;

        public Texto Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private Texto mensaje;

        public Texto Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public Cartel(int colorARGB, Texto titulo, Texto mensaje)
        {
            ColorARGB = colorARGB;
            Titulo = titulo;
            Mensaje = mensaje;
        }
    }
}
