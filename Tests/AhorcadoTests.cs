using Ahorcado.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace Ahorcado.Tests
{
    [TestClass]
    public class AhorcadoTests
    {
        private PartidaAhorcado ahorcado = new PartidaAhorcado("CASA");

        [TestMethod]
        public void PalabraSeleccionada_Test()
        {
            string palabraEsperada = "CASA";
            Assert.AreEqual(palabraEsperada, ahorcado.PalabraAAdivinar);
        }

        [TestMethod]
        public void IngresaUnaSolaLetra_Test()
        {
            bool letraValida = ahorcado.RealizarIntento("A");
            Assert.AreEqual(true, letraValida);
        }

        [TestMethod]
        public void RestarIntento_Test()
        {
            ahorcado.RealizarIntento("T");
            Assert.AreEqual(6, ahorcado.Intentos);
        }

        [TestMethod]
        public void SeEncuentraEnPalabra_Test()
        {
            bool resultado = ahorcado.RealizarIntento("A");
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void NoSeEncuentraEnPalabra_Test()
        {
            bool resultado = ahorcado.RealizarIntento("H");
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void PalabraCompleta_Test()
        {
            ahorcado.RealizarIntento("C");
            ahorcado.RealizarIntento("A");
            ahorcado.RealizarIntento("S");

            Assert.AreEqual(PartidaAhorcado.Estados.Ganada, ahorcado.Estado);
        }

        [TestMethod]
        public void GuardaLetraValida_Test()
        {
            ahorcado.RealizarIntento("C");

            Assert.AreEqual("C", ahorcado.LetrasAcertadas[0]);
        }

        [TestMethod]
        public void GuardaLetraInvalida_Test()
        {
            ahorcado.RealizarIntento("J");

            Assert.AreEqual("J", ahorcado.LetrasIncorrectas[0]);
        }

        [TestMethod]
        public void ComprobarEstado_Test()
        {
            ahorcado.RealizarIntento("B");
            ahorcado.RealizarIntento("D");
            ahorcado.RealizarIntento("E");
            ahorcado.RealizarIntento("F");
            ahorcado.RealizarIntento("G");
            ahorcado.RealizarIntento("H");
            ahorcado.RealizarIntento("I");
            ahorcado.RealizarIntento("J");
            ahorcado.RealizarIntento("K");
            ahorcado.RealizarIntento("L");
            ahorcado.RealizarIntento("M");

            Assert.AreEqual(PartidaAhorcado.Estados.Perdida, ahorcado.Estado);
        }

        [TestMethod]
        public void IngresarMismaLetraAcertada_Test()
        {
            ahorcado.RealizarIntento("A");
            ahorcado.RealizarIntento("A");

            Assert.AreEqual(1, ahorcado.LetrasAcertadas.Count);          
        }

        [TestMethod]
        public void IngresarMismaLetraIncorrecta_Test()
        {
            ahorcado.RealizarIntento("J");
            ahorcado.RealizarIntento("J");

            Assert.AreEqual(1, ahorcado.LetrasIncorrectas.Count);
        }

        [TestMethod]
        public void IngresarPalabraCorrecta_Test()
        {
            ahorcado.IntentarPalabra("CASA");

            Assert.AreEqual(ahorcado.Estado, PartidaAhorcado.Estados.Ganada);
        }

        [TestMethod]
        public void IngresarPalabraIncorrecta_Test()
        {
            ahorcado.IntentarPalabra("MESA");

            Assert.AreEqual(ahorcado.Estado, PartidaAhorcado.Estados.Perdida);
        }

        [TestMethod]
        public void IntentarLetraCorrecta_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            Assert.AreEqual(ahorcadoClase.IntentarLetra("C"), true);
        }

        [TestMethod]
        public void IntentarLetraIncorrecta_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            Assert.AreEqual(ahorcadoClase.IntentarLetra("J"), false);
        }

        [TestMethod]
        public void IntentarPalabraCorrecta_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            Assert.AreEqual(ahorcadoClase.IntentarPalabra("CASA"), true);
        }

        [TestMethod]
        public void IntentarPalabraIncorrecta_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            Assert.AreEqual(ahorcadoClase.IntentarPalabra("MESA"), false);
        }

        [TestMethod]
        public void IntentarLetraConJuegoGanado_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            ahorcadoClase.IntentarLetra("C");
            ahorcadoClase.IntentarLetra("A");
            ahorcadoClase.IntentarLetra("S");

            Assert.AreEqual(ahorcadoClase.IntentarLetra("A"), false);
        }

        [TestMethod]
        public void IntentarPalabraConJuegoGanado_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            ahorcadoClase.IntentarLetra("C");
            ahorcadoClase.IntentarLetra("A");
            ahorcadoClase.IntentarLetra("S");

            Assert.AreEqual(ahorcadoClase.IntentarPalabra("CASA"), false);
        }

        [TestMethod]
        public void IntentarLetraConJuegoPerdido_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            ahorcadoClase.IntentarLetra("B");
            ahorcadoClase.IntentarLetra("D");
            ahorcadoClase.IntentarLetra("E");
            ahorcadoClase.IntentarLetra("F");
            ahorcadoClase.IntentarLetra("G");
            ahorcadoClase.IntentarLetra("H");
            ahorcadoClase.IntentarLetra("I");
            ahorcadoClase.IntentarLetra("J");
            ahorcadoClase.IntentarLetra("K");
            ahorcadoClase.IntentarLetra("L");
            ahorcadoClase.IntentarLetra("M");

            Assert.AreEqual(ahorcadoClase.IntentarLetra("A"), false);
        }

        public void IntentarPalabraConJuegoPerdido_Test()
        {
            Entities.Ahorcado ahorcadoClase = new Entities.Ahorcado();
            ahorcadoClase.Inicializar();

            ahorcadoClase.IntentarLetra("B");
            ahorcadoClase.IntentarLetra("D");
            ahorcadoClase.IntentarLetra("E");
            ahorcadoClase.IntentarLetra("F");
            ahorcadoClase.IntentarLetra("G");
            ahorcadoClase.IntentarLetra("H");
            ahorcadoClase.IntentarLetra("I");
            ahorcadoClase.IntentarLetra("J");
            ahorcadoClase.IntentarLetra("K");
            ahorcadoClase.IntentarLetra("L");
            ahorcadoClase.IntentarLetra("M");

            Assert.AreEqual(ahorcadoClase.IntentarLetra("CASA"), false);
        }
    }
}