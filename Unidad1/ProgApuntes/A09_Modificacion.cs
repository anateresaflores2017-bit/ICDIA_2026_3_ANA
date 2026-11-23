namespace AppsPortafolioEvidencias.Apuntes;

public class A09_Modificacion
{
    public void Ejecutar()
    {
        A06_Dataset a = new A06_Dataset
        {
            Id = 1,
            Nombre = "Iris",
            NumeroInstancias = 150
        };

        A06_Dataset b = a;
        b.Nombre = "Iris modificacion";

        Console.WriteLine(a.Nombre);
    }
}

    

