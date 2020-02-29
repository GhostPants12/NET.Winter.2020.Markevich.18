using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Task1
{
    public class StatisticReport
    {
        private List<int> temperatureList;
        private List<int> humidityList;
        private List<int> pressureList;

        /// <summary>Initializes a new instance of the <see cref="StatisticReport"/> class.</summary>
        public StatisticReport()
        {
            this.temperatureList = new List<int>();
            this.humidityList = new List<int>();
            this.pressureList = new List<int>();
        }

        /// <summary>Adds the data.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="WeatherDataChangedEventArgs"/> instance containing the event data.</param>
        public void AddData(object sender, WeatherDataChangedEventArgs args)
        {
            this.temperatureList.Add(args.NewTemperature);
            this.humidityList.Add(args.NewHumidity);
            this.pressureList.Add(args.NewPressure);
        }

        /// <summary>Gets the overall stats.</summary>
        public void GetOverallStats()
        {
            for (int i = 0; i < this.temperatureList.Count; i++)
            {
                this.GetDataForDay(i);
            }
        }

        /// <summary>Gets the average values.</summary>
        public void GetAverages()
        {
            double temperatureSum = 0;
            double humiditySum = 0;
            double pressureSum = 0;
            for (int i = 0; i < this.temperatureList.Count; i++)
            {
                temperatureSum += this.temperatureList[i];
                humiditySum += this.humidityList[i];
                pressureSum += this.pressureList[i];
            }

            Console.WriteLine($"Average temperature is {temperatureSum / this.temperatureList.Count}");
            Console.WriteLine($"Average humidity is {humiditySum / this.temperatureList.Count}");
            Console.WriteLine($"Average pressure is {pressureSum / this.temperatureList.Count}");
            Console.WriteLine("-----------------------------------------------------------");
        }

        /// <summary>Gets the data for last day.</summary>
        public void GetDataForLastDay()
        {
            this.GetDataForDay(this.temperatureList.Count - 1);
        }

        /// <summary>Gets the data for specified day.</summary>
        /// <param name="number">The day's number.</param>
        /// <exception cref="ArgumentOutOfRangeException">number is more than recorded days.</exception>
        public void GetDataForDay(int number)
        {
            if (number > this.temperatureList.Count - 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(number)} is more than recorded days.");
            }

            Console.WriteLine($"Day {number}");
            Console.WriteLine($"Temperature is {this.temperatureList[number]} degrees celsius.");
            Console.WriteLine($"Humidity is {this.humidityList[number]} percent.");
            Console.WriteLine($"Pressure is {this.pressureList[number]} kPa.");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
