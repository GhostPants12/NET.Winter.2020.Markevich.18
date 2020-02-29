using System;

namespace Events.Task1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData(50, 50, 50);
            CurrentConditionsReport condition = new CurrentConditionsReport(weatherData.Temperature, weatherData.Humidity, weatherData.Pressure);
            StatisticReport statistics = new StatisticReport();
            weatherData.WeatherDataChanged += condition.Report;
            weatherData.WeatherDataChanged += statistics.AddData;
            for (int i = 0; i < 50; i++)
            {
                weatherData.RandomizeWeatherData();
            }

            Console.WriteLine("Data for 20-th day:");
            statistics.GetDataForDay(20);
            Console.WriteLine("Overall stats");
            statistics.GetOverallStats();
            Console.WriteLine("Last day data");
            statistics.GetDataForLastDay();
            Console.WriteLine("Average stats");
            statistics.GetAverages();
        }
    }
}
