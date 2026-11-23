using System;
using System.Diagnostics;
using System.Threading;

namespace ProyectoExperimentos
{
    public class ExperimentoML : IComparable<ExperimentoML>, IComparable
    {
        protected static readonly Random Aleatorio = new Random();

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Algoritmo { get; set; }
        public DateTime Fecha { get; set; }
        public double TiempoEjecucion { get; set; } // en segundos

        // Constructor vacío
        public ExperimentoML()
        {
            Id = 0;
            Nombre = string.Empty;
            Algoritmo = string.Empty;
            Fecha = DateTime.Now;
            TiempoEjecucion = 0;
        }

        // Constructor por identificador
        public ExperimentoML(int id) : this()
        {
            Id = id;
        }

        // Constructor completo
        public ExperimentoML(int id, string nombre, string algoritmo, DateTime fecha, double tiempoEjecucion)
        {
            Id = id;
            Nombre = nombre;
            Algoritmo = algoritmo;
            Fecha = fecha;
            TiempoEjecucion = tiempoEjecucion;
        }

        // Método virtual: las clases derivadas lo sobrescriben
        public virtual void Ejecutar()
        {
            Console.WriteLine($"Ejecutando experimento generico '{Nombre}' con {Algoritmo}...");
            Simular();
            Console.WriteLine($"Terminado en {TiempoEjecucion:F2} s.");
        }

        // Simula el trabajo del experimento y registra fecha y tiempo
        protected void Simular()
        {
            Stopwatch reloj = Stopwatch.StartNew();
            Thread.Sleep(Aleatorio.Next(200, 600));
            reloj.Stop();

            Fecha = DateTime.Now;
            TiempoEjecucion = reloj.Elapsed.TotalSeconds;
        }

        // Dos experimentos son iguales si tienen el mismo Id
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is ExperimentoML otro && Id == otro.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // Orden natural: por nombre
        public int CompareTo(ExperimentoML? otro)
        {
            if (otro is null) return 1;
            return string.Compare(Nombre, otro.Nombre, StringComparison.CurrentCultureIgnoreCase);
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;
            if (obj is not ExperimentoML otro)
                throw new ArgumentException("El objeto no es de tipo ExperimentoML.", nameof(obj));
            return CompareTo(otro);
        }

        public override string ToString()
        {
            return $"Id: {Id} | Nombre: {Nombre} | Algoritmo: {Algoritmo} | " +
                   $"Fecha: {Fecha:yyyy-MM-dd HH:mm} | Tiempo: {TiempoEjecucion:F2} s";
        }
    }
}