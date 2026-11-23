namespace AppsPortafolioEvidencias.Apuntes
{
    public class A10_Cambiarnombre
    {
        public int NumeroInstancia { get; set; }
        public int NumeroCaracteristicas { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public double CalcularDensidad()
        {
            if (NumeroCaracteristicas <= 0)
            {
                throw new InvalidOperationException("El número de características debe ser mayor que cero.");
            }

            return (double)NumeroInstancia / NumeroCaracteristicas;
        }

        public void CambiarNombre(string nuevoNombre)
        {
            Nombre = nuevoNombre ?? throw new ArgumentNullException(nameof(nuevoNombre));
        }

        public void Ejecutar()
        {
            NumeroInstancia = 150;
            NumeroCaracteristicas = 4;
            Nombre = "Iris";

            Console.WriteLine($"Densidad de {Nombre}: {CalcularDensidad()}");
            Console.Write("Ingresa el nuevo nombre: ");
            string? nuevoNombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                return;
            }

            CambiarNombre(nuevoNombre);
            Console.WriteLine($"Nombre modificado: {Nombre}");
        }
    }
}
