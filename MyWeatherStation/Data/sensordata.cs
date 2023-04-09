namespace MyWeatherStation.Data
{
    public class sensordata
    {
        public int id { get; set; }

        public string temperature { get; set; }

        public string pressure { get; set; }
        //((double.Parse(pressure) * 100) / Math.Pow((1 - (323) / 44330), 5.255) / 100).ToString();

        public string humidity { get; set; }

        public string temperature_bmp { get; set; }

        public string reading_time { get; set; }
    }
}
