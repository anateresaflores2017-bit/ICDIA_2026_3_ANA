namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD2_Iterator;

public class Alumno
{
    private string nombre;
    private int edad;
    
    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }

    public Alumno(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}";
    }

}