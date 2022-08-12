using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

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
            var rnd = new Random();
            return palabras[rnd.Next(palabras.Length)];
        }
    }
}
