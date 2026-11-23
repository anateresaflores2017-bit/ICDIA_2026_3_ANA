namespace AppsPortafolioEvidencias.Apuntes;

public class A07_Nombre
{
    private string nombre = string.Empty;

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Ejecutar()
    {
        Console.Write("Escribe tu nombre: ");
        string? nombreIngresado = Console.ReadLine();
        if (nombreIngresado is null)
        {
            Console.WriteLine("No se recibió el nombre.");
            return;
        }

        Nombre = nombreIngresado;
        Console.WriteLine($"Nombre: {Nombre}");
    }
}
