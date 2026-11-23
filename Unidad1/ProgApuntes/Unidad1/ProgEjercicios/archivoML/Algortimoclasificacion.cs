using System;

namespace MachineLearning
{
    public class AlgoritmoClasificacion : AlgoritmoML
    {
        // Propiedades particulares
        public int NumeroClases { get; set; }
        public bool EsProbabilistico { get; set; }

        // Constructor vacío
        public AlgoritmoClasificacion() : base()
        {
            NumeroClases = 2;
            EsProbabilistico = false;
        }

        // Constructor por identificador
        public AlgoritmoClasificacion(int id) : base(id)
        {
            NumeroClases = 2;
            EsProbabilistico = false;
        }

        // Constructor completo
        public AlgoritmoClasificacion(int id, string nombre, string tipo, string complejidad,
                                      int numeroClases, bool esProbabilistico)
            : base(id, nombre, tipo, complejidad)
        {
            NumeroClases = numeroClases;
            EsProbabilistico = esProbabilistico;
        }

        public override void Entrenar()
        {
            Console.WriteLine($"Entrenando {Nombre} para clasificar en {NumeroClases} clases");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Clases: {NumeroClases}, Probabilístico: {EsProbabilistico}";
        }
    }
}