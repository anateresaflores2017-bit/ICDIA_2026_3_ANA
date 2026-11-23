namespace AppsPortafolioEvidencias.Apuntes
{
    public class A23_Calcular
    {
        public double precisión;

        public int Calcular(int x) { return x; }
        public double Calcular(double x) { return x; }

        public virtual void MetodoVirtual()
        {
            Console.WriteLine("Método virtual de A23_Calcular");
        }

        public void Ejecutar()
        {
            Console.WriteLine($"Calcular(int): {Calcular(5)}");
            Console.WriteLine($"Calcular(double): {Calcular(5.5)}");

            A23_Calcular ejemplo = new ClaseHija();
            ejemplo.MetodoVirtual();
        }
    }

    public class ClaseHija : A23_Calcular
    {
        public override void MetodoVirtual()
        {
            Console.WriteLine("Método virtual sobrescrito en ClaseHija");
        }
    }
}

