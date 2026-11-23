namespace AppsPortafolioEvidencias.Apuntes;

public class A08_Precision
{
    private double a08_precision;

    public double Precision
    {
        get => a08_precision;
        set
        {
            if (!double.IsFinite(value) || value < 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "La precisión debe estar entre 0 y 1.");
            }

            a08_precision = value;
        }
    }

    public void Ejecutar()
    {
        A06_Dataset iris = new A06_Dataset
        {
            Id = 1,
            Nombre = "Iris",
            NumeroInstancias = 150
        };
        iris.MostrarInformacion();

        Precision = 0.95;
        Console.WriteLine($"Precisión del modelo: {Precision:P0}");
    }
}