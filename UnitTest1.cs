using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS_shm2021;
using System;


//Estoy teniendo problemas con VS, no me comprueba cosas y no me autocompleta.

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MediaEsperada()
        {

            //Preparar

            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;

            //Probar

            EstadisticaNotas pruebashm2021 = new EstadisticaNotas();
            double media = pruebashm2021.CalcEstadisticas(notas);

            //Assert

            Assert.AreNotEqual(mediaEsperada,media,0.001,"La media no es la esperada");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]

        public void ElementosMenoroIgualQueCero()
        {
            //Preparar

            List<int> notas = new List<int>();

            //Probar

            EstadisticaNotas pruebaMenorQueCero = new EstadisticaNotas();
            double media = pruebaMenorQueCero.CalcEstadisticas(notas);

        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void ElementosMenorQueCeroYMayorQueDiez()
        {
            //Preparar

            List<int> notas = new List<int>();

            //Probar

            EstadisticaNotas pruebaMenorQueCero = new EstadisticaNotas();
            double media = pruebaMenorQueCero.CalcEstadisticas(notas);

        }

        [TestMethod]
        public void Pruebashm2021()
        {
            int susE = 3;
            int aprE = 1;
            int notE = 2;
            int sbrE = 1;


        }
    }
}
