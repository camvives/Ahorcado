using System.Collections.Generic;

namespace Ahorcado.Entities
{
    public class Ahorcado
    {
        PartidaAhorcado PartidaActual;
        List<PartidaAhorcado> _Partidas;

        public Ahorcado()
        {
            _Partidas = new List<PartidaAhorcado>();
        }

        public void Inicializar()
        {
            PartidaActual = new PartidaAhorcado("Casa");
        }

        public bool IntentarLetra(string letra)
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

        public bool IntentarPalabra(string palabra)
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
    }
}