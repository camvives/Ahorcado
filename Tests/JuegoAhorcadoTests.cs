using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ahorcado.Entities;
using System;
using System.Collections.Generic;


namespace Ahorcado.Tests
{
    [TestClass]
    public class JuegoAhorcadoTests
    {
        [TestMethod]
        public void InicializarPartida_Test()
        {
            JuegoAhorcado.Inicializar();

            Assert.AreNotEqual(0, JuegoAhorcado.GetPartidas.Count);
        }

        [TestMethod]
        public void IntentarLetraCorrecta_Test()
        {
            JuegoAhorcado.Inicializar("Ahorcado");

            JuegoAhorcado.IntentarLetra("a");

            Assert.AreEqual("A", JuegoAhorcado.GetPartidaActual.LetrasAcertadas[0]);
        }

        [TestMethod]
        public void IntentarPalabraCorrecta_Test()
        {
            JuegoAhorcado.Inicializar("Ahorcado");

            JuegoAhorcado.IntentarPalabra("ahorcado");

            Assert.AreEqual(PartidaAhorcado.Estados.Ganada, JuegoAhorcado.GetPartidaActual.Estado);
        }

        [TestMethod]
        public void GetPartidasGanadas_Test()
        {
            JuegoAhorcado.Inicializar("Ahorcado");

            JuegoAhorcado.IntentarPalabra("ahorcado");

            List<PartidaAhorcado> partidasGanadasEsperadas = JuegoAhorcado.GetPartidas.FindAll(p => p.Estado == PartidaAhorcado.Estados.Ganada);

            Assert.AreEqual(partidasGanadasEsperadas.Count, JuegoAhorcado.GetPartidasGanadas());
        }

        [TestMethod]
        public void GetPartidasPerdidas_Test()
        {
            JuegoAhorcado.Inicializar("Ahorcado");

            JuegoAhorcado.IntentarPalabra("agiles");

            List<PartidaAhorcado> partidasPerdidasEsperadas = JuegoAhorcado.GetPartidas.FindAll(p => p.Estado == PartidaAhorcado.Estados.Perdida);

            Assert.AreEqual(partidasPerdidasEsperadas.Count, JuegoAhorcado.GetPartidasPerdidas());
        }

        [TestMethod]
        public void GetGanadores_Test()
        {
            JuegoAhorcado.ClearJugadores();

            JuegoAhorcado.RegistrarJugador("Jugador1");
            JuegoAhorcado.RegistrarJugador("Jugador2");

            Assert.AreEqual(JuegoAhorcado.GetGanadores(), "Jugador2, Jugador1");
        }
    }
}
