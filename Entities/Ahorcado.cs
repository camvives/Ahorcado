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
            switch (PartidaActual.Estado)
            {
                case PartidaAhorcado.Estados.Jugando:
                    return PartidaActual.RealizarIntento(letra);
                default:
                    return false;
            }
        }
    }
}