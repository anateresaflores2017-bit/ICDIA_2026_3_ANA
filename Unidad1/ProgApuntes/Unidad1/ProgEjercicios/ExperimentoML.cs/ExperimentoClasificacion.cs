using System;

namespace ProyectoExperimentos
{
    public class ExperimentoClasificacion : ExperimentoML
    {
        private double _exactitud;

        // Métrica particular: exactitud (accuracy), entre 0 y 1
        public double Exactitud
        {
            get { return _exactitud; }
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentOutOfRangeException(nameof(Exactitud), value,
                        "La exactitud debe estar entre 0 y 1.");
                _exactitud = value;
            }
        }

        // Constructor vacío
        public ExperimentoClasificacion() : base()
        {
            _exactitud = 0;
        }

        // Constructor por identificador
        public ExperimentoClasificacion(int id) : base(id)
        {
            _exactitud = 0;
        }

        // Constructor completo
        public ExperimentoClasificacion(int id, string nombre, string algoritmo,
                                        DateTime fecha, double tiempoEjecucion, double exactitud)
            : base(id, nombre, algoritmo, fecha, tiempoEjecucion)
        {
            Exactitud = exactitud;
        }

        public override void Ejecutar()
        {
            Console.WriteLine($"Ejecutando experimento de CLASIFICACION '{Nombre}' con {Algoritmo}...");
            Simular();
            Exactitud = Math.Round(0.70 + Aleatorio.NextDouble() * 0.29, 4);
            Console.WriteLine($"Terminado en {TiempoEjecucion:F2} s. Exactitud obtenida: {Exactitud:P2}");
        }

        public override string ToString()
        {
            return $"[Clasificacion] {base.ToString()} | Exactitud: {Exactitud:P2}";
        }
    }
}