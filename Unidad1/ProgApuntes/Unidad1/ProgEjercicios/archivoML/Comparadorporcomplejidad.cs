using System;
using System.Collections.Generic;

namespace MachineLearning
{
    public class ComparadorPorComplejidad : IComparer<AlgoritmoML>
    {
        // Ranking de complejidades comunes (de menor a mayor costo)
        private static readonly Dictionary<string, int> Ranking = new()
        {
            { "1", 0 },
            { "logn", 1 },
            { "n", 2 },
            { "nlogn", 3 },
            { "n^2", 4 },
            { "n²", 4 },
            { "n^3", 5 },
            { "n³", 5 },
            { "2^n", 6 },
            { "n!", 7 }
        };

        public int Compare(AlgoritmoML? x, AlgoritmoML? y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x is null) return -1;
            if (y is null) return 1;

            int rangoX = ObtenerRango(x.Complejidad);
            int rangoY = ObtenerRango(y.Complejidad);

            int resultado = rangoX.CompareTo(rangoY);

            // Si el rango es igual (o ambos son desconocidos), desempata por texto
            if (resultado == 0)
            {
                resultado = string.Compare(
                    x.Complejidad, y.Complejidad,
                    StringComparison.CurrentCultureIgnoreCase);
            }

            return resultado;
        }

        // Normaliza "O(n log n)" -> "nlogn" y busca su rango
        private static int ObtenerRango(string? complejidad)
        {
            if (string.IsNullOrWhiteSpace(complejidad))
                return int.MaxValue;

            string clave = complejidad
                .Replace(" ", "")
                .Replace("·", "")
                .ToLowerInvariant();

            if (clave.StartsWith("o(") && clave.EndsWith(")"))
                clave = clave.Substring(2, clave.Length - 3);

            return Ranking.TryGetValue(clave, out int rango) ? rango : int.MaxValue;
        }
    }
}