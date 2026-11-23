namespace ICDIA_2026_3_AppsPortafolioEvidencias.Modelos;

public class Ahorcado
{
    //Atributos
    private string palabra_a_adivinar;
    private char[] letras_encontradas;
    private char[] letras_utilizadas;
    private int vidas;
    
    //Propiedades
    public string PalabraAAdivinar
    {
        get => palabra_a_adivinar;
        set => palabra_a_adivinar = value ?? throw new ArgumentNullException(nameof(value));
    }

    public char[] LetrasEncontradas
    {
        get => letras_encontradas;
        set => letras_encontradas = value ?? throw new ArgumentNullException(nameof(value));
    }

    public char[] LetrasUtilizadas
    {
        get => letras_utilizadas;
        set => letras_utilizadas = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Vidas
    {
        get => vidas;
        set => vidas = value;
    }

    public Ahorcado(string palabra_a_adivinar)
    {
        PalabraAAdivinar = palabra_a_adivinar;
        vidas = 5;
        LetrasEncontradas = new char[PalabraAAdivinar.Length];
        LetrasUtilizadas = new char[PalabraAAdivinar.Length + vidas];
    }

    public bool VerificarPalabraAAdivinar()
    {
        bool resultado = true;
        for (int i = 0; i < PalabraAAdivinar.Length; i++)
        {
            if (PalabraAAdivinar[i] != LetrasEncontradas[i])
            {
                return false;
            }
        }
        return resultado;
        
    }
    
}