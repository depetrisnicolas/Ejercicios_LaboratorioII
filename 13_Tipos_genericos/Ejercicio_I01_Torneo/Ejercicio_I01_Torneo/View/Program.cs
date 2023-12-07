using Entidades;
namespace View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneo = new Torneo<EquipoFutbol>("Torneo de Futbol");
            Torneo<EquipoBasquet> torneo2 = new Torneo<EquipoBasquet>("Torneo de Basquet");

            EquipoBasquet equipo1 = new EquipoBasquet("Atenas", DateTime.Now);
            EquipoBasquet equipo2 = new EquipoBasquet("Penarol", DateTime.Now);

            _ = torneo2 + equipo1;
            _ = torneo2 + equipo2;

            Console.WriteLine(torneo2.Mostrar());

            string resultadoPartido = torneo2.JugarPartido;
            Console.WriteLine(resultadoPartido);


        }
    }
}