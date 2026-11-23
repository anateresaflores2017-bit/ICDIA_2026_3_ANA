using System;
using System.Collections.Generic;

namespace MachineLearning
{
    public class AdministradorModelos
    {
        private readonly List<AlgoritmoML> _modelos = new();

        public int Cantidad => _modelos.Count;

        // Agregar: no permite Ids repetidos
        public bool Agregar(AlgoritmoML modelo)
        {
            if (modelo is null) throw new ArgumentNullException(nameof(modelo));
            if (Buscar(modelo.Id) is not null) return false;

            _modelos.Add(modelo);
            return true;
        }

        // Buscar por identificador
        public AlgoritmoML? Buscar(int id)
        {
            return _modelos.Find(m => m.Id == id);
        }

        // Eliminar por identificador
        public bool Eliminar(int id)
        {
            return _modelos.RemoveAll(m => m.Id == id) > 0;
        }

        // Ordenar por nombre (usa IComparable de AlgoritmoML)
        public void OrdenarPorNombre()
        {
            _modelos.Sort();
        }

        // Ordenar por complejidad (usa IComparer)
        public void OrdenarPorComplejidad()
        {
            _modelos.Sort(new ComparadorPorComplejidad());
        }

        // Mostrar los datos de todos los modelos
        public void Mostrar()
        {
            if (_modelos.Count == 0)
            {
                Console.WriteLine("No hay modelos registrados.");
                return;
            }

            foreach (AlgoritmoML modelo in _modelos)
                Console.WriteLine(modelo);
        }

        // Método polimórfico: cada modelo ejecuta su propio Entrenar()
        public void EntrenarTodos()
        {
            if (_modelos.Count == 0)
            {
                Console.WriteLine("No hay modelos para entrenar.");
                return;
            }

            foreach (AlgoritmoML modelo in _modelos)
                modelo.Entrenar();
        }
    }
}