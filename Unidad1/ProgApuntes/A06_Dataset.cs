namespace AppsPortafolioEvidencias.Apuntes;

public class A06_Dataset
{
    private int id;
    private string nombre = string.Empty;
    private int numeroInstancias;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NumeroInstancias
    {
        get => numeroInstancias;
        set => numeroInstancias = value;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Número de instancias: {NumeroInstancias}");
    }
}

 
