using CentralitaHerencia;
using CentralitaHerencia.excepciones;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Centralita c = new Centralita("Fede Center");

            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

            try
            {
                c += l1;
                l1.Guardar();
                l1.GuardarJson();
                c += l2;
                l2.Guardar();
                l2.GuardarJson();
                c += l3;
                c += l3;
                c += l4;
            }

            catch (CentralitaException ex)
            {
                Console.WriteLine($"Error: {ex.Message}, producido en {ex.NombreClase}, al momento de {ex.NombreMetodo}");
            }
            catch (FallaLogException ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            }


            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.WriteLine(c.Leer());

            

            Console.ReadKey();
        }
    }
}