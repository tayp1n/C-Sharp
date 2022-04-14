using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
 
namespace ConsoleApplication
{
    public static class Program
    {
        public static void Main()
        {
            Weather[] weatherArray = { new Weather(), new Weather(), new Weather() };
            try
            {
                var reportXml = DownloadReport(@"http://api.pogoda.com/index.php?api_lang=ru&localidad=13088&affiliate_id=4v7j6at7rkya");
                Report report = DeserializeReport(reportXml);
                LocationParameter[] parameters = report.Locations[0].Parameters;
                SetForecastParameters(weatherArray, parameters);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error - {e.Message}");
            }
 
            Console.WriteLine($"Сегодня - {weatherArray[0]}");
            Console.WriteLine($"Завтра - {weatherArray[1]}");
            Console.WriteLine($"Послезавтра - {weatherArray[2]}");
        }
 
        private static void SetForecastParameters(Weather[] weatherArray, LocationParameter[] parameters)
        {
            Action<Weather, Forecast> setMinT = (weather, forecast) => weather.MinT = int.Parse(forecast.Value);
            Action<Weather, Forecast> setMaxT = (weather, forecast) => weather.MaxT = int.Parse(forecast.Value);
            Action<Weather, Forecast> setWindSpeed = (weather, forecast) => weather.WindSpeed = int.Parse(forecast.IdB);
            Action<Weather, Forecast> setCloudy = (weather, forecast) => weather.Cloudy = forecast.Value;
 
            SetForecastParameter(weatherArray, parameters, "Мин. температура", setMinT);
            SetForecastParameter(weatherArray, parameters, "Макс. температура", setMaxT);
            SetForecastParameter(weatherArray, parameters, "Ветер", setWindSpeed);
            SetForecastParameter(weatherArray, parameters, "Состояние атмосферы", setCloudy);
        }
 
        private static void SetForecastParameter(
            Weather[] weatherArray,
            LocationParameter[] parameters,
            string parameterName,
            Action<Weather, Forecast> setAction)
        {
            Forecast[] data = parameters.First(x => x.Name == parameterName).Data;
            for (var i = 0; i < weatherArray.Length; i++)
            {
                setAction(weatherArray[i], data[i]);
            }
        }
 
        private static string DownloadReport(string url)
        {
            using (var webClient = new WebClient { Encoding = Encoding.UTF8 })
            {
                return webClient.DownloadString(url);
            }
        }
 
        private static Report DeserializeReport(string xml)
        {
            var serializer = new XmlSerializer(typeof(Report));
            using (TextReader reader = new StringReader(xml))
            {
                return (Report)serializer.Deserialize(reader);
            }
        }
    }
 
    public class Weather
    {
        public int MinT { get; set; }
        public int MaxT { get; set; }
        public int WindSpeed { get; set; }
        public string Cloudy { get; set; }
 
        public override string ToString()
        {
            return $"Мин. температура: {MinT}, "
                + $"Макс. температура: {MaxT}, "
                + $"Скорость ветра: {WindSpeed}, "
                + $"Состояние атмосферы: {Cloudy}";
        }
    }
 
    [XmlRoot("report")]
    public class Report
    {
        [XmlElement("location")]
        public Location[] Locations { get; set; }
    }
 
    public class Location
    {
        [XmlAttribute("city")]
        public string City { get; set; }
 
        [XmlElement("var")]
        public LocationParameter[] Parameters { get; set; }
    }
 
    public class LocationParameter
    {
        [XmlElement("name")]
        public string Name { get; set; }
 
        [XmlArray("data")]
        [XmlArrayItem("forecast")]
        public Forecast[] Data { get; set; }
    }
 
    public class Forecast
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
 
        [XmlAttribute("idB")]
        public string IdB { get; set; }
    }
}