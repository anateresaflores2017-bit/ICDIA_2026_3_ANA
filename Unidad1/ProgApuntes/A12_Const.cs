namespace AppsPortafolioEvidencias.Apuntes
{
    public class A12_Const
    {
        public class Dataset
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int NumeroInstancias { get; set; }
            public int NumeroCaracteristicas { get; set; }

            public Dataset() : this(0, "Sin nombre", 0, 0)
            {
            }

            public Dataset(int id) : this(id, "Sin nombre", 0, 0)
            {
            }

            public Dataset(int id, string nombre, int instancias, int caracteristicas)
            {
                Id = id;
                Nombre = nombre;
                NumeroInstancias = instancias;
                NumeroCaracteristicas = caracteristicas;
            }
        }

        public void Ejecutar()
        {
            Dataset iris = new Dataset(1, "Iris", 150, 4);
            Console.WriteLine($"Id: {iris.Id}");
            Console.WriteLine($"Nombre: {iris.Nombre}");
            Console.WriteLine($"Instancias: {iris.NumeroInstancias}");
            Console.WriteLine($"Características: {iris.NumeroCaracteristicas}");
        }
    }
}
