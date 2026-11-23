using System;
using System.Collections.Generic;

namespace ProyectoExperimentos
{
    // Ordena por fecha (del más antiguo al más reciente)
    public class ComparadorPorFecha : IComparer<ExperimentoML>
    {
        public int Compare(ExperimentoML? x, ExperimentoML? y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x is null) return -1;
            if (y is null) return 1;
            return x.Fecha.CompareTo(y.Fecha);
        }
    }

    // Ordena por tiempo de ejecución (del más rápido al más lento)
    public class ComparadorPorTiempo : IComparer<ExperimentoML>
    {
        public int Compare(ExperimentoML? x, ExperimentoML? y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x is null) return -1;
            if (y is null) return 1;
            return x.TiempoEjecucion.CompareTo(y.TiempoEjecucion);
        }
    }
}