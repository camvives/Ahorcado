using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado.Entities.Auxiliares
{
    public static class Palabras
    {
        private static readonly string[] palabras =
        {
            "AGILES",
            "AHORCADO",
            "MESA",
            "CASA"
        };

        public static string PalabraAleatoria()
        {
            Random rnd = new Random();
            int nroAleatorio = rnd.Next(palabras.Length);
            return palabras[nroAleatorio];
        }
    }
}
