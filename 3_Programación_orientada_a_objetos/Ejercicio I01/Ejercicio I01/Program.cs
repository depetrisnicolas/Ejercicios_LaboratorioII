using Entidades;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cuenta cuentaUno = new Cuenta("ARMATH SRL", 20000);
            Cuenta cuentaDos = new Cuenta("IRSA S.A.", 8000000);

            Console.WriteLine(cuentaUno.Mostrar());
            Console.WriteLine(cuentaDos.Mostrar());

            cuentaUno.Retirar(1000);
            cuentaDos.Ingresar(1000000);

            Console.WriteLine(cuentaUno.Mostrar());
            Console.WriteLine(cuentaDos.Mostrar());

        }
    }
}