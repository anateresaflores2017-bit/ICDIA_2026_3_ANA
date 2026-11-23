namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD2_Iterator;

public class IteradorAlumnos : IIterador
{
    private ColeccionAlumnos coleccion;
    private int posicion = 0;

    public IteradorAlumnos(ColeccionAlumnos coleccion)
    {
        this.coleccion = coleccion;
    }

    public bool TieneSiguiente()
    {
        return posicion < coleccion.Cantidad;
    }

    public Alumno Siguiente()
    {
        return coleccion.ObtenerAlumno(posicion++);
    }
}