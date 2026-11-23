using System;

namespace MachineLearning
{
    public class Metrica
    {
        // Campos privados (encapsulamiento)
        private string _nombre;
        private double _valor;

        // Propiedad Nombre
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Propiedad Valor: solo acepta números entre 0 y 1
        public double Valor
        {
            get { return _valor; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException(
                        nameof(Valor),
                        value,
                        "El valor debe estar entre 0 y 1.");
                }
                _valor = value;
            }
        }

        // Constructor vacío
        public Metrica()
        {
            _nombre = string.Empty;
            _valor = 0;
        }

        // Constructor completo
        public Metrica(string nombre, double valor)
        {
            _nombre = nombre;
            Valor = valor; // usa el setter para validar
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Valor: {Valor}";
        }
    }
}