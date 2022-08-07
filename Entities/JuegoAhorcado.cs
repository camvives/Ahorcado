using System.Collections.Generic;

namespace Ahorcado.Entities
{
    public static class JuegoAhorcado
    {
        static PartidaAhorcado PartidaActual;
        static List<PartidaAhorcado> _Partidas;

        public static PartidaAhorcado getPartidaActual
        {
            get
            {
                return PartidaActual;
            }
        }

        static JuegoAhorcado()
        {
            _Partidas = new List<PartidaAhorcado>();
        }

        public static void Inicializar()
        {
            PartidaActual = new PartidaAhorcado("Ahorcado");
            _Partidas.Add(PartidaActual);
        }

        public static bool IntentarLetra(string letra)
        {
            if(PartidaActual.Estado == PartidaAhorcado.Estados.Jugando)
            {
                return PartidaActual.RealizarIntento(letra);
            }
            else
            {
                return false;
            }
        }

        public static bool IntentarPalabra(string palabra)
        {
            if (PartidaActual.Estado == PartidaAhorcado.Estados.Jugando)
            {
                return PartidaActual.IntentarPalabra(palabra);
            }
            else
            {
                return false;
            }
                
        }

        public static int GetPartidasTotales()
        {
            return _Partidas.Count;
        }

        public static int GetPartidasGanadas()
        {
            return _Partidas.FindAll(p => p.Estado == PartidaAhorcado.Estados.Ganada).Count;
        }
        
        public static int GetPartidasPerdidas()
        {
            return _Partidas.FindAll(p => p.Estado == PartidaAhorcado.Estados.Perdida).Count;
        }

    }
}