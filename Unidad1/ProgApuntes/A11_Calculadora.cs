namespace AppsPortafolioEvidencias.Apuntes
{
    public class A11_Calculadora
    {
        public int Sumar(int a, int b) => a + b;

        public double Sumar(double a, double b) => a + b;

        public int Sumar(int a, int b, int c) => a + b + c;

        public void Ejecutar()
        {
            Console.WriteLine(Sumar(2, 3));
            Console.WriteLine(Sumar(2.5, 3.1));
            Console.WriteLine(Sumar(1, 2, 3));
        }
    }
}
