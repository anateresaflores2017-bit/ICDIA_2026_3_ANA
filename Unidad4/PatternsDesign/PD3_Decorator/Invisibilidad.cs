namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD3_Decorator;

public class Invisibilidad : HabilidadDecorator
{
    public Invisibilidad(IPersonaje personaje)
        : base(personaje)
    {
    }

    public override string Descripcion()
    {
        return personaje.Descripcion() + " + Invisibilidad";
    }

    public override int Poder()
    {
        return personaje.Poder() + 20;
    }
}