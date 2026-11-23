using System;
using System.Collections.Generic;
using MachineLearning;

// Lista inicial con al menos cinco algoritmos
List<AlgoritmoML> algoritmos = new List<AlgoritmoML>
{
    new AlgoritmoML(1, "Random Forest", "Supervisado", "O(n log n)"),
    new AlgoritmoML(2, "K-NN", "Supervisado", "O(n)"),
    new AlgoritmoML(3, "SVM", "Supervisado", "O(n^2)"),
    new AlgoritmoML(4, "K-Means", "No supervisado", "O(n log n)"),
    new AlgoritmoML(5, "Regresión Lineal", "Supervisado", "O(n)")
};

// 1. Agregar
Console.WriteLine("=== 1. AGREGAR ===");
var nuevo = new AlgoritmoML(6, "Red Neuronal", "Supervisado", "O(n^3)");
algoritmos.Add(nuevo);
Console.WriteLine($"Se agregó: {nuevo}");

// 2. Mostrar
Console.WriteLine("\n=== 2. MOSTRAR ===");
Mostrar(algoritmos);

// 3. Buscar (por nombre)
Console.WriteLine("\n=== 3. BUSCAR ===");
string nombreBuscado = "SVM";
AlgoritmoML? encontrado = algoritmos.Find(a =>
    a.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase));

if (encontrado != null)
    Console.WriteLine($"Encontrado: {encontrado}");
else
    Console.WriteLine($"No se encontró el algoritmo '{nombreBuscado}'.");

// 4. Eliminar (por Id)
Console.WriteLine("\n=== 4. ELIMINAR ===");
int idEliminar = 2;
int eliminados = algoritmos.RemoveAll(a => a.Id == idEliminar);
Console.WriteLine(eliminados > 0
    ? $"Se eliminó el algoritmo con Id {idEliminar}."
    : $"No existe un algoritmo con Id {idEliminar}.");

// 5. Ordenar (por complejidad, usando el IComparer)
Console.WriteLine("\n=== 5. ORDENAR (por complejidad) ===");
algoritmos.Sort(new ComparadorPorComplejidad());
Console.WriteLine("Lista ordenada.");

// 6. Volver a mostrar
Console.WriteLine("\n=== 6. VOLVER A MOSTRAR ===");
Mostrar(algoritmos);

static void Mostrar(List<AlgoritmoML> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("La lista está vacía.");
        return;
    }

    foreach (var a in lista)
        Console.WriteLine(a);
}