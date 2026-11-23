namespace AppsPortafolioEvidencias.Apuntes
{
    public class A14_Equals
    {
        public class Dataset : IEquatable<Dataset> {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public bool Equals(Dataset? other)
            {
                if (other is null)
                    return false;

                return Id == other.Id;
            }
            public override bool Equals(object? obj) {
                return Equals(obj as Dataset);
            }
            public override int GetHashCode()
            {
                return Id.GetHashCode();
            }
            public override string ToString()
            {
                return $"{Id}-{Nombre}";
            }
        }

        public void Ejecutar()
        {
            Dataset a = new Dataset { Id = 1, Nombre = "Iris" };
            Dataset b = new Dataset { Id = 1, Nombre = "Iris copia" };
            Console.WriteLine(a.Equals(b));
        }
    }
}
