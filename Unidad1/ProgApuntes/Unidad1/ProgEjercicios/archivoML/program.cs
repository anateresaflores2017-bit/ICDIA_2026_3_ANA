using System;
using MachineLearning;

AdministradorModelos admin = new();

// Datos iniciales
admin.Agregar(new AlgoritmoClasificacion(1, "Naive Bayes", "Supervisado", "O(n)", 3, true));
admin.Agregar(new AlgoritmoClasificacion(2, "Random Forest", "Supervisado", "O(n log n)", 5, true));
admin.Agregar(new AlgoritmoRegresion(3, "Ridge", "Supervisado", "O(n^2)", "L2", 10));
admin.Agregar(new AlgoritmoRegresion(4, "Lasso", "Supervisado", "O(n^2)", "L1", 8));

string LeerTexto(string mensaje)
{
    Console.Write(mensaje);
    return Console.ReadLine() ?? string.Empty;
}

int LeerEntero(string mensaje)
{
    while (true)
    {
        Console.Write(mensaje);
        if (int.TryParse(Console.ReadLine(), out int valor))
            return valor;
        Console.WriteLine("Ingresa un numero entero valido.");
    }
}

void MostrarMenu()
{
    Console.WriteLine("\n===== ADMINISTRADOR DE MODELOS ML =====");
    Console.WriteLine("1. Crear modelo de clasificacion");
    Console.WriteLine("2. Crear modelo de regresion");
    Console.WriteLine("3. Mostrar modelos");
    Console.WriteLine("4. Buscar modelo por Id");
    Console.WriteLine("5. Eliminar modelo");
    Console.WriteLine("6. Ordenar por nombre");
    Console.WriteLine("7. Ordenar por complejidad");
    Console.WriteLine("8. Entrenar todos (polimorfismo)");
    Console.WriteLine("0. Salir");
}

bool salir = false;
while (!salir)
{
    MostrarMenu();
    int opcion = LeerEntero("Opcion: ");

    switch (opcion)
    {
        case 1:
        {
            int id = LeerEntero("Id: ");
            string nombre = LeerTexto("Nombre: ");
            string tipo = LeerTexto("Tipo: ");
            string complejidad = LeerTexto("Complejidad (ej. O(n log n)): ");
            int clases = LeerEntero("Numero de clases: ");
            string prob = LeerTexto("Es probabilistico? (s/n): ");

            var modelo = new AlgoritmoClasificacion(id, nombre, tipo, complejidad,
                clases, prob.Trim().ToLower() == "s");

            Console.WriteLine(admin.Agregar(modelo)
                ? "Modelo agregado."
                : "Ya existe un modelo con ese Id.");
            break;
        }
        case 2:
        {
            int id = LeerEntero("Id: ");
            string nombre = LeerTexto("Nombre: ");
            string tipo = LeerTexto("Tipo: ");
            string complejidad = LeerTexto("Complejidad (ej. O(n^2)): ");
            string regularizacion = LeerTexto("Regularizacion (Ninguna/L1/L2): ");
            int variables = LeerEntero("Numero de variables: ");

            var modelo = new AlgoritmoRegresion(id, nombre, tipo, complejidad,
                regularizacion, variables);

            Console.WriteLine(admin.Agregar(modelo)
                ? "Modelo agregado."
                : "Ya existe un modelo con ese Id.");
            break;
        }
        case 3:
            Console.WriteLine($"\n--- Modelos ({admin.Cantidad}) ---");
            admin.Mostrar();
            break;
        case 4:
        {
            int id = LeerEntero("Id a buscar: ");
            AlgoritmoML? encontrado = admin.Buscar(id);
            Console.WriteLine(encontrado is not null
                ? $"Encontrado: {encontrado}"
                : "No se encontro un modelo con ese Id.");
            break;
        }
        case 5:
        {
            int id = LeerEntero("Id a eliminar: ");
            Console.WriteLine(admin.Eliminar(id)
                ? "Modelo eliminado."
                : "No se encontro un modelo con ese Id.");
            break;
        }
        case 6:
            admin.OrdenarPorNombre();
            Console.WriteLine("Ordenado por nombre.");
            admin.Mostrar();
            break;
        case 7:
            admin.OrdenarPorComplejidad();
            Console.WriteLine("Ordenado por complejidad.");
            admin.Mostrar();
            break;
        case 8:
            Console.WriteLine("\n--- Entrenamiento ---");
            admin.EntrenarTodos();
            break;
        case 0:
            salir = true;
            Console.WriteLine("Hasta luego.");
            break;
        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }
}