using System;

namespace ProyectoExperimentos
{
    public class ExperimentoRegresion : ExperimentoML
    {
        private double _error;

        // Métrica particular: error cuadrático medio (no puede ser negativo)
        public double ErrorCuadraticoMedio
        {
            get { return _error; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(ErrorCuadraticoMedio), value,
                        "El error cuadratico medio no puede ser negativo.");
                _error = value;
            }
        }

        // Constructor vacío
        public ExperimentoRegresion() : base()
        {
            _error = 0;
        }

        // Constructor por identificador
        public ExperimentoRegresion(int id) : base(id)
        {
            _error = 0;
        }

        // Constructor completo
        public ExperimentoRegresion(int id, string nombre, string algoritmo,
                                    DateTime fecha, double tiempoEjecucion, double errorCuadraticoMedio)
            : base(id, nombre, algoritmo, fecha, tiempoEjecucion)
        {
            ErrorCuadraticoMedio = errorCuadraticoMedio;
        }

        public override void Ejecutar()
        {
            Console.WriteLine($"Ejecutando experimento de REGRESION '{Nombre}' con {Algoritmo}...");
            Simular();
            ErrorCuadraticoMedio = Math.Round(Aleatorio.NextDouble() * 5, 4);
            Console.WriteLine($"Terminado en {TiempoEjecucion:F2} s. MSE obtenido: {ErrorCuadraticoMedio:F4}");
        }

        public override string ToString()
        {
            return $"[Regresion] {base.ToString()} | MSE: {ErrorCuadraticoMedio:F4}";
        }
    }
}
