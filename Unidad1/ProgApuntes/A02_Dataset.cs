 namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad1.ProgsApuntes;


     public class A02_Dataset
{
    private int id;
    private string nombre;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public void MostrarInformacion()

    {

        Console.WriteLine($" {nombre}");

    }
}

