namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD2_Iterator;

public class ColeccionAlumnos: IColeccion
{
    private Alumno[] alumnos;
    private int cantidad = 0;

    public ColeccionAlumnos(int tamaño)
    {
        alumnos = new Alumno[tamaño];
    }

    public void AgregarAlumno(Alumno alumno)
    {
        if (cantidad < alumnos.Length)
        {
            alumnos[cantidad] = alumno;
            cantidad++;
        }
    }

    public Alumno ObtenerAlumno(int indice)
    {
        return alumnos[indice];
    }

    public int Cantidad
    {
        get { return cantidad; }
    }

    public IIterador CrearIterador()
    {
        return new IteradorAlumnos(this);
    }
}
