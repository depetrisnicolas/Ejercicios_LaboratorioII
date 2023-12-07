using CentralitaHerencia;
using CentralitaHerencia.excepciones;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void AlCrearUnNuevoObjetoDelTipoCentralita_SeDebeInstanciar_UnaListaDeLlamadasDeEsta()
        {
            //Arrange
            List<Llamada> valorEsperado = new List<Llamada>();

            //Act
            List<Llamada> resultado = ValidaCreacionListaAlInstanciar();

            //Assert
            CollectionAssert.AreEqual(resultado, valorEsperado);

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AlIntentarCargarUnaSegundaLlamadaLocal_ConLosMismosDatosDeOrigenYDestino_ProducirUnError()
        {
            Centralita unaCentralita = new Centralita("Telecom");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);

            unaCentralita += l1;
            unaCentralita += l1;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AlIntentarCargarUnaSegundaLlamadaProvincial_ConLosMismosDatosDeOrigenYDestino_ProducirUnError()
        {
            Centralita unaCentralita = new Centralita("Telecom");
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");

            unaCentralita += l2;
            unaCentralita += l2;
        }

        [TestMethod]
        public void NoEntiendoElEnunciado()
        {
            Local l3 = new Local("Quilmes", 15, "Chaco", 2.15f);
            Local l4 = new Local("Quilmes", 15, "Chaco", 2.15f);
            Provincial l5 = new Provincial("Quilmes", Provincial.Franja.Franja_1, 40, "Chaco");
            Provincial l6 = new Provincial("Quilmes", Provincial.Franja.Franja_1, 40, "Chaco");
        }

        public List<Llamada> ValidaCreacionListaAlInstanciar()
        {
            Centralita nuevaCentralita = new Centralita("Telefonica");
            
            return nuevaCentralita.Llamadas;
        }

        


    }
}