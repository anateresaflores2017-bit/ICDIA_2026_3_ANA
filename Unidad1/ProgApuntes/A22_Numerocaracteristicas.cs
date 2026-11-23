namespace AppsPortafolioEvidencias.Apuntes
{
    public class A22_Numerocaracteristicas
    {
        public class Dataset : IEquatable<Dataset>, IComparable<Dataset>
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

            public virtual string ObtenerTipo() => "Dataset genérico";

            public override string ToString()
            {
                return $"{Id} - {Nombre} - {NumeroInstancias} instancias - {NumeroCaracteristicas} características";
            }

            public bool Equals(Dataset? other) => other is not null && Id == other.Id;

            public override bool Equals(object? obj) => Equals(obj as Dataset);

            public override int GetHashCode() => Id.GetHashCode();

            public int CompareTo(Dataset? other)
            {
                return other is null ? 1 : NumeroInstancias.CompareTo(other.NumeroInstancias);
            }
        }

        public class DatasetImagenes : Dataset
        {
            public int AnchoImagen { get; set; }
            public int AltoImagen { get; set; }

            public DatasetImagenes(int id, string nombre, int numeroInstancias, int numeroCaracteristicas, int anchoImagen, int altoImagen)
                : base(id, nombre, numeroInstancias, numeroCaracteristicas)
            {
                AnchoImagen = anchoImagen;
                AltoImagen = altoImagen;
            }

            public override string ObtenerTipo() => "Dataset de imágenes";

            public override string ToString()
            {
                return $"{base.ToString()} - {AnchoImagen}x{AltoImagen} px";
            }
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

        public void Ejecutar()
        {
            List<Dataset> datasets = new()
            {
                new Dataset(1, "Iris", 150, 4),
                new Dataset(2, "Wine", 178, 13),
                new DatasetImagenes(3, "Dígitos", 1797, 64, 8, 8)
            };

            Console.WriteLine("Lista original:");
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine($"{dataset} ({dataset.ObtenerTipo()})");
            }

            Console.WriteLine("\nOrden natural por número de instancias:");
            datasets.Sort();
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine(dataset);
            }

            Console.WriteLine("\nOrden por nombre:");
            datasets.Sort(new ComparadorDatasetPorNombre());
            foreach (Dataset dataset in datasets)
            {
                Console.WriteLine(dataset);
            }
        }
    }
}
