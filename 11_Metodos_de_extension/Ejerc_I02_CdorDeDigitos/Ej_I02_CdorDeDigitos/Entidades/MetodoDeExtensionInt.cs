namespace Entidades
{
    public static class MetodoDeExtensionInt
    {
        public static int ObtenerCantidadDigitos(this int valor)
        {
            string valorStr = valor.ToString();
            return valorStr.Length;

        }
    }
}