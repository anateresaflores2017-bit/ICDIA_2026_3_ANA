namespace AppsPortafolioEvidencias.Apuntes
{
    public class A15_Icomparable
    {
        public class Dataset : IComparable<Dataset>
        {
            public string Nombre { get; set; } = string.Empty;
            public int NumeroInstancias { get; set; }

            public int CompareTo(Dataset? other)
            {
                if (other is null) return 1;
                return NumeroInstancias.CompareTo(other.NumeroInstancias);
            }
        }

        public void Ejecutar()
        {
            List<Dataset> datasets = new List<Dataset>();

            datasets.Add(new Dataset { Nombre = "A", NumeroInstancias = 1000 });
            datasets.Add(new Dataset { Nombre = "B", NumeroInstancias = 150 });
            datasets.Add(new Dataset { Nombre = "C", NumeroInstancias = 500 });

            datasets.Sort();
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine($"{dataset.Nombre}: {dataset.NumeroInstancias}");
            }
        }
    }
}
