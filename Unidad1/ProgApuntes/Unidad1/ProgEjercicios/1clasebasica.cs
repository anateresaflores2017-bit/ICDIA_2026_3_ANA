namespace ICDIA_2026_3_AppsPortafolioEvidencias.Unidad1.ProgsApuntes;
{
    public class AlgoritmoML
    {
        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Complejidad { get; set; }

        // Constructor vacío
        public AlgoritmoML()
        {
            Id = 0;
            Nombre = string.Empty;
            Tipo = string.Empty;
            Complejidad = string.Empty;
        }

        // Constructor por identificador
        public AlgoritmoML(int id)
        {
            Id = id;
            Nombre = string.Empty;
            Tipo = string.Empty;
            Complejidad = string.Empty;
        }

        // Constructor completo
        public AlgoritmoML(int id, string nombre, string tipo, string complejidad)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Complejidad = complejidad;
        }

        // ToString
        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Tipo: {Tipo}, Complejidad: {Complejidad}";
        }
    }
}