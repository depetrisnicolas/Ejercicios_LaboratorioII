using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;

        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.juego = juego;
            this.usuario = usuario; 
            this.genero = genero;   
            this.codigoJuego = codigoJuego;
        }

        public int CodigoJuego
        {
            get { return this.codigoJuego;}
        }

        public string Genero
        {
            get { return this.genero;}
        }

        public string Juego
        {
            get { return this.juego;}
        }

        public string Usuario
        {
            get { return this.usuario;}
        }
    }
}
