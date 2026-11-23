namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD2_Iterator;

public class UsoIterator
{
    public UsoIterator()
    {
        ColeccionAlumnos alumnos = new ColeccionAlumnos(5);

        alumnos.AgregarAlumno(new Alumno("Alumno 1", 18));
        alumnos.AgregarAlumno(new Alumno("Alumno 2", 22));
        alumnos.AgregarAlumno(new Alumno("Alumno 3", 19));
        alumnos.AgregarAlumno(new Alumno("Alumno 4", 20));

        IIterador iterador = alumnos.CrearIterador();

        while (iterador.TieneSiguiente())
        {
            Alumno alumno = iterador.Siguiente();
            Console.WriteLine(alumno);
        }
        
    }
}