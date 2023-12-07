namespace Entidades
{
    public static class Calculador
    {
        public static double Calcular(int kilometros, int litros)
        {
            if (litros == 0)
            {
                throw new DivideByZeroException();
            }
            return kilometros / litros;
        }
    }
}