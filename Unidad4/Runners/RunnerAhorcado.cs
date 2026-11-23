using ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Runners;

public class RunnerAhorcado
{
    public RunnerAhorcado()
    {
        Console.WriteLine("Inicio del Juego");
        string palabra_to_adivinar = "gato";
        LogicaAhorcado juego = new LogicaAhorcado(palabra_to_adivinar);
        
        //Console.WriteLine("...");
        while (!juego.isFinished())
        {
            Console.WriteLine("Ingresa una letra:...");
            char letra = Console.ReadLine()[0];
            Console.WriteLine("Letra ingresada: " + letra);
        }
        
    }
    
}