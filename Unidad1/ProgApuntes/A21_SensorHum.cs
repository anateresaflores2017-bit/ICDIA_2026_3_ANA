namespace AppsPortafolioEvidencias.Apuntes
{
    public class A21_SensorHum
    {
        public class Sensor
        {
            public int Id { get; set; }
            public string Nombre { get; set; } = string.Empty;
            public string Unidad { get; set; } = string.Empty;

            public Sensor(int id, string nombre, string unidad)
            {
                Id = id;
                Nombre = nombre;
                Unidad = unidad;
            }
        }

        public class SensorTemperatura : Sensor
        {
            public double TemperaturaMaxima { get; set; }

            public SensorTemperatura(int id, string nombre, string unidad, double temperaturaMaxima)
                : base(id, nombre, unidad)
            {
                TemperaturaMaxima = temperaturaMaxima;
            }
        }

        public class SensorHumedad : Sensor
        {
            public double HumedadRelativa { get; set; }

            public SensorHumedad(int id, string nombre, string unidad, double humedadRelativa)
                : base(id, nombre, unidad)
            {
                HumedadRelativa = humedadRelativa;
            }
        }

        public void Ejecutar()
        {
            SensorTemperatura temperatura = new SensorTemperatura(1, "Temperatura", "C", 100);
            SensorHumedad humedad = new SensorHumedad(2, "Humedad", "%", 95);

            Console.WriteLine($"Sensor {temperatura.Id}: {temperatura.Nombre} ({temperatura.Unidad}), máximo {temperatura.TemperaturaMaxima}");
            Console.WriteLine($"Sensor {humedad.Id}: {humedad.Nombre} ({humedad.Unidad}), humedad relativa {humedad.HumedadRelativa}%");
        }
    }
}
