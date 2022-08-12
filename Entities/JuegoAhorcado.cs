using System;
using System.Collections.Generic;
using Ahorcado.Entities.Auxiliares;

namespace Ahorcado.Entities
{
    public static class JuegoAhorcado
    {
        static PartidaAhorcado PartidaActual;
        static List<PartidaAhorcado> _Partidas = new List<PartidaAhorcado>();

        public static PartidaAhorcado GetPartidaActual
        {
            get
            {
                return PartidaActual;
            }
        }

        public static List<PartidaAhorcado> GetPartidas
        {
            get
            {
                return _Partidas;
            }
        }

        public static void Inicializar()
        {
            PartidaActual = new PartidaAhorcado(Palabras.PalabraAleatoria());
            _Partidas.Add(PartidaActual);
        }

        public static void Inicializar(string palabra)
        {
            PartidaActual = new PartidaAhorcado(palabra);
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