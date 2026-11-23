namespace AppsPortafolioEvidencias.Apuntes
{
    public class A20_SensorHumedad
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
            SensorHumedad sensor = new SensorHumedad(2, "Humedad", "%", 95);
            Console.WriteLine($"Sensor {sensor.Id}: {sensor.Nombre} ({sensor.Unidad}), humedad relativa {sensor.HumedadRelativa}%");
        }
    }
}
