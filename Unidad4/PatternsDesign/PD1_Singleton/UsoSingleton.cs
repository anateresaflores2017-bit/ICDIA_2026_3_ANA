namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD1_Singleton;

public class UsoSingleton
{
    public UsoSingleton()
    {
        
        ClaseSingleton s1 = ClaseSingleton.ObtenerInstancia();
        ClaseSingleton s2 = ClaseSingleton.ObtenerInstancia();

        s1.MostrarMensaje();
        s2.Valor = 50;
        Console.WriteLine(s1.Valor);
        
        if (s1 == s2)
        {
            Console.WriteLine("Ambas variables acceden a la ubicacion de memoria de la misma instancia");
        }
        else
        {
            Console.WriteLine("Son instancias diferentes");
        }
        
    }

}