namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD3_Decorator;

public class Guerrero : IPersonaje
{
    public string Descripcion()
    {
        return "Guerrero";
    }

    public int Poder()
    {
        return 10;
    }
}