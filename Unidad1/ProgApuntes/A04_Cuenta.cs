namespace AppsPortafolioEvidencias.Apuntes
{
    
        public class A04_Cuenta
        {
            private double saldo;
            public double Saldo
            {
                get { return saldo; }
                private set { saldo = value; }
            }
            public void Depositar(double cantidad)
            {
                if (cantidad > 0)
                { 
                    Saldo += cantidad; 
                }
            }
        }
    }
