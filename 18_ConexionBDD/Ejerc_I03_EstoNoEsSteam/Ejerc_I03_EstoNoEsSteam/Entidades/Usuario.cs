using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int codigoUsuario;
        private string username;

        public Usuario(string username, int codigoUsuario)
        {
            this.username = username;
            this.codigoUsuario = codigoUsuario;
        }

        public int CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public override string ToString()
        {
            return this.username;
        }


    }
}
