namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD3_Decorator;

//Decorator BASE
public abstract class HabilidadDecorator : IPersonaje
{
    protected IPersonaje personaje;

    public HabilidadDecorator(IPersonaje personaje)
    {
        this.personaje = personaje;
    }

    public virtual string Descripcion()
    {
        return personaje.Descripcion();
    }

    public virtual int Poder()
    {
        return personaje.Poder();
    }
}