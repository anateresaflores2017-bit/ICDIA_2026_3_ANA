

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad1.ProgsApuntes;

public class A03_Estudiante
{
    public string Matricula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public double Promedio { get; set; }

    public bool EstaAprobado()
    {
        return Promedio >= 6.0;
    }

    public void Ejecutar()
    {
        Console.Write("Matrícula: ");
        string? matricula = Console.ReadLine();
        if (matricula is null)
        {
            Console.WriteLine("No se recibió la matrícula.");
            return;
        }

        Console.Write("Nombre: ");
        string? nombre = Console.ReadLine();
        if (nombre is null)
        {
            Console.WriteLine("No se recibió el nombre.");
            return;
        }

        Console.Write("Promedio: ");
        if (!double.TryParse(Console.ReadLine(), out double promedio))
        {
            Console.WriteLine("El promedio no es válido.");
            return;
        }

        Matricula = matricula;
        Nombre = nombre;
        Promedio = promedio;

        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Promedio: {Promedio}");
        Console.WriteLine(EstaAprobado() ? "Aprobado" : "No aprobado");
    }
}

