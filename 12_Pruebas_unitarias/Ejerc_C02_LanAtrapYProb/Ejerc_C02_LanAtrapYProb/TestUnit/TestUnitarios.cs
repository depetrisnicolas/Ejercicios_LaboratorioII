using Entidades;
using Entidades.excepciones;

namespace TestUnit
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [ExpectedException (typeof (MiExcepcion))]

        public void AlInvocarAlMetodoDeInstancia_DeOtraClase_SeEsperarUnErrorDeTipoMiExcepcion()
        {
            OtraClase otraClase = new OtraClase();
            otraClase.MiMetodoDeInstancia();
        }

        [TestMethod]
        [ExpectedException (typeof (UnaExcepcion))]

        public void AlInstanciarUnObjetoMiClase_ConElConstructorSinParametros_SeEsperaUnErrorDeTipoUnaExcepcion()
        {
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]

        public void AlInstanciarUnObjetoMiClase_ConElConstructorConParametros_SeEsperaUnErrorDeTipoDivideByZeroException()
        {
            MiClase miClase = new MiClase(10);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]

        public void AlInvocarAlMetodoMiMetodoEstatico_DeMiClase_SeEsperarUnErrorDeTipoDivideByZeroException()
        {
            MiClase.MiMetodoEstatico();
        }


    }
}