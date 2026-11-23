namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD3_Decorator;

public class EscudoLegendario : HabilidadDecorator
{
    public EscudoLegendario(IPersonaje personaje)
        : base(personaje)
    {
    }

    public override string Descripcion()
    {
        return personaje.Descripcion() + " + Escudo Legendario";
    }

    public override int Poder()
    {
        return personaje.Poder() + 8;
    }
}