namespace AppsPortafolioEvidencias.Apuntes
{
    public class A13_Conscom
    {
        public class Dataset
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public int NumeroInstancias { get; set; }
            public int NumeroCaracteristicas { get; set; }

            public Dataset(int id, string nombre, int numeroInstancias, int numeroCaracteristicas)
            {
                Id = id;
                Nombre = nombre;
                NumeroInstancias = numeroInstancias;
                NumeroCaracteristicas = numeroCaracteristicas;
            }

            public override string ToString()
            {
                return $"{Id}-{Nombre}-" +
                 $"{NumeroInstancias} instancias-" +
                 $"{NumeroCaracteristicas} características";
            }
        }
        public void Ejecutar()
        {
            Dataset iris = new Dataset(1, "Iris", 150, 4);
            Console.WriteLine(iris);
        }
    }
}
