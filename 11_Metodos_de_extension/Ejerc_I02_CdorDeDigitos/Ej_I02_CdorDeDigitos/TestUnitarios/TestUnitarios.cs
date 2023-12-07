using Entidades;
namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(1, 1)]
        [DataRow(9, 1)]
        [DataRow(10, 2)]
        [DataRow(100, 3)]
        [DataRow(1000, 4)]

        public void Al_InvocarAlMetodoDeInstanciaDeInt_DeberiaObtener_LaCantidadDeDigitosDelNumero(int numero, int valorEsperado)
        {
            int resultado = numero.ObtenerCantidadDigitos();
            Assert.AreEqual(resultado, valorEsperado);
        }

    }
}