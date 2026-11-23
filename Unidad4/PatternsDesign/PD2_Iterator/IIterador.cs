namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD2_Iterator;

public interface IIterador
{
    bool TieneSiguiente();
    Alumno Siguiente();
}