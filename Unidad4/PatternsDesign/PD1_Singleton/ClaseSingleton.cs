namespace ICDIA_2026_3_AppsPortafolioEvidencias.PatternsDesign.PD1_Singleton;

// Sealed es una clase que no puede ser heredada por otras clases,
// bloqueando la extensión de su funcionalidad
public sealed class ClaseSingleton
{
        // Instancia única y estática
        private static ClaseSingleton instancia;
        
        
        ///// ----> 
        private int valor;
        public int Valor { get => valor; set => valor = value; }
        ///// ---->
        
        // Objeto para bloqueo de hilos
        // Evita problemas cuando varios hilos intentan crear la instancia al mismo tiempo.
        private static readonly object candado = new object();

        // Constructor privado
        private ClaseSingleton()
        {
            Console.WriteLine("Instancia creada");
        }

        // Método público para obtener la instancia
        public static ClaseSingleton ObtenerInstancia()
        {
            // Verifica si ya existe
            if (instancia == null)
            {
                lock (candado)
                {
                    // Segunda verificación para evitar múltiples instancias
                    if (instancia == null)
                    {
                        instancia = new ClaseSingleton();
                    }
                }
            }

            return instancia;
        }

        // Método de ejemplo
        public void MostrarMensaje()
        {
            Console.WriteLine("Hola. -> Singleton <- ");
        }
    }

