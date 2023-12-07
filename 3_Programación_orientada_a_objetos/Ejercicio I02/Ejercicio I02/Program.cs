using Entidades;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Nicolás", new DateTime(1994,3,1), 38156210);
            Persona personaDos = new Persona("Agustina", new DateTime(2010, 9, 8), 50585583);


            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
        }


    }
}