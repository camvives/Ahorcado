using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ahorcado.Entities.Auxiliares;

namespace Ahorcado.Entities
{
    public class PartidaAhorcado
    {
        private const int NUMERO_INTENTOS_MAX = 7;

        public readonly string PalabraAAdivinar;
        public int Intentos;
        public enum Estados { Jugando, Ganada, Perdida }

        public Estados Estado { get; set; }

        public List<string> LetrasAcertadas { get; set; }

        public List<string> LetrasIncorrectas { get; set; }

        public PartidaAhorcado(string palabraAAdivinar)
        {
            this.PalabraAAdivinar = palabraAAdivinar.ToUpper();
            this.Intentos = NUMERO_INTENTOS_MAX;
            this.Estado = Estados.Jugando;
            this.LetrasAcertadas = new List<string>();
            this.LetrasIncorrectas = new List<string>();
        }

        public bool RealizarIntento(string letra)
        {

            if (Validaciones.ValidarLetra(letra))
            {
                if (PalabraAAdivinar.Contains(letra))
                {
                    if (!(LetrasAcertadas.Contains(letra)))
                    {
                        LetrasAcertadas.Add(letra);
                    }
                    PartidaGanada();
                    return true;
                }
                else if (!(LetrasIncorrectas.Contains(letra)))
                {
                    LetrasIncorrectas.Add(letra);
                    Intentos--;
                }

                PartidaPerdida();
                return false;
            }
            else
            {
                //TODO: Excepcion letra invalida
                return false;
            }
        }

        public bool IntentarPalabra(string palabra)
        {
            if(PalabraAAdivinar == palabra)
            {
                Estado = Estados.Ganada;
                return true;
            }
            else
            {
                Estado = Estados.Perdida;
                Intentos = 0;
                return false;
            }
        }

        private void PartidaGanada()
        {
            foreach (char letra in PalabraAAdivinar)
            {
                if (!LetrasAcertadas.Contains(letra.ToString()))
                {
                    return;
                }
            }
            Estado = Estados.Ganada;
        }

        private void PartidaPerdida()
        {
            if (this.Intentos == 0)
                Estado = Estados.Perdida;
        }
    }
}
