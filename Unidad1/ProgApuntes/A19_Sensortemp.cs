namespace AppsPortafolioEvidencias.Apuntes
{
    public class SensorHumedad : Sensor
    {
        public double HumedadMaxima { get; set; }

        public SensorHumedad(int id, string nombre, string unidad, double humedadMaxima)
            : base(id, nombre, unidad)
        {
            HumedadMaxima = humedadMaxima;
        }
    }

    public class A19_Sensortemp
    {
        public void Ejecutar()
        {
            SensorTemperatura sensorTemperatura = new SensorTemperatura(1, "Temperatura", "C", 100);
            SensorHumedad sensorHumedad = new SensorHumedad(2, "Humedad", "%", 95);

            Console.WriteLine($"Sensor {sensorTemperatura.Id}: {sensorTemperatura.Nombre} ({sensorTemperatura.Unidad}), máximo {sensorTemperatura.TemperaturaMaxima}");
            Console.WriteLine($"Sensor {sensorHumedad.Id}: {sensorHumedad.Nombre} ({sensorHumedad.Unidad}), máximo {sensorHumedad.HumedadMaxima}");
        }
    }
}
