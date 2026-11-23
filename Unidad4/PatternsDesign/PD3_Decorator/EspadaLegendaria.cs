namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD3_Decorator;

public class EspadaLegendaria : HabilidadDecorator
{
    public EspadaLegendaria(IPersonaje personaje)
        : base(personaje)
    {
    }

    public override string Descripcion()
    {
        return personaje.Descripcion() + " + Espada Legendaria";
    }

    public override int Poder()
    {
        return personaje.Poder() + 15;
    }
}