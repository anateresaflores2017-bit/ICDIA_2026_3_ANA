namespace AppsPortafolioEvidencias.Apuntes
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }

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

    public class A18_Sensor
    {
        public void Ejecutar()
        {
            SensorTemperatura sensor = new SensorTemperatura(1, "Temperatura", "C", 100);
            Console.WriteLine($"Sensor {sensor.Id}: {sensor.Nombre} ({sensor.Unidad}), máximo {sensor.TemperaturaMaxima}");
        }
    }
}
