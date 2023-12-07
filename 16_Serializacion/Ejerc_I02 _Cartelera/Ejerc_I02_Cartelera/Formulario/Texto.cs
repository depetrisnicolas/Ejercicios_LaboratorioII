using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    public class Texto
    {
        private string contenido;

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        private int colorARGB;

        public int ColorARGB
        {
            get { return colorARGB; }
            set { colorARGB = value; }
        }

        public Texto(string contenido, int colorARGB)
        {
            Contenido = contenido;
            ColorARGB = colorARGB;
        }
    }
}
