using System;

namespace MachineLearning
{
    public class AlgoritmoRegresion : AlgoritmoML
    {
        // Propiedades particulares
        public string Regularizacion { get; set; }
        public int NumeroVariables { get; set; }

        // Constructor vacío
        public AlgoritmoRegresion() : base()
        {
            Regularizacion = "Ninguna";
            NumeroVariables = 1;
        }

        // Constructor por identificador
        public AlgoritmoRegresion(int id) : base(id)
        {
            Regularizacion = "Ninguna";
            NumeroVariables = 1;
        }

        // Constructor completo
        public AlgoritmoRegresion(int id, string nombre, string tipo, string complejidad,
                                  string regularizacion, int numeroVariables)
            : base(id, nombre, tipo, complejidad)
        {
            Regularizacion = regularizacion;
            NumeroVariables = numeroVariables;
        }

        public override void Entrenar()
        {
            Console.WriteLine($"Entrenando {Nombre} para predecir un valor continuo con {NumeroVariables} variables");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Regularización: {Regularizacion}, Variables: {NumeroVariables}";
        }
    }
}