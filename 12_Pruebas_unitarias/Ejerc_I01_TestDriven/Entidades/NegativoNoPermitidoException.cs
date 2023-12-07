namespace Entidades
{
    public class NegativoNoPermitidoException : Exception
    {
        public NegativoNoPermitidoException(string? message) : base(message)
        {
        }

        public NegativoNoPermitidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}