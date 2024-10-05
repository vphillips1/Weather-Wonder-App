namespace WeatherWondersApplication.Models
{

    public class WeatherResponse
    {

        public List<WeatherData> List { get; set; }
        public City City { get; set; }
    }

    public class WeatherData
    {
        public long Dt { get; set; }
        public Main Main { get; set; }
        public List<Weather> Weather { get; set; }

    }

    public class Main
    {
        public double Temp { get; set; }
        public double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
    }

    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int Timezone { get; set; }
    }


}
