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
            return palabras[RandomNumberGenerator.GetInt32(palabras.Length)];
        }
    }
}
