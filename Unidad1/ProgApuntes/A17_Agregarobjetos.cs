namespace AppsPortafolioEvidencias.Apuntes
{
    public class A17_Agregarobjetos
    {
        private class Dataset
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public int NumeroInstancias { get; set; }
            public int NumeroCaracteristicas { get; set; }

            public override string ToString()
            {
                return $"{Id}-{Nombre}-{NumeroInstancias} instancias-{NumeroCaracteristicas} características";
            }
        }

        public void Ejecutar()
        {
            List<Dataset> datasets = new List<Dataset>
            {
                new Dataset { Id = 1, Nombre = "Iris", NumeroInstancias = 150, NumeroCaracteristicas = 4 },
                new Dataset { Id = 2, Nombre = "Wine", NumeroInstancias = 178, NumeroCaracteristicas = 13 },
                new Dataset { Id = 3, Nombre = "Digits", NumeroInstancias = 1797, NumeroCaracteristicas = 64 }
            };

            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine(dataset);
            }

            Dataset? encontrado = datasets.Find(dataset => dataset.Id == 2);
            if (encontrado is not null)
            {
                Console.WriteLine($"Encontrado: {encontrado.Nombre}");
                datasets.Remove(encontrado);
            }

            datasets.Sort((x, y) => string.Compare(x.Nombre, y.Nombre, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Elementos restantes: {datasets.Count}");
        }
    }
}
