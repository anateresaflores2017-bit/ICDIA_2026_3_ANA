using System;

namespace MachineLearning
{
    public class AlgoritmoML : IComparable<AlgoritmoML>, IComparable
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Complejidad { get; set; }

        // Constructor vacío
        public AlgoritmoML()
        {
            Id = 0;
            Nombre = string.Empty;
            Tipo = string.Empty;
            Complejidad = string.Empty;
        }

        // Constructor por identificador
        public AlgoritmoML(int id)
        {
            Id = id;
            Nombre = string.Empty;
            Tipo = string.Empty;
            Complejidad = string.Empty;
        }

        // Constructor completo
        public AlgoritmoML(int id, string nombre, string tipo, string complejidad)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Complejidad = complejidad;
        }

        // IComparable<AlgoritmoML>: ordena por Nombre
        public int CompareTo(AlgoritmoML? otro)
        {
            if (otro is null) return 1;
            return string.Compare(Nombre, otro.Nombre, StringComparison.CurrentCultureIgnoreCase);
        }

        // IComparable (versión no genérica)
        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;
            if (obj is not AlgoritmoML otro)
                throw new ArgumentException("El objeto no es de tipo AlgoritmoML.", nameof(obj));
            return CompareTo(otro);
        }

        // Método virtual (polimorfismo)
        public virtual void Entrenar()
        {
            Console.WriteLine("Entrenamiento generico");
        }

        // ToString
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Tipo: {Tipo}, Complejidad: {Complejidad}";
        }
    }
}