namespace Entidades
{
    public enum Colores
    {
        Rojo, Blanco, Azul, Gris, Negro
    }
    public class Automovil : VehiculoTerrestre
    {

        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            :base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}