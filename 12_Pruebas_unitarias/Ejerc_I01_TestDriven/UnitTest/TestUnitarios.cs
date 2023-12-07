using System;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class TestUnitarios
    {
        ///
        [TestMethod]
        [DataRow("", 0)]

        public void Al_InvocarAlMetodoAdd_SiSeRecibeUnStringVacio_DeberiaDevolverCero(string cadena, int valorEsperado)
        {
            int resultado = Add(cadena);
            Assert.AreEqual(resultado, valorEsperado);
        }



        [TestMethod]
        [DataRow("1", 1)]
        [DataRow("2", 2)]
        [DataRow("1,2", 3)]
        [DataRow("8,2", 10)]

        public void Al_InvocarAlMetodoAdd_SiSeRecibenHastaDosNumerosSeparadosPorComa_DeberiaDevolverLaSuma(string cadena, int valorEsperado)
        {
            int resultado = Add(cadena);
            Assert.AreEqual(resultado, valorEsperado);
        }



        [TestMethod]
        [DataRow("2,1,1", 4)]
        [DataRow("2,1,1,10", 14)]

        public void Al_InvocarAlMetodoAdd_SiSeRecibenUnaCantidadDesconocidaDeNumerosSeparadosPorComa_DeberiaDevolverLaSuma(string cadena, int valorEsperado)
        {
            int resultado = Add(cadena);
            Assert.AreEqual(resultado, valorEsperado);
        }


        [TestMethod]
        [DataRow("1 \n2,3", 6)]
        [DataRow("\n1,2", 3)]
        [DataRow("1\n8", 9)]

        public void Al_InvocarAlMetodoAdd_SiSeRecibenUnaCantidadDesconocidaDeNumerosSeparadosPorComaOSaltoDeLinea_DeberiaDevolverLaSuma(string cadena, int valorEsperado)
        {
            int resultado = Add(cadena);
            Assert.AreEqual(resultado, valorEsperado);
        }

        [TestMethod]
        [DataRow("//; \n1;2", 3)]
        [DataRow("//: \n4:3", 7)]

        public void Al_InvocarAlMetodoAdd_SiSeRecibenUnaCantidadDesconocidaDeNumerosSeparadosPorDiferentesDelimitadores_DeberiaDevolverLaSuma(string cadena, int valorEsperado)
        {
            int resultado = Add(cadena);
            Assert.AreEqual(resultado, valorEsperado);
        }



        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        [DataRow("-1")]
        [DataRow("1, -4")]

        public void AlRecibirUnNumeroNegativo_SeEspera_ObtenerUnError(string cadena)
        {
            int resultado = Add(cadena);
        }


        //FUNCION DESARROLLADA
        public static int Add(string numeros)
        {
            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }
            else
            {
                char[] delimiters;

                if (numeros[0] == '/' && numeros[1] == '/')
                {
                    delimiters = new char[] { ',', '\n', numeros[2] };
                }
                else
                {
                    delimiters = new char[] { ',', '\n'};
                }
                
                string[] partes = numeros.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                int suma = 0;

                foreach (string parte in partes) 
                {
                    if (int.TryParse(parte, out int valor))
                    {
                        if (valor < 0)
                        {
                            throw new NegativoNoPermitidoException($"Se recibió un número negativo: {valor}");
                        }
                        else
                        {
                            suma += valor;
                        }
                    }
                }
                return suma;
            }
        }
    }
}