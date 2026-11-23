using ICDIA_2026_3_AppsPortafolioEvidencias.Modelos;

namespace ICDIA_2026_3_AppsPortafolioEvidencias.Handlers;

public class LogicaAhorcado
{
    private Ahorcado juego_ahorcado;
    
    public LogicaAhorcado(string palabra_a_adivinar)
    {

        juego_ahorcado = new Ahorcado(palabra_a_adivinar);

    }

    public bool isFinished()
    {
        bool palabraAdivinada = juego_ahorcado.VerificarPalabraAAdivinar();
        if (juego_ahorcado.Vidas == 0 || palabraAdivinada)
        {
            return true;
        }
        return false;
    }
}