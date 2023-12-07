namespace Entidades
{
    public class Juego
    {
        private int codigoJuego;
        private int codigoUsuario;
        private string genero;
        private string nombre;
        private double precio;

        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario)
            :this(nombre, precio, genero, codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario; 
        }

        public int CodigoJuego
        {
            get { return this.codigoJuego; }
        }

        public int CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public string Genero
        {
            get { return this.genero; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public double Precio
        {
            get { return this.precio; }
        }


    }
}