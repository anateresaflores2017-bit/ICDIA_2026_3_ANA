namespace AppsPortafolioEvidencias.Apuntes
{
    public class A16_Comparador
    {
        public class Dataset
        {
            public string Nombre { get; set; } = string.Empty;
            public int NumeroCaracteristicas { get; set; }
        }

        private sealed class ComparadorDatasetPorNombre : IComparer<Dataset>
        {
            public int Compare(Dataset? x, Dataset? y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (x is null) return -1;
                if (y is null) return 1;
                return string.Compare(x.Nombre, y.Nombre, StringComparison.OrdinalIgnoreCase);
            }
        }

        private sealed class ComparadorDatasetPorCaracteristicas : IComparer<Dataset>
        {
            public int Compare(Dataset? x, Dataset? y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (x is null) return -1;
                if (y is null) return 1;
                return x.NumeroCaracteristicas.CompareTo(y.NumeroCaracteristicas);
            }
        }

        public void Ejecutar()
        {
            List<Dataset> datasets = new List<Dataset>
            {
                new Dataset { Nombre = "Wine", NumeroCaracteristicas = 13 },
                new Dataset { Nombre = "Iris", NumeroCaracteristicas = 4 },
                new Dataset { Nombre = "Digits", NumeroCaracteristicas = 64 }
            };

            Console.WriteLine("Ordenados por nombre:");
            datasets.Sort(new ComparadorDatasetPorNombre());
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine(dataset.Nombre);
            }

            Console.WriteLine("Ordenados por número de características:");
            datasets.Sort(new ComparadorDatasetPorCaracteristicas());
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine($"{dataset.Nombre}: {dataset.NumeroCaracteristicas}");
            }
        }
    }
}
