namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD3_Decorator;

public class UsoDecorator
{
    public UsoDecorator()
    {
        // Personaje base
        IPersonaje personaje = new Guerrero();
        Console.WriteLine(personaje.Descripcion());
        Console.WriteLine("Poder: " + personaje.Poder() + "\n");
        
        personaje = new EspadaLegendaria(personaje);
        Console.WriteLine(personaje.Descripcion());
        Console.WriteLine("Poder: " + personaje.Poder() + "\n");
        
        personaje = new EscudoLegendario(personaje);
        Console.WriteLine(personaje.Descripcion());
        Console.WriteLine("Poder: " + personaje.Poder() + "\n");
        
        personaje = new Invisibilidad(personaje);
        Console.WriteLine(personaje.Descripcion());
        Console.WriteLine("Poder: " + personaje.Poder() + "\n");
    }
}