using System;
using System.Collections.Generic;

namespace ProyectoExperimentos
{
    public class Programa
    {
        private static readonly List<ExperimentoML> experimentos = new List<ExperimentoML>();

        public static void Main(string[] args)
        {
            CargarDatosIniciales();

            bool salir = false;
            while (!salir)
            {
                MostrarMenu();
                int opcion = LeerEntero("Opcion: ");

                switch (opcion)
                {
                    case 1: Registrar(); break;
                    case 2: MostrarExperimentos(); break;
                    case 3: BuscarPorId(); break;
                    case 4: Eliminar(); break;
                    case 5: Ordenar(); break;
                    case 6: EjecutarExperimento(); break;
                    case 7:
                        salir = true;
                        Console.WriteLine("Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida.");
                        break;
                }
            }
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("\n===== EXPERIMENTOS DE MACHINE LEARNING =====");
            Console.WriteLine("1. Registrar experimento");
            Console.WriteLine("2. Mostrar experimentos");
            Console.WriteLine("3. Buscar por identificador");
            Console.WriteLine("4. Eliminar experimento");
            Console.WriteLine("5. Ordenar experimentos");
            Console.WriteLine("6. Ejecutar experimento");
            Console.WriteLine("7. Salir");
        }

        private static void CargarDatosIniciales()
        {
            experimentos.Add(new ExperimentoClasificacion(1, "Spam vs No spam", "Naive Bayes",
                new DateTime(2026, 11, 10, 9, 30, 0), 1.25, 0.91));
            experimentos.Add(new ExperimentoClasificacion(2, "Deteccion de fraude", "Random Forest",
                new DateTime(2026, 11, 12, 14, 0, 0), 3.40, 0.87));
            experimentos.Add(new ExperimentoRegresion(3, "Precio de casas", "Regresion Lineal",
                new DateTime(2026, 11, 8, 11, 15, 0), 0.80, 2.35));
        }

        // 1. Registrar
        private static void Registrar()
        {
            Console.WriteLine("\nTipo de experimento:");
            Console.WriteLine("1. Clasificacion");
            Console.WriteLine("2. Regresion");
            int tipo = LeerEntero("Tipo: ");

            if (tipo != 1 && tipo != 2)
            {
                Console.WriteLine("Tipo no valido.");
                return;
            }

            int id = LeerEntero("Id: ");
            string nombre = LeerTexto("Nombre: ");
            string algoritmo = LeerTexto("Algoritmo: ");

            ExperimentoML nuevo = tipo == 1
                ? new ExperimentoClasificacion(id, nombre, algoritmo, DateTime.Now, 0, 0)
                : new ExperimentoRegresion(id, nombre, algoritmo, DateTime.Now, 0, 0);

            // Contains usa Equals(): no se permiten Ids repetidos
            if (experimentos.Contains(nuevo))
            {
                Console.WriteLine("Ya existe un experimento con ese Id.");
                return;
            }

            experimentos.Add(nuevo);
            Console.WriteLine("Experimento registrado. Usa la opcion 6 para ejecutarlo.");
        }

        // 2. Mostrar
        private static void MostrarExperimentos()
        {
            Console.WriteLine($"\n--- Experimentos ({experimentos.Count}) ---");
            if (experimentos.Count == 0)
            {
                Console.WriteLine("No hay experimentos registrados.");
                return;
            }

            foreach (ExperimentoML e in experimentos)
                Console.WriteLine(e);
        }

        // 3. Buscar
        private static void BuscarPorId()
        {
            int id = LeerEntero("Id a buscar: ");
            ExperimentoML? encontrado = experimentos.Find(e => e.Equals(new ExperimentoML(id)));

            Console.WriteLine(encontrado is not null
                ? $"Encontrado: {encontrado}"
                : "No se encontro un experimento con ese Id.");
        }

        // 4. Eliminar
        private static void Eliminar()
        {
            int id = LeerEntero("Id a eliminar: ");
            bool eliminado = experimentos.Remove(new ExperimentoML(id)); // usa Equals()

            Console.WriteLine(eliminado
                ? "Experimento eliminado."
                : "No se encontro un experimento con ese Id.");
        }

        // 5. Ordenar
        private static void Ordenar()
        {
            Console.WriteLine("\nOrdenar por:");
            Console.WriteLine("1. Nombre (CompareTo)");
            Console.WriteLine("2. Fecha (IComparer)");
            Console.WriteLine("3. Tiempo de ejecucion (IComparer)");
            int criterio = LeerEntero("Criterio: ");

            switch (criterio)
            {
                case 1: experimentos.Sort(); break;
                case 2: experimentos.Sort(new ComparadorPorFecha()); break;
                case 3: experimentos.Sort(new ComparadorPorTiempo()); break;
                default:
                    Console.WriteLine("Criterio no valido.");
                    return;
            }

            Console.WriteLine("Experimentos ordenados.");
            MostrarExperimentos();
        }

        // 6. Ejecutar (polimorfismo)
        private static void EjecutarExperimento()
        {
            int id = LeerEntero("Id del experimento a ejecutar: ");
            ExperimentoML? experimento = experimentos.Find(e => e.Id == id);

            if (experimento is null)
            {
                Console.WriteLine("No se encontro un experimento con ese Id.");
                return;
            }

            experimento.Ejecutar(); // se ejecuta el override de la clase real
        }

        // Utilidades de lectura
        private static string LeerTexto(string mensaje)
        {
            Console.Write(mensaje);
            return Console.ReadLine() ?? string.Empty;
        }

        private static int LeerEntero(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out int valor))
                    return valor;
                Console.WriteLine("Ingresa un numero entero valido.");
            }
        }
    }
}